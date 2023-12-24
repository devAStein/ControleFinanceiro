namespace ControleFinanceiro
{
    partial class Cadastro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.erroDuploUsuario = new System.Windows.Forms.Label();
            this.msgSucesso = new System.Windows.Forms.Label();
            this.erroSenha = new System.Windows.Forms.Label();
            this.erroEmail = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.erroDuploUsuario);
            this.panel1.Controls.Add(this.msgSucesso);
            this.panel1.Controls.Add(this.erroSenha);
            this.panel1.Controls.Add(this.erroEmail);
            this.panel1.Controls.Add(this.btLogin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbUsuario);
            this.panel1.Controls.Add(this.btCadastrar);
            this.panel1.Controls.Add(this.lblSenha);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.txbSenha);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 366);
            this.panel1.TabIndex = 6;
            // 
            // erroDuploUsuario
            // 
            this.erroDuploUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.erroDuploUsuario.AutoSize = true;
            this.erroDuploUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroDuploUsuario.ForeColor = System.Drawing.Color.Red;
            this.erroDuploUsuario.Location = new System.Drawing.Point(164, 143);
            this.erroDuploUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erroDuploUsuario.Name = "erroDuploUsuario";
            this.erroDuploUsuario.Size = new System.Drawing.Size(131, 13);
            this.erroDuploUsuario.TabIndex = 10;
            this.erroDuploUsuario.Text = "Usuário já cadastrado";
            this.erroDuploUsuario.Visible = false;
            // 
            // msgSucesso
            // 
            this.msgSucesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.msgSucesso.AutoSize = true;
            this.msgSucesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgSucesso.ForeColor = System.Drawing.Color.Green;
            this.msgSucesso.Location = new System.Drawing.Point(231, 82);
            this.msgSucesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgSucesso.Name = "msgSucesso";
            this.msgSucesso.Size = new System.Drawing.Size(193, 17);
            this.msgSucesso.TabIndex = 9;
            this.msgSucesso.Text = "Cadastrado com sucesso!";
            this.msgSucesso.Visible = false;
            // 
            // erroSenha
            // 
            this.erroSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.erroSenha.AutoSize = true;
            this.erroSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroSenha.ForeColor = System.Drawing.Color.Red;
            this.erroSenha.Location = new System.Drawing.Point(164, 197);
            this.erroSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erroSenha.Name = "erroSenha";
            this.erroSenha.Size = new System.Drawing.Size(170, 13);
            this.erroSenha.TabIndex = 8;
            this.erroSenha.Text = "O campo senha é obrigatório";
            this.erroSenha.Visible = false;
            // 
            // erroEmail
            // 
            this.erroEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.erroEmail.AutoSize = true;
            this.erroEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erroEmail.ForeColor = System.Drawing.Color.Red;
            this.erroEmail.Location = new System.Drawing.Point(164, 143);
            this.erroEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erroEmail.Name = "erroEmail";
            this.erroEmail.Size = new System.Drawing.Size(177, 13);
            this.erroEmail.TabIndex = 7;
            this.erroEmail.Text = "O campo usuario é obrigatório";
            this.erroEmail.Visible = false;
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btLogin.Location = new System.Drawing.Point(166, 223);
            this.btLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btLogin.MaximumSize = new System.Drawing.Size(134, 65);
            this.btLogin.MinimumSize = new System.Drawing.Size(134, 65);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(134, 65);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "FAZER LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(254, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "CADASTRO";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(166, 112);
            this.txbUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(307, 30);
            this.txbUsuario.TabIndex = 0;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btCadastrar.Location = new System.Drawing.Point(331, 223);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCadastrar.MaximumSize = new System.Drawing.Size(134, 65);
            this.btCadastrar.MinimumSize = new System.Drawing.Size(134, 65);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(134, 65);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "CADASTRAR";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(97, 171);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(70, 25);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(86, 115);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 25);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Usuario";
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSenha.Location = new System.Drawing.Point(166, 166);
            this.txbSenha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(307, 30);
            this.txbSenha.TabIndex = 3;
            this.txbSenha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txbSenha_MouseClick);
            this.txbSenha.TextChanged += new System.EventHandler(this.txbSenha_TextChanged);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Label erroSenha;
        private System.Windows.Forms.Label erroEmail;
        private System.Windows.Forms.Label msgSucesso;
        private System.Windows.Forms.Label erroDuploUsuario;
    }
}