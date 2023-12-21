using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class Cadastro : Form
    {
        Conexao con = new Conexao();
        string sql;
        MySqlCommand cmd;

        Thread t1;

        public Cadastro()
        {
            InitializeComponent();
        }

        public static string nomeBancoDeDados;

        
        public void button1_Click(object sender, EventArgs e)
        {

            if (txbUsuario.Text.ToString().Trim() == "")
            {
                txbUsuario.Text = "";
                erroEmail.Visible = true;
                erroSenha.Visible = false;
                return;
            }
            else if (txbSenha.Text.ToString().Trim() == "")
            {
                txbSenha.Text = "";
                erroEmail.Visible = false;
                erroSenha.Visible = true;
                return;
            }
            else
            {
                nomeBancoDeDados = txbUsuario.Text;

                con.AbrirConexao();
                sql = "INSERT INTO usuario (usuario, senha) VALUES(@usuario, @senha)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@usuario", txbUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txbSenha.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                txbUsuario.Text = "";
                txbSenha.Text = "";
                erroEmail.Visible = false;
                erroSenha.Visible = false;
                msgSucesso.Visible = true;
                bancoFinanceiro.conectar();
            }
            

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirLogin(object onj)
        {
            Application.Run(new Login());
        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
