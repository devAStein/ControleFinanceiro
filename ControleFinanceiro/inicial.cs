using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

        string id;
        DataTable dt = new DataTable();

        public inicial()
        {
            InitializeComponent();
            string nomeDoBanco = (Login.nomeBancoDeDados);
            nomeUsuario.Text = nomeDoBanco;
            
        }

        private void inicial_Load(object sender, EventArgs e)
        {
            listarPlanilhPend();
            listarPlanilhaAatual();
            valorTota();
        }

        private void formatarPlanilha()
        {
            //Planilha de extrato
            planilha.Columns[0].Visible = false;
            planilha.Columns[1].Visible = false;
            planilha.Columns[2].HeaderText = "Data";
            planilha.Columns[3].HeaderText = "Descrição";
            planilha.Columns[4].HeaderText = "Entrada";
            planilha.Columns[5].HeaderText = "Saída";
            planilha.Columns[4].DefaultCellStyle.Format = "c";
            planilha.Columns[4].DefaultCellStyle.ForeColor = Color.Green;
            planilha.Columns[5].DefaultCellStyle.Format = "c";
            planilha.Columns[5].DefaultCellStyle.ForeColor = Color.Red;
        }

        private void formatarPlanilhaPend()
        {
            //Planilha de pendencias            
            planilhaPendente.Columns[0].Visible = false;
            planilhaPendente.Columns[1].HeaderText = "Data Prevista";
            planilhaPendente.Columns[2].HeaderText = "Descrição";
            planilhaPendente.Columns[3].HeaderText = "Valor";
            planilhaPendente.Columns[3].DefaultCellStyle.Format = "c";
            planilhaPendente.Columns[3].DefaultCellStyle.ForeColor = Color.Orange;
            planilhaPendente.Sort(planilhaPendente.Columns[1], ListSortDirection.Descending);

        }

        private void listarPlanilha()
        {
            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT * FROM dados ORDER BY dataLancamento DESC";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            planilha.DataSource = dt;
            acessBanco.fecharBancoFinanceiro();
            formatarPlanilha();            
        }

        private void listarPlanilhPend()
        {
            var now = DateTime.UtcNow;
            var first = now.Date.AddDays(-(now.Date.Day - 1));
            var last = first.AddMonths(1).AddTicks(-1);
            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(first));
            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(last));

            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT * FROM pendencia where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "'";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            planilhaPendente.DataSource = dt;
            acessBanco.fecharBancoFinanceiro();
            formatarPlanilhaPend();

        }

        private void listarPlanilhaAatual()
        {
            var now = DateTime.UtcNow;
            var first = now.Date.AddDays(-(now.Date.Day - 1));
            var last = first.AddMonths(1).AddTicks(-1);
            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(first));
            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(last));
            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT * FROM dados where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "'";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            planilha.DataSource = dt;
            acessBanco.fecharBancoFinanceiro();
            formatarPlanilha();

        }

        private void valorTota()
        {
            total = 0;
            entrada = 0;
            saida = 0;
            
            foreach (DataGridViewRow linha in planilha.Rows)
            {
                entrada += Convert.ToDouble(linha.Cells[4].Value);
                saida += Convert.ToDouble(linha.Cells[5].Value);
                total = Convert.ToDouble(entrada - saida);
                valorTotal.Text = total.ToString("C");
                valorEntrada.Text = entrada.ToString("C");
                valorSaida.Text = saida.ToString("C");
            }
        }
     
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string agora = DateTime.Now.ToString();
            

            txtEntrValor.Text = txtEntrValor.Text.Replace(".", "");
            txtEntrValor.Text = txtEntrValor.Text.Replace(",", ".");

            if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "" || txtLancamento.Text.ToString().Trim() == "")
            {
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                txtLancamento.Text = "";
                msgErroEntr.Visible = true;
            }
            else
            {
                string dataLancamento = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtLancamento.Text));
                acessBanco.abrirBancoFinanceiro();
                sql = "INSERT INTO dados (dataEntrada, dataLancamento, idenEntrada, valorEntrada) VALUES(@dataEntrada, @dataLancamento, @idenEntrada, @valorEntrada)";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@dataEntrada", agora);
                cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
                cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                cmd.Parameters.AddWithValue("@valorEntrada", txtEntrValor.Text);
                cmd.ExecuteNonQuery();
                acessBanco.fecharBancoFinanceiro();
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                txtLancamento.Text = "";
                msgErroEntr.Visible = false;
                msgSuceEntr.Visible = true;
                msgErroNumero.Visible = false;
                listarPlanilha();
                valorTota();
            }

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string agora = DateTime.Now.ToString();
            

            txtEntrValor.Text = txtEntrValor.Text.Replace(".", "");
            txtEntrValor.Text = txtEntrValor.Text.Replace(",", ".");

            if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "" || txtLancamento.Text.ToString().Trim() == "")
            {
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                txtLancamento.Text = "";
                msgErroEntr.Visible = true;
            }
            else
            {
                string dataLancamento = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtLancamento.Text));
                acessBanco.abrirBancoFinanceiro();
                sql = "INSERT INTO dados (dataEntrada, dataLancamento, idenEntrada, valorSaida) VALUES(@dataEntrada, @dataLancamento, @idenEntrada, @valorSaida)";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@dataEntrada", agora);
                cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
                cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                cmd.Parameters.AddWithValue("@valorSaida", txtEntrValor.Text);
                cmd.ExecuteNonQuery();
                acessBanco.fecharBancoFinanceiro();
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                txtLancamento.Text = "";
                msgErroEntr.Visible = false;
                msgSuceEntr.Visible = true;
                msgErroNumero.Visible = false;
                listarPlanilha();
                valorTota();
            }
                       
        }

        private void txtEntrIdentificador_MouseClick(object sender, MouseEventArgs e)
        {
        
            try
            {
                if (txtEntrValor.Text == "")
                {

                }
                else
                {
                    txtEntrValor.Text = Double.Parse(txtEntrValor.Text).ToString("C");
                    txtEntrValor.Text = txtEntrValor.Text.Replace("R$", "");
                    msgErroNumero.Visible = false;
                }
            }
            catch (Exception ex)
            {
                msgErroNumero.Visible = true;
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                txtLancamento.Text = "";
            }

        }

        private void txtEntrValor_MouseClick(object sender, MouseEventArgs e)
        {
            msgSuceEntr.Visible = false;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            acessBanco.abrirBancoFinanceiro();
            sql = "DELETE FROM dados WHERE id=@id";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            acessBanco.fecharBancoFinanceiro();
            listarPlanilha();
            valorTota();
            txtEntrIdentificador.Text = "";
            txtEntrValor.Text = "";
            msgErroNumero.Visible = false;
            msgErroEntr.Visible = false;
            msgSuceEntr.Visible = false;
            msgErroNumero.Visible = false;
        }

        private void planilha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = planilha.CurrentRow.Cells[0].Value.ToString();
        }

        public void filtroPendente()
        {

            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtFiltroInicial.Text));
            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtFiltroFinal.Text));
            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT * FROM pendencia where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "'";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            planilhaPendente.DataSource = dt;
            acessBanco.fecharBancoFinanceiro();
            formatarPlanilhaPend();

        }

        public void filtroPlanilha()
        {
            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtFiltroInicial.Text));
            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtFiltroFinal.Text));
            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT * FROM dados where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "'";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            dt = new DataTable();
            da.Fill(dt);
            planilha.DataSource = dt;
            acessBanco.fecharBancoFinanceiro();
            formatarPlanilha();
        }

        public void filtroPlanidlha()
        {
            if (txtFiltroInicial.Text == "" || txtFiltroFinal.Text == "")
            {
                listarPlanilhaAatual();
            }
            else
            {
                filtroPendente();
                filtroPlanilha();
                valorTota();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEntrValorPend.Text = txtEntrValorPend.Text.Replace(".", "");
            txtEntrValorPend.Text = txtEntrValorPend.Text.Replace(",", ".");

            if (txtEntrIdentificadorPend.Text.ToString().Trim() == "" || txtEntrValorPend.Text.ToString().Trim() == "" || txtLancamentoPend.Text.ToString().Trim() == "")
            {
                txtEntrIdentificadorPend.Text = "";
                txtEntrValorPend.Text = "";
                txtLancamentoPend.Text = "";
                msgErroEntrPend.Visible = true;
            }
            else
            {
                string dataLancamento = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtLancamentoPend.Text));
                acessBanco.abrirBancoFinanceiro();
                sql = "INSERT INTO pendencia (dataLancamento, idenEntrada, valorEntrada) VALUES(@dataLancamento, @idenEntrada, @valorEntrada)";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
                cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificadorPend.Text);
                cmd.Parameters.AddWithValue("@valorEntrada", txtEntrValorPend.Text);
                cmd.ExecuteNonQuery();
                acessBanco.fecharBancoFinanceiro();
                txtEntrIdentificadorPend.Text = "";
                txtEntrValorPend.Text = "";
                txtLancamentoPend.Text = "";
                msgErroEntrPend.Visible = false;
                msgSuceEntr.Visible = true;
                msgErroNumeroPend.Visible = false;
                listarPlanilhPend();
            }
        }

        private void txtEntrIdentificadorPend_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEntrValorPend.Text == "")
                {

                }
                else
                {
                    txtEntrValorPend.Text = Double.Parse(txtEntrValorPend.Text).ToString("C");
                    txtEntrValorPend.Text = txtEntrValorPend.Text.Replace("R$", "");
                    msgErroNumeroPend.Visible = false;
                }
            }
            catch (Exception ex)
            {
                msgErroNumeroPend.Visible = true;
                txtEntrIdentificadorPend.Text = "";
                txtEntrValorPend.Text = "";
                txtLancamentoPend.Text = "";
            }
        }
    }
}
