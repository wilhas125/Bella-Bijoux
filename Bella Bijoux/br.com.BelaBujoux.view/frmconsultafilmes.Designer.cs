
namespace Sistema_locadora.br.com.locadora.view
{
    partial class frmconsultafilmes
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
            this.tabelaconsultafilmes = new System.Windows.Forms.DataGridView();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.txtcategoria = new System.Windows.Forms.ComboBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtdiretor = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaconsultafilmes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelaconsultafilmes
            // 
            this.tabelaconsultafilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaconsultafilmes.Location = new System.Drawing.Point(22, 183);
            this.tabelaconsultafilmes.Name = "tabelaconsultafilmes";
            this.tabelaconsultafilmes.Size = new System.Drawing.Size(856, 291);
            this.tabelaconsultafilmes.TabIndex = 10;
            this.tabelaconsultafilmes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelaconsultafilmes_CellClick);
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(6, 18);
            this.txtpesquisar.Multiline = true;
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(243, 26);
            this.txtpesquisar.TabIndex = 8;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged);
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
            this.txtcategoria.Location = new System.Drawing.Point(76, 38);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(240, 21);
            this.txtcategoria.TabIndex = 20;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(76, 119);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 19;
            // 
            // txtdiretor
            // 
            this.txtdiretor.Location = new System.Drawing.Point(76, 93);
            this.txtdiretor.Name = "txtdiretor";
            this.txtdiretor.Size = new System.Drawing.Size(241, 20);
            this.txtdiretor.TabIndex = 18;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(76, 64);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(241, 20);
            this.txtnome.TabIndex = 17;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(77, 12);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(86, 20);
            this.txtcodigo.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Diretor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtpesquisar);
            this.groupBox1.Location = new System.Drawing.Point(323, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 50);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar ";
            // 
            // btnalterar
            // 
            this.btnalterar.Location = new System.Drawing.Point(587, 144);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(75, 27);
            this.btnalterar.TabIndex = 24;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(668, 144);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(75, 27);
            this.btnexcluir.TabIndex = 23;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // frmconsultafilmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 486);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnexcluir);
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
            this.Controls.Add(this.tabelaconsultafilmes);
            this.Name = "frmconsultafilmes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Filmes";
            this.Load += new System.EventHandler(this.frmconsultafilmes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaconsultafilmes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelaconsultafilmes;
        private System.Windows.Forms.TextBox txtpesquisar;
        private System.Windows.Forms.ComboBox txtcategoria;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtdiretor;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
    }
}