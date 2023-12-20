using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ControleFinanceiro
{
    internal class bancoFinanceiro
    {
        public string bancoF = "SERVER=localhost; DATABASE=sqlFinanceiro; UID=root; PWD=; PORT=";

        public MySqlConnection acessBanco = null;

        //abrir banco de dados financeiro
        public void abrirBancoFinanceiro()
        {
            try
            {
                acessBanco = new MySqlConnection(bancoF);
                acessBanco.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor: ==>" + ex.Message);
            }
        }

        //fechar banco de dados financeiro

        public void fecharBancoFinanceiro()
        {
            try
            {
                acessBanco = new MySqlConnection(bancoF);
                acessBanco.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no servidor: ==> " + ex.Message);
            }
        }
    }
}
