using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Form1
{
    static class Utils
    {

        internal static string _connectionString = "Server=localhost;Database=tiago;Uid=root;Pwd=;SslMode=none";
        internal static MySqlConnection db = new MySqlConnection(_connectionString);

        //codigo para confirmar na base de dados a existencia de outro utilizador com o mesmo username
        internal static Boolean ExisteUsername(string user, string pass, MySqlCommand inserirDados)
        {
            MySqlDataReader primeiraLeitura;

            try
            {
                // Vamos analisar se o user existe
                inserirDados.CommandText = "select 1 from users where username=@username";
                inserirDados.Parameters.Add("@username", MySqlDbType.String).Value = Convert.ToString(user);

                primeiraLeitura = inserirDados.ExecuteReader();

                // Se a query devolver pelo menos 1 linha, é porque existe user. Se nao devolver, nao existe
                if (primeiraLeitura.HasRows)
                {
                    primeiraLeitura.Close();

                    MySqlDataReader segundaLeitura;

                    Console.WriteLine("Existe user!");

                    // Agora vamos analisar a password
                    inserirDados.CommandText = "select 1 from users where username=@u and pass=@p";
                    inserirDados.Parameters.Add("@u", MySqlDbType.String).Value = Convert.ToString(user);
                    inserirDados.Parameters.Add("@p", MySqlDbType.String).Value = Convert.ToString(pass);

                    segundaLeitura = inserirDados.ExecuteReader();

                    // Se a query devolver pelo menos 1 linha, é porque a password está correcta, neste user especifico. Se nao devolver nada, nao existe
                    if (segundaLeitura.HasRows)
                    {
                        Console.WriteLine("User e pass correctas!");
                        segundaLeitura.Close();
                        return true;
                    }

                    Console.WriteLine("Password incorrecta!");

                    segundaLeitura.Close();
                    return false;
                }
                primeiraLeitura.Close();

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

        //vai buscar o id do componente a base de dados
        internal static int readIdComponente(String nomeComponente)
        {
            MySqlDataReader ler;
            MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = db;

            try
            {
                db.Open();

                inserirDados.CommandText = "select id from componentes where nome=@nome";
                inserirDados.Parameters.Add("@nome", MySqlDbType.String).Value = nomeComponente;

                ler = inserirDados.ExecuteReader();

                if (ler.HasRows)
                {
                    ler.Read();
                    int id = ler.GetInt32(0);
                    Console.WriteLine("ID lido: " + id);
                    return id;
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

            return -1;
        }

        //introduz o componente na base de dados
        internal static Boolean ComprarComponente(int id)
        {
            MySqlCommand inserirDados = new MySqlCommand();
            inserirDados.Connection = db;

            try
            {
                db.Open();

                inserirDados.CommandText =
                   "INSERT componentesComprados(componente_id, nome, preco) values " +
                   "((select id from componentes where id = @id), " +
                   "(select nome from componentes where id = @id), " +
                   "(select preco from componentes where id = @id))";

                inserirDados.Parameters.Add("@id", MySqlDbType.String).Value = Convert.ToString(id);

                int linhasCriadas = inserirDados.ExecuteNonQuery();

                if (linhasCriadas > 0)
                {
                    //infoOk("Sucesso", "Foi inserido um novo componente");
                    return true;
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
            
            return false;
        }

        internal void infoOk(string cabeçalho, string msg)
        {
            string mensagem = msg;
            string caption = cabeçalho;
            MessageBoxButtons botao = MessageBoxButtons.OK;
            MessageBox.Show(mensagem, caption, botao);
        }
    }
}
