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
    public partial class Registar : UserControl
    {
        public Registar()
        {
            InitializeComponent();
        }

        private static Registar _instance;

        public static Registar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Registar();
                return _instance;
            }
        }

        private string userInserido = "";
        private string passInserida = "";
        private string sexoInserido = "";
        private string emailInserido = "";
        private string telemovelInserido = "";

        

        private void txtBox_username_TextChanged(object sender, EventArgs e)
        {
            userInserido = Convert.ToString(txtBox_username.Text);
        }

        private void txtBox_password_TextChanged(object sender, EventArgs e)
        {
            passInserida = Convert.ToString(txtBox_password.Text);
        }

        private void txtBox_email_TextChanged(object sender, EventArgs e)
        {
            emailInserido = Convert.ToString(txtBox_email.Text);
        }

        private void txtBox_telemovel_TextChanged(object sender, EventArgs e)
        {
            telemovelInserido = Convert.ToString(txtBox_telemovel.Text);
        }

        private void radioBtn_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            sexoInserido = "M";
        }

        private void radioBtn_Femenino_CheckedChanged(object sender, EventArgs e)
        {
            sexoInserido = "F";
        }

        private void infoOk(string cabeçalho, string msg)
        {
            string mensagem = msg;
            string caption = cabeçalho;
            MessageBoxButtons botao = MessageBoxButtons.OK;
            MessageBox.Show(mensagem, caption, botao);
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = Utils.db;

            try
            {
                Utils.db.Open();

                Console.WriteLine("Sexo -> " + sexoInserido);

                if (!string.IsNullOrEmpty(userInserido) && !string.IsNullOrEmpty(passInserida) &&
                    !string.IsNullOrEmpty(emailInserido) && !string.IsNullOrEmpty(telemovelInserido) &&
                    !string.IsNullOrEmpty(sexoInserido) && txtBox_username.Text != "Nome de Utilizador" &&
                    txtBox_password.Text != "Palavra-passe" && txtBox_email.Text != "Email" &&
                    txtBox_telemovel.Text != "Nº Telemovel")
                {
                    if (Utils.ExisteUsername(Convert.ToString(userInserido),Convert.ToString(passInserida), inserirDados))
                        infoOk("Erro", "Username já existe");

                    else
                    {
                        inserirDados.CommandText = "insert into users (username, pass, email, sexo, telemovel) values (@user, @pass, @email, @sexo, @telemovel)";

                        inserirDados.Parameters.Add("@user", MySqlDbType.String).Value = Convert.ToString(userInserido);
                        inserirDados.Parameters.Add("@pass", MySqlDbType.String).Value = Convert.ToString(passInserida);
                        inserirDados.Parameters.Add("@email", MySqlDbType.String).Value = Convert.ToString(emailInserido);
                        inserirDados.Parameters.Add("@sexo", MySqlDbType.String).Value = Convert.ToString(sexoInserido);
                        inserirDados.Parameters.Add("@telemovel", MySqlDbType.Int32).Value = Convert.ToInt32(telemovelInserido);

                        int linhasCriadas = inserirDados.ExecuteNonQuery();

                        if (linhasCriadas > 0)
                            infoOk("Sucesso", "Foi inserido um novo user com o nome " + userInserido);

                        Console.WriteLine("Inserido o user: " + userInserido);

                        Welcome Inicio = new Welcome();
                        Inicio.Hide();
                        PaginaPrincipal Loja = new PaginaPrincipal();
                        Loja.Show();
                        
                    }
                }
                else
                {
                    infoOk("Erro", "Faltam inserir dados no formulário.");
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
                    Console.WriteLine("Ligação à BD fechada registo.");
                }
            }
        }

        private void txtBox_username_Enter(object sender, EventArgs e)
        {
            if(txtBox_username.Text == "Nome de Utilizador")
            {
                txtBox_username.Text = "";
            }
        }

        private void txtBox_username_Leave(object sender, EventArgs e)
        {
            if (txtBox_username.Text == "")
            {
                txtBox_username.Text = "Nome de Utilizador";
            }
        }

        private void txtBox_password_Enter(object sender, EventArgs e)
        {
            if (txtBox_password.Text == "Palavra-passe")
            {
                txtBox_password.Text = "";
            }
        }

        private void txtBox_password_Leave(object sender, EventArgs e)
        {
            if (txtBox_password.Text == "")
            {
                txtBox_password.Text = "Palavra-passe";
            }
        }

        private void txtBox_email_Enter(object sender, EventArgs e)
        {
            if (txtBox_email.Text == "Email")
            {
                txtBox_email.Text = "";
            }
        }

        private void txtBox_email_Leave(object sender, EventArgs e)
        {
            if (txtBox_email.Text == "")
            {
                txtBox_email.Text = "Email";
            }
        }

        private void txtBox_telemovel_Enter(object sender, EventArgs e)
        {
            if (txtBox_telemovel.Text == "Nº Telemovel")
            {
                txtBox_telemovel.Text = "";
            }
        }

        private void txtBox_telemovel_Leave(object sender, EventArgs e)
        {
            if (txtBox_telemovel.Text == "")
            {
                txtBox_telemovel.Text = "Nº Telemovel";
            }
        }
    }
}
