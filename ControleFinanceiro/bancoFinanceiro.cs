using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;


namespace ControleFinanceiro
{
    internal class bancoFinanceiro
    {
        //Responsável pela conexão com o banco
        public static MySqlConnection Conex;
        //Função responsável pela instrução a serem executada
        public static MySqlCommand comando;
        //Adapter responsável por inserir dados um dataTable
        public static MySqlDataAdapter adaptador;
        //Responsável popr ligar o banco em controle com a propriedade DataSource
        public static DataTable datTabela;
        
        public static void conectar()
        {
            Cadastro valorteste = new Cadastro();
            string nomebanco = (Cadastro.nomeBancoDeDados);

             //Estabelece os parâmetros para a conexão com o banco
             Conex = new MySqlConnection("server=localhost;uid=root;pwd=");

            //Abre a conexão com o banco de dados
            Conex.Open();
            //Informa a instrução no SQL

            string mensagem = Convert.ToString("CREATE DATABASE IF NOT EXISTS " + nomebanco + "; use " + nomebanco);

            //comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS bd_usArma; use bd_usArma", Conex);
            comando = new MySqlCommand(mensagem, Conex);
            //Executa a Query no MSQL (raio do workbench)
            comando.ExecuteNonQuery();

            comando = new MySqlCommand("CREATE TABLE IF NOT EXISTS dados " + 
                                      "(id integer auto_increment primary key, " +
                                      "dataEntrada text NOT NULL, " +
                                      "dataLancamento date NOT NULL, " +
                                      "idenEntrada varchar(100) NOT NULL, " +
                                      "valorEntrada double NOT NULL, " +
                                      "valorSaida double NOT NULL)", Conex);
            comando.ExecuteNonQuery();
            //Fecha a conexão com o banco de dados
            Conex.Close();
        }

        string nomeDoBanco = (Login.nomeBancoDeDados);
        public string cmdMsg1 = ("SERVER=localhost; DATABASE=");
        public string cmdMsg2 = ("; UID=root; PWD=; PORT=");

        public MySqlConnection acessBanco = null;

        public void abrirBancoFinanceiro()
        {
            try
            {
                acessBanco = new MySqlConnection(cmdMsg1 + nomeDoBanco + cmdMsg2);
                acessBanco.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor: ==>" + ex.Message);
            }
        }

        public void fecharBancoFinanceiro()
        {
            try
            {
                acessBanco = new MySqlConnection(cmdMsg1 + nomeDoBanco + cmdMsg2);
                acessBanco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor: ==> " + ex.Message);
            }
        }     
    }
}
