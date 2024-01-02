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
    public partial class orcamento : Form
    {

        bancoFinanceiro acessBanco = new bancoFinanceiro();
        string sql;
        MySqlCommand cmd;

        public orcamento()
        {
            InitializeComponent();
            string nomeDoBanco = (Login.nomeBancoDeDados);
            nomeUsuario.Text = nomeDoBanco;
        }

        private void orcamento_Load(object sender, EventArgs e)
        {

        }
    }
}
