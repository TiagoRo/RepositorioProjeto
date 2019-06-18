using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Form1
{
    public partial class form_entrada : UserControl
    {
        private static form_entrada _instance;

        public static form_entrada Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new form_entrada();
                return _instance;
            }
        }

        public form_entrada()
        {
            InitializeComponent();
        }

        private string userInserido = "";
        private string passInserida = "";

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {
            userInserido = Convert.ToString(userTextBox.Text);
        }

        private void passTextBox_TextChanged(object sender, EventArgs e)
        {
            passInserida = Convert.ToString(passTextBox.Text);
        }

        //codigo para confirmar se o utilizador escreve o seu username, pass e 
        //por fim confirmas se existe a conta de utilizador
        private void Entrar_Click(object sender, EventArgs e)
        {
            MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = Utils.db;

            
            try
            {
                Utils.db.Open();
                if (userTextBox.Text == "Nome de Utilizador" || string.IsNullOrEmpty(userTextBox.Text))
                {
                    MessageBox.Show("Escreva o seu Username !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (passTextBox.Text == "Palavra-passe" || string.IsNullOrEmpty(passTextBox.Text))
                {
                    MessageBox.Show("Escreva a sua pass!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!Utils.ExisteUsername(Convert.ToString(userInserido), Convert.ToString(passInserida), inserirDados))
                {
                    infoOk("Erro!", "Credenciais incorretas");
                }
                else
                {
                    this.Hide();
                    PaginaPrincipal Loja = new PaginaPrincipal();
                    Loja.Show();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nErro: {ex.Message}");
            }
            finally
            {
                if (Utils.db.State == System.Data.ConnectionState.Open)
                {
                    Utils.db.Close();
                    Console.WriteLine("Ligação à BD fechada entrada.");
                }
            }
        }

        private void infoOk(string cabeçalho, string msg)
        {
            string mensagem = msg;
            string caption = cabeçalho;
            MessageBoxButtons botao = MessageBoxButtons.OK;
            MessageBox.Show(mensagem, caption, botao);
        }

        private void userTextBox_Enter(object sender, EventArgs e)
        {
            if (userTextBox.Text == "Nome de Utilizador")
            {
                userTextBox.Text = "";
                userTextBox.ForeColor = Color.Black;
                userTextBox.UseSystemPasswordChar = false;
            }
        }

        private void userTextBox_Leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Nome de Utilizador";
                userTextBox.ForeColor = Color.Black;
                userTextBox.UseSystemPasswordChar = false;
            }
        }

        private void passTextBox_Enter(object sender, EventArgs e)
        {
            if (passTextBox.Text == "Palavra-passe")
            {
                passTextBox.Text = "";
                passTextBox.ForeColor = Color.Black;
                passTextBox.UseSystemPasswordChar = true;
            }
        }

        private void passTextBox_Leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "Palavra-passe";
                passTextBox.ForeColor = Color.Black;
                passTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
