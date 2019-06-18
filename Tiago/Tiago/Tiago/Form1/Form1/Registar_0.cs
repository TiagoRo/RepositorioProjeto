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
    public partial class usercontrol_Registar : UserControl
    {
        private static usercontrol_Registar _instance;

        public static usercontrol_Registar Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new usercontrol_Registar();
                return _instance;
            }
        }
        public usercontrol_Registar()
        {
            InitializeComponent();
        }

        private string userInserido = "";
        private string passInserida = "";
        private string sexoInserido = "";
        private string emailInserido = "";
        private string telemovelInserido = "";

        private static string _connectionString = "Server=localhost;Database=projeto2019;Uid=root;Pwd=Tr_2017&;SslMode=none";
        private static MySqlConnection db = new MySqlConnection(_connectionString);

        private void userText(object sender, EventArgs e)
        {
            userInserido = Convert.ToString(userTextBox.Text);
        }

        private void passText(object sender, EventArgs e)
        {
            passInserida = Convert.ToString(passTextBox.Text);
        }

        private void emailText(object sender, EventArgs e)
        {
            emailInserido = Convert.ToString(emailTextBox.Text);
        }

        private void telemovelText(object sender, EventArgs e)
        {
            telemovelInserido = Convert.ToString(telemovelTextBox.Text);
        }

        private void radioBtnM(object sender, EventArgs e)
        {
            sexoInserido = "M";
        }

        private void radioBtnF(object sender, EventArgs e)
        {
            sexoInserido = "F";
        }

        //codigo para registar o novo utilizador
        private void adicionar_Click(object sender, EventArgs e)
        {

            MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = db;

            try
            {
                db.Open();

                Console.WriteLine("Sexo -> " + sexoInserido);

                if (!string.IsNullOrEmpty(userInserido) && !string.IsNullOrEmpty(passInserida) &&
                    !string.IsNullOrEmpty(emailInserido) && !string.IsNullOrEmpty(telemovelInserido) &&
                    !string.IsNullOrEmpty(sexoInserido))
                {
                    if (existeUsername(Convert.ToString(userInserido),Convert.ToString(passInserida), inserirDados))
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
                        
                        Welcome Welcome = new Welcome();
                        Welcome.Hide();
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
                if (db.State == System.Data.ConnectionState.Open)
                {
                    db.Close();
                    Console.WriteLine("Ligação à BD fechada registo.");
                }
            }
        }

        //codigo para confirmar na base de dados a existencia de outro utilizador com o mesmo username
        private Boolean existeUsername(string user, string pass, MySqlCommand inserirDados)
        {
            MySqlDataReader resultado;

            try
            {
                // Vamos analisar se o user existe
                inserirDados.CommandText = "select 1 from users where username=@user";
                inserirDados.Parameters.Add("@user", MySqlDbType.String).Value = Convert.ToString(user);

                resultado = inserirDados.ExecuteReader();

                // Se a query devolver pelo menos 1 linha, é porque existe user. Se nao devolver, nao existe
                if (resultado.HasRows)
                {
                    Console.WriteLine("Existe user!");

                    // Agora vamos analisar a password
                    inserirDados.CommandText = "select 1 from users where username=@user and password=@pass";
                    inserirDados.Parameters.Add("@user", MySqlDbType.String).Value = Convert.ToString(user);
                    inserirDados.Parameters.Add("@pass", MySqlDbType.String).Value = Convert.ToString(pass);

                    resultado = inserirDados.ExecuteReader();

                    // Se a query devolver pelo menos 1 linha, é porque a password está correcta, neste user especifico. Se nao devolver nada, nao existe
                    if (resultado.HasRows)
                    {
                        Console.WriteLine("User e pass correctas!");
                        resultado.Close();
                        return true;
                    }

                    Console.WriteLine("Password incorrecta!");

                    resultado.Close();
                    return false;
                }
                resultado.Close();

            }
            catch (Exception ex)
            {
                // Erro
                Console.WriteLine($"\nErro: {ex.Message}");
            }

            // Nao existe user. Retorna false
            Console.WriteLine("Não existe user.");
            return false;
        }

        //criar caixas de mensagens
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
            if (passTextBox.Text == "Palavra Passe")
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
                passTextBox.Text = "Palavra Passe";
                passTextBox.ForeColor = Color.Black;
                passTextBox.UseSystemPasswordChar = true;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
                emailTextBox.UseSystemPasswordChar = false;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Email";
                emailTextBox.ForeColor = Color.Black;
                emailTextBox.UseSystemPasswordChar = false;
            }
        }

        private void telemovelTextBox_Enter(object sender, EventArgs e)
        {
            if (telemovelTextBox.Text == "Telemovel")
            {
                telemovelTextBox.Text = "";
                telemovelTextBox.ForeColor = Color.Black;
                telemovelTextBox.UseSystemPasswordChar = false;
            }
        }

        private void telemovelTextBox_Leave(object sender, EventArgs e)
        {
            if (telemovelTextBox.Text == "")
            {
                telemovelTextBox.Text = "Telemovel";
                telemovelTextBox.ForeColor = Color.Black;
                telemovelTextBox.UseSystemPasswordChar = false;
            }
        }
    }
}
