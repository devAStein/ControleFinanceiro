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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ControleFinanceiro
{
    public partial class inicial : Form
    {
        bancoFinanceiro acessBanco = new bancoFinanceiro();
        string sql;
        MySqlCommand cmd;

        double total;
        double entrada;
        double saida;

        public inicial()
        {
            InitializeComponent();
        }

        private void inicial_Load(object sender, EventArgs e)
        {
            listarPlanilha();
            valorTota();
        }

        public static string nomeBancoDeDados;
        string sinanceiro = (Login.nomeBancoDeDados);

        private void formatarPlanilha()
        {
            planilha.Columns[0].Visible = false;
            planilha.Columns[1].HeaderText = "Data";
            planilha.Columns[2].HeaderText = "Descrição";
            planilha.Columns[3].HeaderText = "Entrada";
            planilha.Columns[4].HeaderText = "Saída";
            this.planilha.Columns[3].DefaultCellStyle.Format = "c";
            this.planilha.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            this.planilha.Columns[4].DefaultCellStyle.Format = "c";
            this.planilha.Columns[4].DefaultCellStyle.ForeColor = Color.Red;
        }

        private void valorTota()
        {
            total = 0;
            entrada = 0;
            saida = 0;
            
            foreach (DataGridViewRow linha in planilha.Rows)
            {
                entrada += Convert.ToDouble(linha.Cells[3].Value);
                saida += Convert.ToDouble(linha.Cells[4].Value);
                total = Convert.ToDouble(entrada - saida);
                valorTotal.Text = total.ToString("C");
                valorEntrada.Text = entrada.ToString("C");
                valorSaida.Text = saida.ToString("C");
            }
        }

        private void listarPlanilha()
        {
            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT * FROM dados ORDER BY DATAENTRADA DESC";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            planilha.DataSource = dt;
            acessBanco.fecharBancoFinanceiro();

            formatarPlanilha();
        }        

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string agora = DateTime.Now.ToString();

            txtEntrValor.Text = txtEntrValor.Text.Replace(".", "");
            txtEntrValor.Text = txtEntrValor.Text.Replace(",", ".");

            if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "")
            {
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                msgErroEntr.Visible = true;
            }
            else
            {
                acessBanco.abrirBancoFinanceiro();
                sql = "INSERT INTO dados (dataEntrada, idenEntrada, valorEntrada) VALUES(@dataEntrada, @idenEntrada, @valorEntrada)";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@dataEntrada", agora);
                cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                cmd.Parameters.AddWithValue("@valorEntrada", txtEntrValor.Text);
                cmd.ExecuteNonQuery();
                acessBanco.fecharBancoFinanceiro();
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                msgErroEntr.Visible = false;
                msgSuceEntr.Visible = true;
                listarPlanilha();
                valorTota();
            }

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string agora = DateTime.Now.ToString();

            txtEntrValor.Text = txtEntrValor.Text.Replace(".", "");
            txtEntrValor.Text = txtEntrValor.Text.Replace(",", ".");

            if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "")
            {
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                msgErroEntr.Visible = true;
            }
            else
            {
                acessBanco.abrirBancoFinanceiro();
                sql = "INSERT INTO dados (dataEntrada, idenEntrada, valorSaida) VALUES(@dataEntrada, @idenEntrada, @valorSaida)";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@dataEntrada", agora);
                cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                cmd.Parameters.AddWithValue("@valorSaida", txtEntrValor.Text);
                cmd.ExecuteNonQuery();
                acessBanco.fecharBancoFinanceiro();
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                msgErroEntr.Visible = false;
                msgSuceEntr.Visible = true;
                listarPlanilha();
                valorTota();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtEntrValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntrIdentificador_TextChanged(object sender, EventArgs e)
        {
            
            

        }

        private void txtEntrIdentificador_MouseClick(object sender, MouseEventArgs e)
        {

            if (txtEntrValor.Text == "")
            {

            }
            else
            {
                txtEntrValor.Text = Double.Parse(txtEntrValor.Text).ToString("C");
                txtEntrValor.Text = txtEntrValor.Text.Replace("R$", "");
            }
            
        }
    }
}
