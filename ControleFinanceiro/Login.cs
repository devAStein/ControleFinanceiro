using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace ControleFinanceiro
{
    public partial class Login : Form
    {
        Conexao con = new Conexao();

        Thread t1;
        Thread t2;

        public Login()
        {
            InitializeComponent();
        }

        public static string nomeBancoDeDados;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.AbrirConexao();
                MySqlCommand cmdVerificar;
                MySqlDataReader reader;
                cmdVerificar = new MySqlCommand("SELECT * FROM usuario WHERE usuario=@usuario AND senha=@senha", con.con);
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmdVerificar;
                cmdVerificar.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmdVerificar.Parameters.AddWithValue("@senha", txtSenha.Text);
                reader = cmdVerificar.ExecuteReader();
                if (reader.HasRows)
                {
                    nomeBancoDeDados = txtUsuario.Text;
                    this.Close();
                    t1 = new Thread(abrirInicial);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }
                else if (txtUsuario.Text.ToString().Trim() == "")
                {
                    txtUsuario.Text = "";
                    erroEmail.Visible = true;
                    erroSenha.Visible = false;
                    msgErro.Visible = false;
                    return;
                }
                else if (txtSenha.Text.ToString().Trim() == "")
                {
                    txtSenha.Text = "";
                    erroEmail.Visible = false;
                    erroSenha.Visible = true;
                    msgErro.Visible = false;
                    return;
                }       
                else 
                {
                    txtSenha.Text = "";
                    txtUsuario.Text = "";
                    erroEmail.Visible = false;
                    erroSenha.Visible = false;
                    msgErro.Visible = true;
                }
            }
            catch(Exception)
            {
                
            }           
        }

        private void abrirInicial(object onj)
        {
            Application.Run(new inicial());
        }

        private void abrirCadastro(object onj)
        {
            Application.Run(new Cadastro());
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(abrirCadastro);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }
    }
}
