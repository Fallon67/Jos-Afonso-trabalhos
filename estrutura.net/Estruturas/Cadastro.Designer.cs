namespace Estruturas
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            pibImagem = new PictureBox();
            btnFechar = new Button();
            lblContaJason = new Label();
            btnSub = new Button();
            listBoxkaneki = new ListBox();
            btnLimparlbk = new Button();
            ((System.ComponentModel.ISupportInitialize)pibImagem).BeginInit();
            SuspendLayout();
            // 
            // pibImagem
            // 
            pibImagem.Image = (Image)resources.GetObject("pibImagem.Image");
            pibImagem.Location = new Point(-14, -3);
            pibImagem.Margin = new Padding(4, 5, 4, 5);
            pibImagem.Name = "pibImagem";
            pibImagem.Size = new Size(593, 492);
            pibImagem.TabIndex = 0;
            pibImagem.TabStop = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Black;
            btnFechar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = Color.Red;
            btnFechar.Location = new Point(919, 628);
            btnFechar.Margin = new Padding(4, 5, 4, 5);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(211, 108);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Sair";
            btnFechar.UseVisualStyleBackColor = false;
            btnFechar.Click += btnFechar_Click;
            // 
            // lblContaJason
            // 
            lblContaJason.AutoSize = true;
            lblContaJason.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContaJason.ForeColor = Color.FromArgb(192, 0, 0);
            lblContaJason.Location = new Point(655, 46);
            lblContaJason.Name = "lblContaJason";
            lblContaJason.Size = new Size(434, 65);
            lblContaJason.TabIndex = 2;
            lblContaJason.Text = "Quanto é 1000 - 7?";
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.Black;
            btnSub.Font = new Font("Times New Roman", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSub.ForeColor = Color.Red;
            btnSub.Location = new Point(669, 134);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(408, 117);
            btnSub.TabIndex = 3;
            btnSub.Text = "Descobrir";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // listBoxkaneki
            // 
            listBoxkaneki.BackColor = Color.Black;
            listBoxkaneki.Font = new Font("SimSun", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxkaneki.ForeColor = Color.Red;
            listBoxkaneki.FormattingEnabled = true;
            listBoxkaneki.Location = new Point(669, 270);
            listBoxkaneki.Name = "listBoxkaneki";
            listBoxkaneki.Size = new Size(462, 346);
            listBoxkaneki.TabIndex = 4;
            listBoxkaneki.SelectedIndexChanged += listBoxkaneki_SelectedIndexChanged;
            // 
            // btnLimparlbk
            // 
            btnLimparlbk.BackColor = Color.Black;
            btnLimparlbk.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimparlbk.ForeColor = Color.Red;
            btnLimparlbk.Location = new Point(688, 628);
            btnLimparlbk.Name = "btnLimparlbk";
            btnLimparlbk.Size = new Size(201, 108);
            btnLimparlbk.TabIndex = 5;
            btnLimparlbk.Text = "Limpar";
            btnLimparlbk.TextAlign = ContentAlignment.MiddleRight;
            btnLimparlbk.UseVisualStyleBackColor = false;
            btnLimparlbk.Click += btnLimparlbk_Click;
            // 
            // frmCadastro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnLimparlbk);
            Controls.Add(listBoxkaneki);
            Controls.Add(btnSub);
            Controls.Add(lblContaJason);
            Controls.Add(btnFechar);
            Controls.Add(pibImagem);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmCadastro";
            Text = "CadastroDoMal";
            ((System.ComponentModel.ISupportInitialize)pibImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pibImagem;
        private Button btnFechar;
        private Label lblContaJason;
        private Button btnSub;
        private ListBox listBoxkaneki;
        private Button btnLimparlbk;
    }
}