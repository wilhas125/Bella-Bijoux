
namespace Sistema_locadora.br.com.locadora.view
{
    partial class frmfilme
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtdiretor = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.ComboBox();
            this.frmconsultacategoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaDaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnsalvar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.categoriaDaoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.frmconsultacategoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frmconsultacategoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDaoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmconsultacategoriasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diretor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoria";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(71, 19);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(86, 20);
            this.txtcodigo.TabIndex = 5;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(70, 71);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(241, 20);
            this.txtnome.TabIndex = 7;
            // 
            // txtdiretor
            // 
            this.txtdiretor.Location = new System.Drawing.Point(70, 100);
            this.txtdiretor.Name = "txtdiretor";
            this.txtdiretor.Size = new System.Drawing.Size(241, 20);
            this.txtdiretor.TabIndex = 8;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(70, 126);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 9;
            // 
            // txtcategoria
            // 
            this.txtcategoria.FormattingEnabled = true;
            this.txtcategoria.Items.AddRange(new object[] {
            "Ação",
            "Aventura",
            "Cinema de arte",
            "Chanchada",
            "Comédia",
            "Comédia de ação",
            "Comédia de terror",
            "Comédia dramática",
            "Comédia romântica",
            "Dança",
            "Documentário",
            "Docuficção",
            "Drama",
            "Espionagem",
            "Faroeste",
            "Fantasia",
            "Fantasia científica",
            "Ficção científica",
            "Filmes com truques",
            "Filmes de guerra",
            "Mistério",
            "Musical",
            "Filme policial",
            "Romance",
            "Terror",
            "Thriller"});
            this.txtcategoria.Location = new System.Drawing.Point(70, 45);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(240, 21);
            this.txtcategoria.TabIndex = 10;
            // 
            // frmconsultacategoriasBindingSource
            // 
            this.frmconsultacategoriasBindingSource.DataSource = typeof(Sistema_locadora.br.com.locadora.view.frmconsultacategorias);
            // 
            // categoriaDaoBindingSource
            // 
            this.categoriaDaoBindingSource.DataSource = typeof(Sistema_locadora.br.com.locadora.dao.CategoriaDao);
            // 
            // btnsalvar
            // 
            this.btnsalvar.Location = new System.Drawing.Point(71, 180);
            this.btnsalvar.Name = "btnsalvar";
            this.btnsalvar.Size = new System.Drawing.Size(75, 23);
            this.btnsalvar.TabIndex = 11;
            this.btnsalvar.Text = "Salvar";
            this.btnsalvar.UseVisualStyleBackColor = true;
            this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(152, 180);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 12;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(236, 180);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(75, 23);
            this.btnsair.TabIndex = 13;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // categoriaDaoBindingSource1
            // 
            this.categoriaDaoBindingSource1.DataSource = typeof(Sistema_locadora.br.com.locadora.dao.CategoriaDao);
            // 
            // frmconsultacategoriasBindingSource1
            // 
            this.frmconsultacategoriasBindingSource1.DataSource = typeof(Sistema_locadora.br.com.locadora.view.frmconsultacategorias);
            // 
            // frmfilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 230);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnsalvar);
            this.Controls.Add(this.txtcategoria);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtdiretor);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmfilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Filmes";
            ((System.ComponentModel.ISupportInitialize)(this.frmconsultacategoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaDaoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmconsultacategoriasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtdiretor;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.ComboBox txtcategoria;
        private System.Windows.Forms.Button btnsalvar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.BindingSource categoriaDaoBindingSource;
        private System.Windows.Forms.BindingSource frmconsultacategoriasBindingSource;
        private System.Windows.Forms.BindingSource categoriaDaoBindingSource1;
        private System.Windows.Forms.BindingSource frmconsultacategoriasBindingSource1;
    }
}