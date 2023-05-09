namespace Bella_Bijoux
{
    partial class frmenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmenu));
            this.frmMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCarrinho = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.frmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmMenu
            // 
            this.frmMenu.AutoSize = true;
            this.frmMenu.BackColor = System.Drawing.Color.LightGreen;
            this.frmMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("frmMenu.BackgroundImage")));
            this.frmMenu.Controls.Add(this.button2);
            this.frmMenu.Controls.Add(this.button1);
            this.frmMenu.Controls.Add(this.btnCarrinho);
            this.frmMenu.Controls.Add(this.btnSair);
            this.frmMenu.Controls.Add(this.btnCadastro);
            this.frmMenu.Controls.Add(this.btnRelatorios);
            this.frmMenu.Controls.Add(this.btnCaixa);
            this.frmMenu.Controls.Add(this.label1);
            this.frmMenu.Location = new System.Drawing.Point(3, 1);
            this.frmMenu.Name = "frmMenu";
            this.frmMenu.Size = new System.Drawing.Size(1048, 533);
            this.frmMenu.TabIndex = 0;
            this.frmMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(330, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 82);
            this.button1.TabIndex = 7;
            this.button1.Text = "TESTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCarrinho
            // 
            this.btnCarrinho.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrinho.Location = new System.Drawing.Point(330, 257);
            this.btnCarrinho.Name = "btnCarrinho";
            this.btnCarrinho.Size = new System.Drawing.Size(208, 93);
            this.btnCarrinho.TabIndex = 6;
            this.btnCarrinho.Text = "CARRINHO";
            this.btnCarrinho.UseVisualStyleBackColor = true;
            this.btnCarrinho.Click += new System.EventHandler(this.btnCarrinho_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(950, 487);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(101, 257);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(210, 93);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "CADASTRO";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Location = new System.Drawing.Point(103, 409);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(208, 82);
            this.btnRelatorios.TabIndex = 2;
            this.btnRelatorios.Text = "RELATÓRIOS";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnCaixa
            // 
            this.btnCaixa.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.Location = new System.Drawing.Point(103, 109);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(208, 82);
            this.btnCaixa.TabIndex = 1;
            this.btnCaixa.Text = "CAIXA";
            this.btnCaixa.UseVisualStyleBackColor = true;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(398, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BELLA BIJOUX";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(345, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 82);
            this.button2.TabIndex = 8;
            this.button2.Text = "CUPOM";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 539);
            this.Controls.Add(this.frmMenu);
            this.Name = "frmenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.frmMenu.ResumeLayout(false);
            this.frmMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel frmMenu;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCarrinho;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

