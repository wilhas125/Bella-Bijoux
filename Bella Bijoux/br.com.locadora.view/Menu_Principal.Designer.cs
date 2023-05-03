
namespace Sistema_locadora.br.com.locadora.view
{
    partial class Menu_Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarFilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarFilmesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1358, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.cadastrarFilmesToolStripMenuItem,
            this.cadastrarCategoriasToolStripMenuItem});
            this.cadastroToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(84, 22);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            this.cadastrarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastrarUsuárioToolStripMenuItem.Text = "Cadastrar Usuário";
            this.cadastrarUsuárioToolStripMenuItem.Visible = false;
            // 
            // cadastrarFilmesToolStripMenuItem
            // 
            this.cadastrarFilmesToolStripMenuItem.Name = "cadastrarFilmesToolStripMenuItem";
            this.cadastrarFilmesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastrarFilmesToolStripMenuItem.Text = "Cadastrar Filmes";
            this.cadastrarFilmesToolStripMenuItem.Click += new System.EventHandler(this.cadastrarFilmesToolStripMenuItem_Click);
            // 
            // cadastrarCategoriasToolStripMenuItem
            // 
            this.cadastrarCategoriasToolStripMenuItem.Name = "cadastrarCategoriasToolStripMenuItem";
            this.cadastrarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.cadastrarCategoriasToolStripMenuItem.Text = "Cadastrar Categorias";
            this.cadastrarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.cadastrarCategoriasToolStripMenuItem_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarUsuárioToolStripMenuItem,
            this.consultarFilmesToolStripMenuItem,
            this.consultarCategoriasToolStripMenuItem});
            this.consultaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            // 
            // consultarUsuárioToolStripMenuItem
            // 
            this.consultarUsuárioToolStripMenuItem.Name = "consultarUsuárioToolStripMenuItem";
            this.consultarUsuárioToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.consultarUsuárioToolStripMenuItem.Text = "Consultar Usuário";
            this.consultarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.consultarUsuárioToolStripMenuItem_Click);
            // 
            // consultarFilmesToolStripMenuItem
            // 
            this.consultarFilmesToolStripMenuItem.Name = "consultarFilmesToolStripMenuItem";
            this.consultarFilmesToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.consultarFilmesToolStripMenuItem.Text = "Consultar Filmes";
            this.consultarFilmesToolStripMenuItem.Click += new System.EventHandler(this.consultarFilmesToolStripMenuItem_Click);
            // 
            // consultarCategoriasToolStripMenuItem
            // 
            this.consultarCategoriasToolStripMenuItem.Name = "consultarCategoriasToolStripMenuItem";
            this.consultarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.consultarCategoriasToolStripMenuItem.Text = "Consultar Categorias";
            this.consultarCategoriasToolStripMenuItem.Click += new System.EventHandler(this.consultarCategoriasToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_locadora.Properties.Resources.Captura_de_t;
            this.pictureBox1.Location = new System.Drawing.Point(0, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1368, 817);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 749);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu_Principal";
            this.Text = "Sistema de Locadora";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarFilmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarFilmesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCategoriasToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}