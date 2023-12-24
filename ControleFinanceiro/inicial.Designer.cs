namespace ControleFinanceiro
{
    partial class inicial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtFiltroFinal = new System.Windows.Forms.TextBox();
            this.nomeUsuario = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.txtFiltroInicial = new System.Windows.Forms.TextBox();
            this.planilha = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtEntrIdentificador = new System.Windows.Forms.TextBox();
            this.btnSaida = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.txtEntrValor = new System.Windows.Forms.TextBox();
            this.msgSuceEntr = new System.Windows.Forms.Label();
            this.msgErroEntr = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.valorSaida = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.valorEntrada = new System.Windows.Forms.TextBox();
            this.Entradas = new System.Windows.Forms.Label();
            this.valorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.msgErroNumero = new System.Windows.Forms.Label();
            this.txtLancamento = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planilha)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 779);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txtFiltroFinal);
            this.panel7.Controls.Add(this.nomeUsuario);
            this.panel7.Controls.Add(this.btnFiltro);
            this.panel7.Controls.Add(this.txtFiltroInicial);
            this.panel7.Controls.Add(this.planilha);
            this.panel7.Location = new System.Drawing.Point(0, 260);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1065, 519);
            this.panel7.TabIndex = 4;
            // 
            // txtFiltroFinal
            // 
            this.txtFiltroFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroFinal.Location = new System.Drawing.Point(243, 33);
            this.txtFiltroFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroFinal.Name = "txtFiltroFinal";
            this.txtFiltroFinal.Size = new System.Drawing.Size(183, 26);
            this.txtFiltroFinal.TabIndex = 20;
            // 
            // nomeUsuario
            // 
            this.nomeUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeUsuario.ForeColor = System.Drawing.Color.Green;
            this.nomeUsuario.Location = new System.Drawing.Point(45, 473);
            this.nomeUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nomeUsuario.Name = "nomeUsuario";
            this.nomeUsuario.Size = new System.Drawing.Size(467, 31);
            this.nomeUsuario.TabIndex = 6;
            this.nomeUsuario.Text = "Nome do Usuario";
            // 
            // btnFiltro
            // 
            this.btnFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFiltro.Location = new System.Drawing.Point(435, 32);
            this.btnFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltro.MaximumSize = new System.Drawing.Size(119, 30);
            this.btnFiltro.MinimumSize = new System.Drawing.Size(119, 30);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(119, 30);
            this.btnFiltro.TabIndex = 19;
            this.btnFiltro.Text = "Filtro";
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // txtFiltroInicial
            // 
            this.txtFiltroInicial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltroInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroInicial.Location = new System.Drawing.Point(53, 33);
            this.txtFiltroInicial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltroInicial.Name = "txtFiltroInicial";
            this.txtFiltroInicial.Size = new System.Drawing.Size(183, 26);
            this.txtFiltroInicial.TabIndex = 18;
            this.txtFiltroInicial.TextChanged += new System.EventHandler(this.txtFiltroInicial_TextChanged);
            // 
            // planilha
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.planilha.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.planilha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.planilha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.planilha.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.planilha.BackgroundColor = System.Drawing.Color.White;
            this.planilha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.planilha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.planilha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.planilha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.planilha.DefaultCellStyle = dataGridViewCellStyle6;
            this.planilha.Location = new System.Drawing.Point(49, 66);
            this.planilha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.planilha.Name = "planilha";
            this.planilha.ReadOnly = true;
            this.planilha.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.planilha.RowHeadersWidth = 51;
            this.planilha.RowTemplate.Height = 24;
            this.planilha.Size = new System.Drawing.Size(949, 395);
            this.planilha.TabIndex = 0;
            this.planilha.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.planilha_CellClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 91);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1067, 170);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txtLancamento);
            this.panel5.Controls.Add(this.msgErroNumero);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.btnDeletar);
            this.panel5.Controls.Add(this.txtEntrIdentificador);
            this.panel5.Controls.Add(this.btnSaida);
            this.panel5.Controls.Add(this.btnEntrada);
            this.panel5.Controls.Add(this.txtEntrValor);
            this.panel5.Controls.Add(this.msgSuceEntr);
            this.panel5.Controls.Add(this.msgErroEntr);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1067, 170);
            this.panel5.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(401, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Data do Lançamento";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.ForeColor = System.Drawing.Color.Black;
            this.btnDeletar.Location = new System.Drawing.Point(280, 127);
            this.btnDeletar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(126, 27);
            this.btnDeletar.TabIndex = 17;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtEntrIdentificador
            // 
            this.txtEntrIdentificador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEntrIdentificador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrIdentificador.Location = new System.Drawing.Point(213, 66);
            this.txtEntrIdentificador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEntrIdentificador.Name = "txtEntrIdentificador";
            this.txtEntrIdentificador.Size = new System.Drawing.Size(183, 26);
            this.txtEntrIdentificador.TabIndex = 5;
            this.txtEntrIdentificador.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEntrIdentificador_MouseClick);
            // 
            // btnSaida
            // 
            this.btnSaida.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaida.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSaida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSaida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaida.ForeColor = System.Drawing.Color.Black;
            this.btnSaida.Location = new System.Drawing.Point(148, 127);
            this.btnSaida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaida.Name = "btnSaida";
            this.btnSaida.Size = new System.Drawing.Size(126, 27);
            this.btnSaida.TabIndex = 16;
            this.btnSaida.Text = "Adicionar saída";
            this.btnSaida.UseVisualStyleBackColor = true;
            this.btnSaida.Click += new System.EventHandler(this.btnSaida_Click);
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEntrada.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEntrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.ForeColor = System.Drawing.Color.Black;
            this.btnEntrada.Location = new System.Drawing.Point(16, 127);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(126, 27);
            this.btnEntrada.TabIndex = 4;
            this.btnEntrada.Text = "Adicionar";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // txtEntrValor
            // 
            this.txtEntrValor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEntrValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrValor.Location = new System.Drawing.Point(16, 66);
            this.txtEntrValor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEntrValor.Name = "txtEntrValor";
            this.txtEntrValor.Size = new System.Drawing.Size(183, 26);
            this.txtEntrValor.TabIndex = 2;
            this.txtEntrValor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtEntrValor_MouseClick);
            // 
            // msgSuceEntr
            // 
            this.msgSuceEntr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgSuceEntr.AutoSize = true;
            this.msgSuceEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgSuceEntr.ForeColor = System.Drawing.Color.Green;
            this.msgSuceEntr.Location = new System.Drawing.Point(13, 94);
            this.msgSuceEntr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgSuceEntr.Name = "msgSuceEntr";
            this.msgSuceEntr.Size = new System.Drawing.Size(73, 17);
            this.msgSuceEntr.TabIndex = 15;
            this.msgSuceEntr.Text = "Sucesso!";
            this.msgSuceEntr.Visible = false;
            // 
            // msgErroEntr
            // 
            this.msgErroEntr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgErroEntr.AutoSize = true;
            this.msgErroEntr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErroEntr.ForeColor = System.Drawing.Color.Red;
            this.msgErroEntr.Location = new System.Drawing.Point(8, 94);
            this.msgErroEntr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgErroEntr.Name = "msgErroEntr";
            this.msgErroEntr.Size = new System.Drawing.Size(258, 17);
            this.msgErroEntr.TabIndex = 13;
            this.msgErroEntr.Text = "Todos os campos são obrigatórios";
            this.msgErroEntr.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Movimentações";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 91);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.valorSaida);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.valorEntrada);
            this.panel3.Controls.Add(this.Entradas);
            this.panel3.Controls.Add(this.valorTotal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1067, 91);
            this.panel3.TabIndex = 3;
            // 
            // valorSaida
            // 
            this.valorSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.valorSaida.Enabled = false;
            this.valorSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorSaida.ForeColor = System.Drawing.Color.Red;
            this.valorSaida.Location = new System.Drawing.Point(781, 25);
            this.valorSaida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valorSaida.Name = "valorSaida";
            this.valorSaida.Size = new System.Drawing.Size(184, 36);
            this.valorSaida.TabIndex = 5;
            this.valorSaida.Text = "R$ 0,00";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(697, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Saída";
            // 
            // valorEntrada
            // 
            this.valorEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.valorEntrada.Enabled = false;
            this.valorEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorEntrada.ForeColor = System.Drawing.Color.Green;
            this.valorEntrada.Location = new System.Drawing.Point(499, 25);
            this.valorEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valorEntrada.Name = "valorEntrada";
            this.valorEntrada.Size = new System.Drawing.Size(184, 36);
            this.valorEntrada.TabIndex = 3;
            this.valorEntrada.Text = "R$ 0,00";
            // 
            // Entradas
            // 
            this.Entradas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Entradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entradas.Location = new System.Drawing.Point(388, 27);
            this.Entradas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Entradas.Name = "Entradas";
            this.Entradas.Size = new System.Drawing.Size(108, 31);
            this.Entradas.TabIndex = 2;
            this.Entradas.Text = "Entrada";
            // 
            // valorTotal
            // 
            this.valorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.valorTotal.Enabled = false;
            this.valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorTotal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.valorTotal.Location = new System.Drawing.Point(191, 25);
            this.valorTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(184, 36);
            this.valorTotal.TabIndex = 1;
            this.valorTotal.Text = "R$ 0,00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saldo";
            // 
            // msgErroNumero
            // 
            this.msgErroNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.msgErroNumero.AutoSize = true;
            this.msgErroNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgErroNumero.ForeColor = System.Drawing.Color.Red;
            this.msgErroNumero.Location = new System.Drawing.Point(18, 94);
            this.msgErroNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.msgErroNumero.Name = "msgErroNumero";
            this.msgErroNumero.Size = new System.Drawing.Size(330, 17);
            this.msgErroNumero.TabIndex = 20;
            this.msgErroNumero.Text = "No campo Valor é permitido apenas número!";
            this.msgErroNumero.Visible = false;
            // 
            // txtLancamento
            // 
            this.txtLancamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLancamento.Location = new System.Drawing.Point(405, 65);
            this.txtLancamento.Mask = "00/00/0000";
            this.txtLancamento.Name = "txtLancamento";
            this.txtLancamento.Size = new System.Drawing.Size(110, 26);
            this.txtLancamento.TabIndex = 22;
            this.txtLancamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLancamento.ValidatingType = typeof(System.DateTime);
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 779);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ",";
            this.Load += new System.EventHandler(this.inicial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planilha)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox valorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.TextBox txtEntrIdentificador;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label msgErroEntr;
        private System.Windows.Forms.Label msgSuceEntr;
        private System.Windows.Forms.DataGridView planilha;
        private System.Windows.Forms.Button btnSaida;
        private System.Windows.Forms.TextBox txtEntrValor;
        private System.Windows.Forms.TextBox valorEntrada;
        private System.Windows.Forms.Label Entradas;
        private System.Windows.Forms.TextBox valorSaida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label nomeUsuario;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.TextBox txtFiltroInicial;
        private System.Windows.Forms.TextBox txtFiltroFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label msgErroNumero;
        private System.Windows.Forms.MaskedTextBox txtLancamento;
    }
}