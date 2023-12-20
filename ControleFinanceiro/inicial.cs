using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class inicial : Form
    {
        bancoFinanceiro acessBanco = new bancoFinanceiro();
        string sql;
        MySqlCommand cmd;

        public inicial()
        {
            InitializeComponent();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if(txtEntrData.Text.ToString().Trim() == "" || txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "")
            {
                txtEntrData.Text = "";
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                msgErroEntr.Visible = true;
            }
            else
            {
                acessBanco.abrirBancoFinanceiro();
                sql = "INSERT INTO dados (dataEntrada, idenEntrada, valorEntrada) VALUES(@dataEntrada, @idenEntrada, @valorEntrada)";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@dataEntrada", txtEntrData.Text);
                cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                cmd.Parameters.AddWithValue("@valorEntrada", txtEntrValor.Text);
                cmd.ExecuteNonQuery();
                acessBanco.fecharBancoFinanceiro();
                txtEntrData.Text = "";
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                msgErroEntr.Visible = false;
                msgSuceEntr.Visible = true;
            }

        }
    }
}
