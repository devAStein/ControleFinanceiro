using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class Cadastro : Form
    {
        conexao con = new conexao();
        string sql;
        MySqlCommand cmd;

        Thread t1;

        public Cadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbEmail.Text.ToString().Trim() == "")
            {
                txbEmail.Text = "";
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
                con.AbrirConexao();
                sql = "INSERT INTO usuario (email, senha) VALUES(@email, @senha)";
                cmd = new MySqlCommand(sql, con.con);
                cmd.Parameters.AddWithValue("@email", txbEmail.Text);
                cmd.Parameters.AddWithValue("@senha", txbSenha.Text);
                cmd.ExecuteNonQuery();
                con.FecharConexao();
                txbEmail.Text = "";
                txbSenha.Text = "";
                erroEmail.Visible = false;
                erroSenha.Visible = false;
                msgSucesso.Visible = true;
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

    }
}
