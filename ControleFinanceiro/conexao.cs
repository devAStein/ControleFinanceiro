using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControleFinanceiro
{
    internal class Conexao
    {
        public string conec = "SERVER=localhost; DATABASE=sqllogin; UID=root; PWD=; PORT=";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con =new MySqlConnection(conec);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor: ==> " + ex.Message);
            }
            
        }

        public void FecharConexao()
        {
            try
            {
                con= new MySqlConnection(conec);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor: ==> " + ex.Message);
            }
        }
    }
}
