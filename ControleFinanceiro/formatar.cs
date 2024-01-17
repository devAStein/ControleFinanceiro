using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class formatar : Form
    {
        bancoFinanceiro acessBanco = new bancoFinanceiro();
        string sql;
        MySqlCommand cmd;

        double total;
        double entrada;
        double saida;

        string idPlanilha;
        string idPlanilhaPend;
        DataTable dt = new DataTable();



        public formatar()
        {
            InitializeComponent();
        }

        private void formatar_load(object sender, EventArgs e)
        {
            listarPlanilhaAatualPendente();
            listarPlanilhaAatual();
            valorTota();
            valorTotaPendente();
            contagemPendencia();
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
            planilha.Sort(planilha.Columns[2], ListSortDirection.Descending);
        }

        private void formatarPlanilhaPend()
        {
            //Planilha de pendencias            
            planilhaPendente.Columns[0].Visible = false;
            planilhaPendente.Columns[1].HeaderText = "Data Prevista";
            planilhaPendente.Columns[2].HeaderText = "Descrição";
            planilhaPendente.Columns[3].HeaderText = "Entrada";
            planilhaPendente.Columns[4].HeaderText = "Saida";
            planilhaPendente.Columns[3].DefaultCellStyle.Format = "c";
            planilhaPendente.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            planilhaPendente.Columns[4].DefaultCellStyle.Format = "c";
            planilhaPendente.Columns[4].DefaultCellStyle.ForeColor = Color.Red;
            planilhaPendente.Sort(planilhaPendente.Columns[1], ListSortDirection.Ascending);
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
            string count = Convert.ToString(cmd.ExecuteScalar());
            contagemPendencias.Text = count;
            planilhaPendente.DataSource = dt;
            acessBanco.fecharBancoFinanceiro();
            formatarPlanilhaPend();

        }

        private void listarPlanilhaAatualPendente()
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

        private void contagemPendencia()
        {
            var now = DateTime.UtcNow;
            var first = now.Date.AddDays(-(now.Date.Day - 1));
            var last = first.AddMonths(1).AddTicks(-1);
            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(first));
            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(last));
            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT COUNT(*) FROM pendencia where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "'";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            string count = Convert.ToString(cmd.ExecuteScalar());
            contagemPendencias.Text = count;
            cmd.ExecuteNonQuery();
            acessBanco.fecharBancoFinanceiro();
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

        private void valorTotaPendente()
        {
            total = 0;
            entrada = 0;
            saida = 0;

            foreach (DataGridViewRow linha in planilhaPendente.Rows)
            {
                entrada += Convert.ToDouble(linha.Cells[3].Value);
                saida += Convert.ToDouble(linha.Cells[4].Value);
                valorEntradaPend.Text = entrada.ToString("C");
                valorSaidaPend.Text = saida.ToString("C");
            }
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            string agora = DateTime.Now.ToString();


            txtEntrValor.Text = txtEntrValor.Text.Replace(".", "");
            txtEntrValor.Text = txtEntrValor.Text.Replace(",", ".");

            if (definirPlanilhaPendente.Checked)
            {
                if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "0.00" || txtLancamento.Text.ToString() == "  /  /")
                {
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = true;
                }
                else if (txtFiltroInicial.Text != "  /  /" || txtFiltroFinal.Text != "  /  /")
                {
                    string dataLancamento = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtLancamento.Text));
                    acessBanco.abrirBancoFinanceiro();
                    sql = "INSERT INTO pendencia (dataLancamento, idenEntrada, valorEntrada) VALUES(@dataLancamento, @idenEntrada, @valorEntrada)";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
                    cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                    cmd.Parameters.AddWithValue("@valorEntrada", txtEntrValor.Text);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = false;
                    msgErroNumero.Visible = false;
                    filtroPendente();
                    valorTotaPendente();
                    filtrocontagemPendencia();
                }
                else
                {
                    string dataLancamento = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtLancamento.Text));
                    acessBanco.abrirBancoFinanceiro();
                    sql = "INSERT INTO pendencia (dataLancamento, idenEntrada, valorEntrada) VALUES(@dataLancamento, @idenEntrada, @valorEntrada)";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
                    cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                    cmd.Parameters.AddWithValue("@valorEntrada", txtEntrValor.Text);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = false;
                    msgErroNumero.Visible = false;
                    listarPlanilhPend();
                    valorTotaPendente();
                    contagemPendencia();
                }
            }
            else if (definirPlanilhaMovimentacoes.Checked)
            {
                if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "0.00" || txtLancamento.Text.ToString() == "  /  /")
                {
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = true;
                }
                else if (txtFiltroInicial.Text != "  /  /" || txtFiltroFinal.Text != "  /  /")
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
                    msgErroNumero.Visible = false;
                    filtroPlanilha();
                    valorTota();
                    filtrocontagemPendencia();
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
                    msgErroNumero.Visible = false;
                    listarPlanilhaAatual();
                    valorTota();
                    contagemPendencia();
                }
            }       
        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            string agora = DateTime.Now.ToString();

            txtEntrValor.Text = txtEntrValor.Text.Replace(".", "");
            txtEntrValor.Text = txtEntrValor.Text.Replace(",", ".");
            
            if (definirPlanilhaPendente.Checked)
            {
                if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "0.00" || txtLancamento.Text.ToString() == "  /  /")
                {
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = true;
                }
                else if (txtFiltroInicial.Text != "  /  /" || txtFiltroFinal.Text != "  /  /")
                {
                    string dataLancamento = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtLancamento.Text));
                    acessBanco.abrirBancoFinanceiro();
                    sql = "INSERT INTO pendencia (dataLancamento, idenEntrada, valorSaida) VALUES(@dataLancamento, @idenEntrada, @valorSaida)";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
                    cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                    cmd.Parameters.AddWithValue("@valorSaida", txtEntrValor.Text);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = false;
                    msgErroNumero.Visible = false;
                    filtroPendente();
                    valorTotaPendente();
                    filtrocontagemPendencia();
                }
                else
                {
                    string dataLancamento = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtLancamento.Text));
                    acessBanco.abrirBancoFinanceiro();
                    sql = "INSERT INTO pendencia (dataLancamento, idenEntrada, valorSaida) VALUES(@dataLancamento, @idenEntrada, @valorSaida)";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@dataLancamento", dataLancamento);
                    cmd.Parameters.AddWithValue("@idenEntrada", txtEntrIdentificador.Text);
                    cmd.Parameters.AddWithValue("@valorSaida", txtEntrValor.Text);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = false;
                    msgErroNumero.Visible = false;
                    listarPlanilhPend();
                    valorTotaPendente();
                    contagemPendencia();
                }
            }else if (definirPlanilhaMovimentacoes.Checked)
            {
                if (txtEntrIdentificador.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "" || txtEntrValor.Text.ToString().Trim() == "0.00" || txtLancamento.Text.ToString() == "  /  /")
                {
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    txtLancamento.Text = "";
                    msgErroEntr.Visible = true;
                }
                else if (txtFiltroInicial.Text != "  /  /" || txtFiltroFinal.Text != "  /  /")
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
                    msgErroNumero.Visible = false;
                    filtroPlanilha();
                    valorTota();
                    filtrocontagemPendencia();
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
                    msgErroNumero.Visible = false;
                    listarPlanilhaAatual();
                    valorTota();
                    contagemPendencia();
                }
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
            catch (Exception)
            {
                msgErroNumero.Visible = true;
                txtEntrIdentificador.Text = "";
                txtEntrValor.Text = "";
                txtLancamento.Text = "";
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (idPlanilhaPend != "")
            {
                if (txtFiltroInicial.Text != "  /  /" || txtFiltroFinal.Text != "  /  /")
                {
                    acessBanco.abrirBancoFinanceiro();
                    sql = "DELETE FROM pendencia WHERE id=@id";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@id", idPlanilhaPend);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    filtroPendente();
                    valorTotaPendente();
                    filtrocontagemPendencia();
                }
                else
                {
                    acessBanco.abrirBancoFinanceiro();
                    sql = "DELETE FROM pendencia WHERE id=@id";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@id", idPlanilhaPend);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    listarPlanilhaAatualPendente();
                    valorTotaPendente();
                    contagemPendencia();
                }
            }
            else if (idPlanilha != "")
            {
                if (txtFiltroInicial.Text != "  /  /" || txtFiltroFinal.Text != "  /  /")
                {
                    acessBanco.abrirBancoFinanceiro();
                    sql = "DELETE FROM dados WHERE id=@id";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@id", idPlanilha);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    filtroPlanilha();
                    valorTota();
                    filtrocontagemPendencia();
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    msgErroNumero.Visible = false;
                    msgErroEntr.Visible = false;
                    msgErroNumero.Visible = false;
                }
                else
                {
                    acessBanco.abrirBancoFinanceiro();
                    sql = "DELETE FROM dados WHERE id=@id";
                    cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                    cmd.Parameters.AddWithValue("@id", idPlanilha);
                    cmd.ExecuteNonQuery();
                    acessBanco.fecharBancoFinanceiro();
                    listarPlanilhaAatual();
                    valorTota();
                    contagemPendencia();
                    txtEntrIdentificador.Text = "";
                    txtEntrValor.Text = "";
                    msgErroNumero.Visible = false;
                    msgErroEntr.Visible = false;
                    msgErroNumero.Visible = false;
                }
            }
            

        }

        private void planilha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPlanilha = planilha.CurrentRow.Cells[0].Value.ToString();
            idPlanilhaPend = "";
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
            string filtroDescrição = txtFiltroDescrição.Text;

            if (filtroDescrição != "")
            {
                acessBanco.abrirBancoFinanceiro();
                sql = "SELECT * FROM dados where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "' And idenEntrada LIKE @nome";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@nome", txtFiltroDescrição.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                planilha.DataSource = dt;
                acessBanco.fecharBancoFinanceiro();
                formatarPlanilha();
            }
            else
            {
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

        }

        public void filtroPlanilhaDescricao()
        {
            var now = DateTime.UtcNow;
            var first = now.Date.AddDays(-(now.Date.Day - 1));
            var last = first.AddMonths(1).AddTicks(-1);
            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(first));
            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(last));
            string filtroDescrição = txtFiltroDescrição.Text;

            if (filtroDescrição != "")
            {
                acessBanco.abrirBancoFinanceiro();
                sql = "SELECT * FROM dados where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "' And idenEntrada LIKE @nome";
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd = new MySqlCommand(sql, acessBanco.acessBanco);
                cmd.Parameters.AddWithValue("@nome", txtFiltroDescrição.Text + "%");
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = cmd;
                dt = new DataTable();
                da.Fill(dt);
                planilha.DataSource = dt;
                acessBanco.fecharBancoFinanceiro();
                formatarPlanilha();
            }
            else
            {
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

        }

        private void filtrocontagemPendencia()
        {
            string Data1 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtFiltroInicial.Text));
            string Data2 = System.String.Format("{0:yyyy-MM-dd}", Convert.ToDateTime(txtFiltroFinal.Text));
            acessBanco.abrirBancoFinanceiro();
            sql = "SELECT COUNT(*) FROM pendencia where dataLancamento >= '" + Data1 + "' And dataLancamento <= '" + Data2 + "'";
            cmd = new MySqlCommand(sql, acessBanco.acessBanco);
            MySqlDataAdapter da = new MySqlDataAdapter();
            string count = Convert.ToString(cmd.ExecuteScalar());
            contagemPendencias.Text = count;
            cmd.ExecuteNonQuery();
            acessBanco.fecharBancoFinanceiro();
        }



        private void btnFiltro_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFiltroDescrição.Text != "" && txtFiltroInicial.Text == "  /  /" || txtFiltroFinal.Text == "  /  /")
                {
                    filtroPlanilhaDescricao();
                    listarPlanilhaAatualPendente();
                    valorTota();
                    valorTotaPendente();
                    contagemPendencia();
                }
                else if (txtFiltroInicial.Text == "  /  /" || txtFiltroFinal.Text == "  /  /")
                {
                    listarPlanilhaAatual();
                    listarPlanilhaAatualPendente();
                    valorTota();
                    valorTotaPendente();
                    contagemPendencia();
                }
                else
                {
                    filtroPendente();
                    filtroPlanilha();
                    filtrocontagemPendencia();
                    valorTota();
                    valorTotaPendente();
                }
            }
            catch
            {
                msgErroData.Visible = true;
            }

        }

        private void btnFiltroLimpar_Click(object sender, EventArgs e)
        {
            listarPlanilhaAatual();
            listarPlanilhaAatualPendente();
            valorTota();
            valorTotaPendente();
            contagemPendencia();
            txtFiltroInicial.Text = "";
            txtFiltroFinal.Text = "";
            txtFiltroDescrição.Text = "";
        }

                        
        private void planilhaPendente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPlanilhaPend = planilhaPendente.CurrentRow.Cells[0].Value.ToString();
            idPlanilha = "";

            try
            {
                double validarValor = Convert.ToDouble(planilhaPendente.CurrentRow.Cells[3].Value.ToString());
                if (validarValor != 0.00)
                {
                    txtEntrIdentificador.Text = planilhaPendente.CurrentRow.Cells[2].Value.ToString();
                    txtEntrValor.Text = planilhaPendente.CurrentRow.Cells[3].Value.ToString();
                    txtEntrValor.Text = Double.Parse(txtEntrValor.Text).ToString("C");
                    txtEntrValor.Text = txtEntrValor.Text.Replace("R$", "");
                }
                else
                {
                    txtEntrIdentificador.Text = planilhaPendente.CurrentRow.Cells[2].Value.ToString();
                    txtEntrValor.Text = planilhaPendente.CurrentRow.Cells[4].Value.ToString();
                    txtEntrValor.Text = Double.Parse(txtEntrValor.Text).ToString("C");
                    txtEntrValor.Text = txtEntrValor.Text.Replace("R$", "");
                }

            }
            catch
            {

            }
        }

    }
}
