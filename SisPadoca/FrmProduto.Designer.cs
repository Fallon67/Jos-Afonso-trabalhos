namespace SisPadoca
{
    partial class FrmProduto
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduto));
            BtnNovo = new Button();
            LblNCM = new Label();
            CbUnidade = new ComboBox();
            TbxNCM = new TextBox();
            PbxFoto = new PictureBox();
            TbxDescricao = new TextBox();
            LblDescricao = new Label();
            TbxCodBarras = new TextBox();
            LblCodBarras = new Label();
            LblUnidade = new Label();
            LblLote = new Label();
            CbLote = new ComboBox();
            BtnEditar = new Button();
            BtnExcluir = new Button();
            BtnLimpar = new Button();
            BtnFechar = new Button();
            ImgLista = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)PbxFoto).BeginInit();
            SuspendLayout();
            // 
            // BtnNovo
            // 
            BtnNovo.Location = new Point(12, 291);
            BtnNovo.Name = "BtnNovo";
            BtnNovo.Size = new Size(109, 74);
            BtnNovo.TabIndex = 0;
            BtnNovo.Text = "Novo";
            BtnNovo.UseVisualStyleBackColor = true;
            // 
            // LblNCM
            // 
            LblNCM.AutoSize = true;
            LblNCM.BackColor = Color.Yellow;
            LblNCM.Location = new Point(219, 18);
            LblNCM.Name = "LblNCM";
            LblNCM.Size = new Size(52, 25);
            LblNCM.TabIndex = 1;
            LblNCM.Text = "NCM";
            // 
            // CbUnidade
            // 
            CbUnidade.BackColor = Color.Yellow;
            CbUnidade.FormattingEnabled = true;
            CbUnidade.Items.AddRange(new object[] { "Unitário", "Kilo", "Dúzia" });
            CbUnidade.Location = new Point(529, 151);
            CbUnidade.Name = "CbUnidade";
            CbUnidade.Size = new Size(182, 33);
            CbUnidade.TabIndex = 2;
            // 
            // TbxNCM
            // 
            TbxNCM.BackColor = Color.Yellow;
            TbxNCM.Location = new Point(219, 58);
            TbxNCM.Name = "TbxNCM";
            TbxNCM.Size = new Size(118, 31);
            TbxNCM.TabIndex = 3;
            // 
            // PbxFoto
            // 
            PbxFoto.Image = (Image)resources.GetObject("PbxFoto.Image");
            PbxFoto.Location = new Point(12, 12);
            PbxFoto.Name = "PbxFoto";
            PbxFoto.Size = new Size(201, 237);
            PbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxFoto.TabIndex = 4;
            PbxFoto.TabStop = false;
            // 
            // TbxDescricao
            // 
            TbxDescricao.BackColor = Color.Yellow;
            TbxDescricao.Location = new Point(219, 149);
            TbxDescricao.Name = "TbxDescricao";
            TbxDescricao.Size = new Size(265, 31);
            TbxDescricao.TabIndex = 6;
            // 
            // LblDescricao
            // 
            LblDescricao.AutoSize = true;
            LblDescricao.BackColor = Color.Yellow;
            LblDescricao.Location = new Point(219, 110);
            LblDescricao.Name = "LblDescricao";
            LblDescricao.Size = new Size(88, 25);
            LblDescricao.TabIndex = 5;
            LblDescricao.Text = "Descrição";
            // 
            // TbxCodBarras
            // 
            TbxCodBarras.BackColor = Color.Yellow;
            TbxCodBarras.Location = new Point(219, 223);
            TbxCodBarras.Name = "TbxCodBarras";
            TbxCodBarras.Size = new Size(265, 31);
            TbxCodBarras.TabIndex = 8;
            // 
            // LblCodBarras
            // 
            LblCodBarras.AutoSize = true;
            LblCodBarras.BackColor = Color.Yellow;
            LblCodBarras.Location = new Point(219, 183);
            LblCodBarras.Name = "LblCodBarras";
            LblCodBarras.Size = new Size(151, 25);
            LblCodBarras.TabIndex = 7;
            LblCodBarras.Text = "Código De Barras";
            // 
            // LblUnidade
            // 
            LblUnidade.AutoSize = true;
            LblUnidade.BackColor = Color.Yellow;
            LblUnidade.Location = new Point(529, 109);
            LblUnidade.Name = "LblUnidade";
            LblUnidade.Size = new Size(168, 25);
            LblUnidade.TabIndex = 9;
            LblUnidade.Text = "Unidade de Medida";
            // 
            // LblLote
            // 
            LblLote.AutoSize = true;
            LblLote.BackColor = Color.Yellow;
            LblLote.Location = new Point(529, 210);
            LblLote.Name = "LblLote";
            LblLote.Size = new Size(46, 25);
            LblLote.TabIndex = 11;
            LblLote.Text = "Lote";
            // 
            // CbLote
            // 
            CbLote.BackColor = Color.Yellow;
            CbLote.FormattingEnabled = true;
            CbLote.Location = new Point(529, 252);
            CbLote.Name = "CbLote";
            CbLote.Size = new Size(182, 33);
            CbLote.TabIndex = 10;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(174, 291);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(109, 74);
            BtnEditar.TabIndex = 12;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            BtnExcluir.Location = new Point(353, 291);
            BtnExcluir.Name = "BtnExcluir";
            BtnExcluir.Size = new Size(109, 74);
            BtnExcluir.TabIndex = 13;
            BtnExcluir.Text = "Excluir";
            BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // BtnLimpar
            // 
            BtnLimpar.Location = new Point(529, 291);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(109, 74);
            BtnLimpar.TabIndex = 14;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = true;
            // 
            // BtnFechar
            // 
            BtnFechar.Location = new Point(696, 291);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(109, 74);
            BtnFechar.TabIndex = 15;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            // 
            // ImgLista
            // 
            ImgLista.ColorDepth = ColorDepth.Depth32Bit;
            ImgLista.ImageSize = new Size(16, 16);
            ImgLista.TransparentColor = Color.Transparent;
            // 
            // FrmProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 654);
            Controls.Add(BtnFechar);
            Controls.Add(BtnLimpar);
            Controls.Add(BtnExcluir);
            Controls.Add(BtnEditar);
            Controls.Add(LblLote);
            Controls.Add(CbLote);
            Controls.Add(LblUnidade);
            Controls.Add(TbxCodBarras);
            Controls.Add(LblCodBarras);
            Controls.Add(TbxDescricao);
            Controls.Add(LblDescricao);
            Controls.Add(PbxFoto);
            Controls.Add(TbxNCM);
            Controls.Add(CbUnidade);
            Controls.Add(LblNCM);
            Controls.Add(BtnNovo);
            Name = "FrmProduto";
            Text = "FrmProduto";
            ((System.ComponentModel.ISupportInitialize)PbxFoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNovo;
        private Label LblNCM;
        private ComboBox CbUnidade;
        private TextBox TbxNCM;
        private PictureBox PbxFoto;
        private TextBox TbxDescricao;
        private Label LblDescricao;
        private TextBox TbxCodBarras;
        private Label LblCodBarras;
        private Label LblUnidade;
        private Label LblLote;
        private ComboBox CbLote;
        private Button BtnEditar;
        private Button BtnExcluir;
        private Button BtnLimpar;
        private Button BtnFechar;
        private ImageList ImgLista;
    }
}