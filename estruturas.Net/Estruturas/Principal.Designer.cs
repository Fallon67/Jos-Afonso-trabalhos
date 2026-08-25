namespace Estruturas
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pnlContainer = new Panel();
            pibImagem = new PictureBox();
            btnSair = new Button();
            pnlLogin = new Panel();
            btnLimpar = new Button();
            btnTestar = new Button();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lsbMostra = new ListBox();
            lblBotões = new Label();
            pnlRepeticao = new Panel();
            btnCmd = new Button();
            btnCreepypasta = new Button();
            btnBobEsp = new Button();
            btnCalculadora = new Button();
            btnJurosComp = new Button();
            btnMontante = new Button();
            btnJurosSimples = new Button();
            lblRegistro = new Label();
            btnLimparlsb1 = new Button();
            pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pibImagem).BeginInit();
            pnlLogin.SuspendLayout();
            pnlRepeticao.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContainer
            // 
            pnlContainer.Anchor = AnchorStyles.None;
            pnlContainer.BackColor = Color.Black;
            pnlContainer.Controls.Add(btnLimparlsb1);
            pnlContainer.Controls.Add(pibImagem);
            pnlContainer.Controls.Add(btnSair);
            pnlContainer.Controls.Add(pnlLogin);
            pnlContainer.Controls.Add(lsbMostra);
            pnlContainer.Controls.Add(lblBotões);
            pnlContainer.Controls.Add(pnlRepeticao);
            pnlContainer.Controls.Add(lblRegistro);
            pnlContainer.Location = new Point(44, 45);
            pnlContainer.Margin = new Padding(4, 5, 4, 5);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(1253, 830);
            pnlContainer.TabIndex = 0;
            // 
            // pibImagem
            // 
            pibImagem.Image = (Image)resources.GetObject("pibImagem.Image");
            pibImagem.Location = new Point(547, 705);
            pibImagem.Margin = new Padding(4, 5, 4, 5);
            pibImagem.Name = "pibImagem";
            pibImagem.Size = new Size(561, 247);
            pibImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pibImagem.TabIndex = 11;
            pibImagem.TabStop = false;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.Black;
            btnSair.ForeColor = Color.Red;
            btnSair.Location = new Point(987, 36);
            btnSair.Margin = new Padding(4, 5, 4, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(147, 63);
            btnSair.TabIndex = 11;
            btnSair.Text = "Sair do sistema";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // pnlLogin
            // 
            pnlLogin.BorderStyle = BorderStyle.Fixed3D;
            pnlLogin.Controls.Add(btnLimpar);
            pnlLogin.Controls.Add(btnTestar);
            pnlLogin.Controls.Add(txtSenha);
            pnlLogin.Controls.Add(lblSenha);
            pnlLogin.Controls.Add(txtUsuario);
            pnlLogin.Controls.Add(lblUsuario);
            pnlLogin.Location = new Point(103, 110);
            pnlLogin.Margin = new Padding(4, 5, 4, 5);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(384, 229);
            pnlLogin.TabIndex = 10;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Black;
            btnLimpar.ForeColor = Color.Red;
            btnLimpar.Location = new Point(227, 148);
            btnLimpar.Margin = new Padding(4, 5, 4, 5);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(130, 38);
            btnLimpar.TabIndex = 4;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnTestar
            // 
            btnTestar.BackColor = Color.Black;
            btnTestar.ForeColor = Color.Red;
            btnTestar.Location = new Point(227, 57);
            btnTestar.Margin = new Padding(4, 5, 4, 5);
            btnTestar.Name = "btnTestar";
            btnTestar.Size = new Size(130, 38);
            btnTestar.TabIndex = 1;
            btnTestar.Text = "Entrar";
            btnTestar.UseVisualStyleBackColor = false;
            btnTestar.Click += btnTestar_Click;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.Black;
            txtSenha.ForeColor = Color.Red;
            txtSenha.Location = new Point(29, 148);
            txtSenha.Margin = new Padding(4, 5, 4, 5);
            txtSenha.MaxLength = 20;
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(161, 31);
            txtSenha.TabIndex = 2;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.ForeColor = Color.Red;
            lblSenha.Location = new Point(29, 117);
            lblSenha.Margin = new Padding(4, 0, 4, 0);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(60, 25);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Black;
            txtUsuario.ForeColor = Color.Red;
            txtUsuario.Location = new Point(29, 57);
            txtUsuario.Margin = new Padding(4, 5, 4, 5);
            txtUsuario.MaxLength = 50;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(161, 31);
            txtUsuario.TabIndex = 1;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.ForeColor = Color.Red;
            lblUsuario.Location = new Point(29, 25);
            lblUsuario.Margin = new Padding(4, 0, 4, 0);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(72, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            // 
            // lsbMostra
            // 
            lsbMostra.BackColor = Color.Black;
            lsbMostra.ForeColor = Color.FromArgb(192, 0, 0);
            lsbMostra.FormattingEnabled = true;
            lsbMostra.Location = new Point(518, 108);
            lsbMostra.Margin = new Padding(4, 5, 4, 5);
            lsbMostra.Name = "lsbMostra";
            lsbMostra.Size = new Size(616, 754);
            lsbMostra.TabIndex = 9;
            // 
            // lblBotões
            // 
            lblBotões.AutoSize = true;
            lblBotões.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBotões.ForeColor = Color.Red;
            lblBotões.Location = new Point(103, 370);
            lblBotões.Margin = new Padding(4, 0, 4, 0);
            lblBotões.Name = "lblBotões";
            lblBotões.Size = new Size(261, 32);
            lblBotões.TabIndex = 8;
            lblBotões.Text = resources.GetString("lblBotões.Text");
            // 
            // pnlRepeticao
            // 
            pnlRepeticao.BorderStyle = BorderStyle.Fixed3D;
            pnlRepeticao.Controls.Add(btnCmd);
            pnlRepeticao.Controls.Add(btnCreepypasta);
            pnlRepeticao.Controls.Add(btnBobEsp);
            pnlRepeticao.Controls.Add(btnCalculadora);
            pnlRepeticao.Controls.Add(btnJurosComp);
            pnlRepeticao.Controls.Add(btnMontante);
            pnlRepeticao.Controls.Add(btnJurosSimples);
            pnlRepeticao.Location = new Point(103, 425);
            pnlRepeticao.Margin = new Padding(4, 5, 4, 5);
            pnlRepeticao.Name = "pnlRepeticao";
            pnlRepeticao.Size = new Size(384, 400);
            pnlRepeticao.TabIndex = 7;
            // 
            // btnCmd
            // 
            btnCmd.BackColor = Color.Black;
            btnCmd.ForeColor = Color.Red;
            btnCmd.Location = new Point(209, 217);
            btnCmd.Name = "btnCmd";
            btnCmd.Size = new Size(131, 67);
            btnCmd.TabIndex = 12;
            btnCmd.Text = "CMD";
            btnCmd.UseVisualStyleBackColor = false;
            btnCmd.Click += btnCmd_Click;
            // 
            // btnCreepypasta
            // 
            btnCreepypasta.BackColor = Color.Black;
            btnCreepypasta.ForeColor = Color.Red;
            btnCreepypasta.Location = new Point(209, 113);
            btnCreepypasta.Name = "btnCreepypasta";
            btnCreepypasta.Size = new Size(130, 67);
            btnCreepypasta.TabIndex = 12;
            btnCreepypasta.Text = "Creepypasta";
            btnCreepypasta.UseVisualStyleBackColor = false;
            btnCreepypasta.Click += btnCreepypasta_Click;
            // 
            // btnBobEsp
            // 
            btnBobEsp.BackColor = Color.Black;
            btnBobEsp.ForeColor = Color.Red;
            btnBobEsp.Location = new Point(47, 322);
            btnBobEsp.Margin = new Padding(4, 5, 4, 5);
            btnBobEsp.Name = "btnBobEsp";
            btnBobEsp.Size = new Size(293, 67);
            btnBobEsp.TabIndex = 11;
            btnBobEsp.Text = "Assistir R̷͍̬̙̻͒͗̓̓̎͐͒̈̆̇͂͠e̶̛̲͙͙̯͙̟̼̥̰͕̘̼̳̹̭͛͒̄̀̃̌̎̕̕̕͝d̵̨͕͔̎̓̾̿͊̕M̸̨̛̺̰̯͙̣̙͐̀̆̃̈́̂̀̏́͒͘͝i̶̹̩̰̱͔̦̜͋͆͊̿̉s̸̨͇͉̟̝̒̅̊̃̇̑͑͌̋̀̽͒͠t̸̢͍̫͈̄͗̈̊͂̅̓̄̉";
            btnBobEsp.UseVisualStyleBackColor = false;
            btnBobEsp.Click += btnBobEsp_Click;
            // 
            // btnCalculadora
            // 
            btnCalculadora.BackColor = Color.Black;
            btnCalculadora.ForeColor = Color.Red;
            btnCalculadora.Location = new Point(46, 217);
            btnCalculadora.Margin = new Padding(4, 5, 4, 5);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(130, 67);
            btnCalculadora.TabIndex = 9;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = false;
            btnCalculadora.Click += btnCalculadora_Click;
            // 
            // btnJurosComp
            // 
            btnJurosComp.BackColor = Color.Black;
            btnJurosComp.ForeColor = Color.Red;
            btnJurosComp.Location = new Point(47, 113);
            btnJurosComp.Margin = new Padding(4, 5, 4, 5);
            btnJurosComp.Name = "btnJurosComp";
            btnJurosComp.Size = new Size(130, 67);
            btnJurosComp.TabIndex = 7;
            btnJurosComp.Text = "Juros composto";
            btnJurosComp.UseVisualStyleBackColor = false;
            btnJurosComp.Click += btnJurosComp_Click;
            // 
            // btnMontante
            // 
            btnMontante.BackColor = Color.Black;
            btnMontante.ForeColor = Color.Red;
            btnMontante.Location = new Point(209, 17);
            btnMontante.Margin = new Padding(4, 5, 4, 5);
            btnMontante.Name = "btnMontante";
            btnMontante.Size = new Size(130, 67);
            btnMontante.TabIndex = 6;
            btnMontante.Text = "Montante";
            btnMontante.UseVisualStyleBackColor = false;
            btnMontante.Click += btnMontante_Click;
            // 
            // btnJurosSimples
            // 
            btnJurosSimples.BackColor = Color.Black;
            btnJurosSimples.ForeColor = Color.Red;
            btnJurosSimples.Location = new Point(46, 17);
            btnJurosSimples.Margin = new Padding(4, 5, 4, 5);
            btnJurosSimples.Name = "btnJurosSimples";
            btnJurosSimples.Size = new Size(130, 67);
            btnJurosSimples.TabIndex = 5;
            btnJurosSimples.Text = "Juros simples";
            btnJurosSimples.UseVisualStyleBackColor = false;
            btnJurosSimples.Click += btnJurosSimples_Click;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRegistro.ForeColor = Color.Red;
            lblRegistro.Location = new Point(103, 67);
            lblRegistro.Margin = new Padding(4, 0, 4, 0);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(280, 32);
            lblRegistro.TabIndex = 6;
            lblRegistro.Text = resources.GetString("lblRegistro.Text");
            // 
            // btnLimparlsb1
            // 
            btnLimparlsb1.BackColor = Color.Black;
            btnLimparlsb1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimparlsb1.ForeColor = Color.Red;
            btnLimparlsb1.Location = new Point(518, 36);
            btnLimparlsb1.Name = "btnLimparlsb1";
            btnLimparlsb1.Size = new Size(158, 63);
            btnLimparlsb1.TabIndex = 12;
            btnLimparlsb1.Text = "Limpar Painel";
            btnLimparlsb1.UseVisualStyleBackColor = false;
            btnLimparlsb1.Click += btnLimparlsb1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1270, 875);
            Controls.Add(pnlContainer);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falácio.Exe";
            WindowState = FormWindowState.Maximized;
            pnlContainer.ResumeLayout(false);
            pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pibImagem).EndInit();
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            pnlRepeticao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlContainer;
        private ListBox lsbMostra;
        private Label lblBotões;
        private Panel pnlRepeticao;
        private Button btnCalculadora;
        private Button btnJurosComp;
        private Button btnMontante;
        private Button btnJurosSimples;
        private Label lblRegistro;
        private Panel pnlLogin;
        private Button btnLimpar;
        private Button btnTestar;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtUsuario;
        private Label lblUsuario;
        private Button btnSair;
        private PictureBox pibImagem;
        private Button btnBobEsp;
        private Button btnCreepypasta;
        private Button btnCmd;
        private Button btnLimparlsb1;
    }
}
