namespace ControleFinanceiro
{
    partial class formatar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contagemPendencias = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.planilha = new System.Windows.Forms.DataGridView();
            this.planilhaPendente = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFiltroLimpar = new System.Windows.Forms.Button();
            this.txtFiltroDescrição = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msgErroData = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltroFinal = new System.Windows.Forms.MaskedTextBox();
            this.txtFiltroInicial = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnSaida = new System.Windows.Forms.Button();
            this.txtEntrIdentificador = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msgErroEntr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.msgErroNumero = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.txtLancamento = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEntrValor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.valorTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.valorEntrada = new System.Windows.Forms.Label();
            this.valorSaida = new System.Windows.Forms.Label();
            this.valorSaidaPend = new System.Windows.Forms.Label();
            this.valorEntradaPend = new System.Windows.Forms.Label();
            this.definirPlanilhaPendente = new System.Windows.Forms.RadioButton();
            this.definirPlanilhaMovimentacoes = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planilha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planilhaPendente)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.contagemPendencias);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 677);
            this.panel1.TabIndex = 0;
            // 
            // contagemPendencias
            // 
            this.contagemPendencias.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contagemPendencias.AutoSize = true;
            this.contagemPendencias.BackColor = System.Drawing.Color.Red;
            this.contagemPendencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contagemPendencias.ForeColor = System.Drawing.Color.White;
            this.contagemPendencias.Location = new System.Drawing.Point(68, 300);
            this.contagemPendencias.Name = "contagemPendencias";
            this.contagemPendencias.Size = new System.Drawing.Size(24, 25);
            this.contagemPendencias.TabIndex = 28;
            this.contagemPendencias.Text = "0";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.planilha, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.planilhaPendente, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(66, 318);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(919, 356);
            this.tableLayoutPanel2.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(389, 35);
            this.label14.TabIndex = 28;
            this.label14.Text = "Pendente";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planilha
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.planilha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.planilha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planilha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planilha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.planilha.BackgroundColor = System.Drawing.Color.White;
            this.planilha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.planilha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.planilha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.planilha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.planilha.DefaultCellStyle = dataGridViewCellStyle3;
            this.planilha.Location = new System.Drawing.Point(415, 37);
            this.planilha.Margin = new System.Windows.Forms.Padding(2);
            this.planilha.Name = "planilha";
            this.planilha.ReadOnly = true;
            this.planilha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.planilha.RowHeadersWidth = 51;
            this.planilha.RowTemplate.Height = 24;
            this.planilha.Size = new System.Drawing.Size(502, 317);
            this.planilha.TabIndex = 2;
            this.planilha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planilha_CellClick);
            // 
            // planilhaPendente
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.planilhaPendente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.planilhaPendente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planilhaPendente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planilhaPendente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.planilhaPendente.BackgroundColor = System.Drawing.Color.White;
            this.planilhaPendente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.planilhaPendente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10.2F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.planilhaPendente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.planilhaPendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.OrangeRed;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.planilhaPendente.DefaultCellStyle = dataGridViewCellStyle6;
            this.planilhaPendente.Location = new System.Drawing.Point(2, 37);
            this.planilhaPendente.Margin = new System.Windows.Forms.Padding(2);
            this.planilhaPendente.Name = "planilhaPendente";
            this.planilhaPendente.ReadOnly = true;
            this.planilhaPendente.RowHeadersWidth = 51;
            this.planilhaPendente.Size = new System.Drawing.Size(391, 317);
            this.planilhaPendente.TabIndex = 1;
            this.planilhaPendente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planilhaPendente_CellClick);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(416, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(500, 35);
            this.label6.TabIndex = 29;
            this.label6.Text = "Movimentações";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 677);
            this.panel3.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnFiltroLimpar);
            this.panel2.Controls.Add(this.txtFiltroDescrição);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.msgErroData);
            this.panel2.Controls.Add(this.btnFiltro);
            this.panel2.Controls.Add(this.txtFiltroFinal);
            this.panel2.Controls.Add(this.txtFiltroInicial);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(66, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(919, 73);
            this.panel2.TabIndex = 25;
            // 
            // btnFiltroLimpar
            // 
            this.btnFiltroLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltroLimpar.Location = new System.Drawing.Point(544, 24);
            this.btnFiltroLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltroLimpar.MaximumSize = new System.Drawing.Size(84, 24);
            this.btnFiltroLimpar.MinimumSize = new System.Drawing.Size(84, 24);
            this.btnFiltroLimpar.Name = "btnFiltroLimpar";
            this.btnFiltroLimpar.Size = new System.Drawing.Size(84, 24);
            this.btnFiltroLimpar.TabIndex = 42;
            this.btnFiltroLimpar.Text = "Limpar Filtro";
            this.btnFiltroLimpar.UseVisualStyleBackColor = true;
            this.btnFiltroLimpar.Click += new System.EventHandler(this.btnFiltroLimpar_Click);
            // 
            // txtFiltroDescrição
            // 
            this.txtFiltroDescrição.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroDescrição.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroDescrição.Location = new System.Drawing.Point(309, 23);
            this.txtFiltroDescrição.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroDescrição.Name = "txtFiltroDescrição";
            this.txtFiltroDescrição.Size = new System.Drawing.Size(138, 26);
            this.txtFiltroDescrição.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(308, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Descrição";
            // 
            // msgErroData
            // 
            this.msgErroData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgErroData.AutoSize = true;
            this.msgErroData.BackColor = System.Drawing.Color.Transparent;
            this.msgErroData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErroData.ForeColor = System.Drawing.Color.Red;
            this.msgErroData.Location = new System.Drawing.Point(13, 52);
            this.msgErroData.Name = "msgErroData";
            this.msgErroData.Size = new System.Drawing.Size(88, 13);
            this.msgErroData.TabIndex = 39;
            this.msgErroData.Text = "Data incorreta";
            this.msgErroData.Visible = false;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltro.Location = new System.Drawing.Point(456, 24);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltro.MaximumSize = new System.Drawing.Size(84, 24);
            this.btnFiltro.MinimumSize = new System.Drawing.Size(84, 24);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(84, 24);
            this.btnFiltro.TabIndex = 38;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltroFinal
            // 
            this.txtFiltroFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroFinal.Location = new System.Drawing.Point(160, 23);
            this.txtFiltroFinal.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroFinal.Mask = "00/00/0000";
            this.txtFiltroFinal.Name = "txtFiltroFinal";
            this.txtFiltroFinal.Size = new System.Drawing.Size(138, 26);
            this.txtFiltroFinal.TabIndex = 37;
            this.txtFiltroFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiltroFinal.ValidatingType = typeof(System.DateTime);
            // 
            // txtFiltroInicial
            // 
            this.txtFiltroInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroInicial.Location = new System.Drawing.Point(12, 23);
            this.txtFiltroInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltroInicial.Mask = "00/00/0000";
            this.txtFiltroInicial.Name = "txtFiltroInicial";
            this.txtFiltroInicial.Size = new System.Drawing.Size(138, 26);
            this.txtFiltroInicial.TabIndex = 36;
            this.txtFiltroInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFiltroInicial.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(157, 5);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 17);
            this.label10.TabIndex = 35;
            this.label10.Text = "Data Final";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(15, 5);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 34;
            this.label9.Text = "Data Inicial";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.definirPlanilhaMovimentacoes);
            this.panel5.Controls.Add(this.definirPlanilhaPendente);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.btnDeletar);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.btnSaida);
            this.panel5.Controls.Add(this.txtEntrIdentificador);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.msgErroEntr);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.msgErroNumero);
            this.panel5.Controls.Add(this.btnEntrada);
            this.panel5.Controls.Add(this.txtLancamento);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txtEntrValor);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(66, 139);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(919, 73);
            this.panel5.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(671, 3);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Ações";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.Orange;
            this.btnDeletar.Location = new System.Drawing.Point(868, 9);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(39, 39);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "X";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Location = new System.Drawing.Point(668, 0);
            this.panel9.MaximumSize = new System.Drawing.Size(1, 73);
            this.panel9.MinimumSize = new System.Drawing.Size(1, 73);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1, 73);
            this.panel9.TabIndex = 29;
            // 
            // btnSaida
            // 
            this.btnSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaida.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSaida.FlatAppearance.BorderSize = 0;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaida.ForeColor = System.Drawing.Color.Red;
            this.btnSaida.Location = new System.Drawing.Point(795, 11);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(39, 37);
            this.btnSaida.TabIndex = 16;
            this.btnSaida.Text = "$";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // txtEntrIdentificador
            // 
            this.txtEntrIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEntrIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrIdentificador.Location = new System.Drawing.Point(213, 21);
            this.txtEntrIdentificador.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntrIdentificador.Name = "txtEntrIdentificador";
            this.txtEntrIdentificador.Size = new System.Drawing.Size(196, 26);
            this.txtEntrIdentificador.TabIndex = 5;
            this.txtEntrIdentificador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEntrIdentificador_MouseClick);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(862, 49);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 25;
            this.label8.Text = "Excluir";
            // 
            // msgErroEntr
            // 
            this.msgErroEntr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgErroEntr.AutoSize = true;
            this.msgErroEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErroEntr.ForeColor = System.Drawing.Color.Red;
            this.msgErroEntr.Location = new System.Drawing.Point(15, 48);
            this.msgErroEntr.Name = "msgErroEntr";
            this.msgErroEntr.Size = new System.Drawing.Size(200, 13);
            this.msgErroEntr.TabIndex = 13;
            this.msgErroEntr.Text = "Todos os campos são obrigatórios";
            this.msgErroEntr.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(709, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Receita";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(412, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(782, 49);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Despesa";
            // 
            // msgErroNumero
            // 
            this.msgErroNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgErroNumero.AutoSize = true;
            this.msgErroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErroNumero.ForeColor = System.Drawing.Color.Red;
            this.msgErroNumero.Location = new System.Drawing.Point(13, 48);
            this.msgErroNumero.Name = "msgErroNumero";
            this.msgErroNumero.Size = new System.Drawing.Size(257, 13);
            this.msgErroNumero.TabIndex = 20;
            this.msgErroNumero.Text = "No campo Valor é permitido apenas número!";
            this.msgErroNumero.Visible = false;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.btnEntrada.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEntrada.FlatAppearance.BorderSize = 0;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.Color.Green;
            this.btnEntrada.Location = new System.Drawing.Point(718, 11);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(39, 37);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "$";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // txtLancamento
            // 
            this.txtLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLancamento.Location = new System.Drawing.Point(416, 20);
            this.txtLancamento.Margin = new System.Windows.Forms.Padding(2);
            this.txtLancamento.Mask = "00/00/0000";
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.Size = new System.Drawing.Size(138, 26);
            this.txtLancamento.TabIndex = 22;
            this.txtLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLancamento.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(210, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // txtEntrValor
            // 
            this.txtEntrValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEntrValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrValor.Location = new System.Drawing.Point(12, 21);
            this.txtEntrValor.Margin = new System.Windows.Forms.Padding(2);
            this.txtEntrValor.Name = "txtEntrValor";
            this.txtEntrValor.Size = new System.Drawing.Size(196, 26);
            this.txtEntrValor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(13, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9615384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9615384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9615384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9615384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077F));
            this.tableLayoutPanel1.Controls.Add(this.valorTotal, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label17, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label16, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label15, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.valorEntrada, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.valorSaida, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.valorSaidaPend, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.valorEntradaPend, 6, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(66, 41);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 82);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // valorTotal
            // 
            this.valorTotal.BackColor = System.Drawing.Color.White;
            this.valorTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotal.ForeColor = System.Drawing.Color.Black;
            this.valorTotal.Location = new System.Drawing.Point(3, 41);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(170, 41);
            this.valorTotal.TabIndex = 35;
            this.valorTotal.Text = "R$ 0,00";
            this.valorTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 41);
            this.label11.TabIndex = 29;
            this.label11.Text = "Saldo";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(739, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(177, 41);
            this.label17.TabIndex = 34;
            this.label17.Text = "Saída Pendente";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(555, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(170, 41);
            this.label16.TabIndex = 33;
            this.label16.Text = "Entrada Pendente";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(371, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 41);
            this.label15.TabIndex = 31;
            this.label15.Text = "Saída";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(187, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 41);
            this.label13.TabIndex = 32;
            this.label13.Text = "Entrada";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorEntrada
            // 
            this.valorEntrada.BackColor = System.Drawing.Color.White;
            this.valorEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valorEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorEntrada.ForeColor = System.Drawing.Color.Green;
            this.valorEntrada.Location = new System.Drawing.Point(187, 41);
            this.valorEntrada.Name = "valorEntrada";
            this.valorEntrada.Size = new System.Drawing.Size(170, 41);
            this.valorEntrada.TabIndex = 36;
            this.valorEntrada.Text = "R$ 0,00";
            this.valorEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorSaida
            // 
            this.valorSaida.BackColor = System.Drawing.Color.White;
            this.valorSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valorSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorSaida.ForeColor = System.Drawing.Color.Red;
            this.valorSaida.Location = new System.Drawing.Point(371, 41);
            this.valorSaida.Name = "valorSaida";
            this.valorSaida.Size = new System.Drawing.Size(170, 41);
            this.valorSaida.TabIndex = 37;
            this.valorSaida.Text = "R$ 0,00";
            this.valorSaida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorSaidaPend
            // 
            this.valorSaidaPend.BackColor = System.Drawing.Color.White;
            this.valorSaidaPend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valorSaidaPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorSaidaPend.ForeColor = System.Drawing.Color.Orange;
            this.valorSaidaPend.Location = new System.Drawing.Point(739, 41);
            this.valorSaidaPend.Name = "valorSaidaPend";
            this.valorSaidaPend.Size = new System.Drawing.Size(177, 41);
            this.valorSaidaPend.TabIndex = 39;
            this.valorSaidaPend.Text = "R$ 0,00";
            this.valorSaidaPend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valorEntradaPend
            // 
            this.valorEntradaPend.BackColor = System.Drawing.Color.White;
            this.valorEntradaPend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valorEntradaPend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorEntradaPend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.valorEntradaPend.Location = new System.Drawing.Point(555, 41);
            this.valorEntradaPend.Name = "valorEntradaPend";
            this.valorEntradaPend.Size = new System.Drawing.Size(170, 41);
            this.valorEntradaPend.TabIndex = 38;
            this.valorEntradaPend.Text = "R$ 0,00";
            this.valorEntradaPend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // definirPlanilhaPendente
            // 
            this.definirPlanilhaPendente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.definirPlanilhaPendente.AutoSize = true;
            this.definirPlanilhaPendente.Location = new System.Drawing.Point(565, 11);
            this.definirPlanilhaPendente.Name = "definirPlanilhaPendente";
            this.definirPlanilhaPendente.Size = new System.Drawing.Size(71, 17);
            this.definirPlanilhaPendente.TabIndex = 43;
            this.definirPlanilhaPendente.TabStop = true;
            this.definirPlanilhaPendente.Text = "Pendente";
            this.definirPlanilhaPendente.UseVisualStyleBackColor = true;
            // 
            // definirPlanilhaMovimentacoes
            // 
            this.definirPlanilhaMovimentacoes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.definirPlanilhaMovimentacoes.AutoSize = true;
            this.definirPlanilhaMovimentacoes.Location = new System.Drawing.Point(565, 34);
            this.definirPlanilhaMovimentacoes.Name = "definirPlanilhaMovimentacoes";
            this.definirPlanilhaMovimentacoes.Size = new System.Drawing.Size(100, 17);
            this.definirPlanilhaMovimentacoes.TabIndex = 44;
            this.definirPlanilhaMovimentacoes.TabStop = true;
            this.definirPlanilhaMovimentacoes.Text = "Movimentações";
            this.definirPlanilhaMovimentacoes.UseVisualStyleBackColor = true;
            // 
            // formatar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 677);
            this.Controls.Add(this.panel1);
            this.Name = "formatar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formatar";
            this.Load += new System.EventHandler(this.formatar_load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.planilha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planilhaPendente)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView planilha;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.TextBox txtEntrIdentificador;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label msgErroEntr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label msgErroNumero;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.MaskedTextBox txtLancamento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEntrValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFiltroLimpar;
        private System.Windows.Forms.TextBox txtFiltroDescrição;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label msgErroData;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.MaskedTextBox txtFiltroFinal;
        private System.Windows.Forms.MaskedTextBox txtFiltroInicial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView planilhaPendente;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label valorTotal;
        private System.Windows.Forms.Label valorEntrada;
        private System.Windows.Forms.Label valorSaida;
        private System.Windows.Forms.Label valorSaidaPend;
        private System.Windows.Forms.Label valorEntradaPend;
        private System.Windows.Forms.Label contagemPendencias;
        private System.Windows.Forms.RadioButton definirPlanilhaMovimentacoes;
        private System.Windows.Forms.RadioButton definirPlanilhaPendente;
    }
}