namespace Bella_Bijoux
{
    partial class Carrinho
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
            this.btnSair = new System.Windows.Forms.Button();
            this.texBoxData = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.lbValor = new System.Windows.Forms.Label();
            this.lbCompra = new System.Windows.Forms.Label();
            this.llbEstoque = new System.Windows.Forms.Label();
            this.ldQtd = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxValorAtual = new System.Windows.Forms.TextBox();
            this.textBoxCompra = new System.Windows.Forms.TextBox();
            this.Estoque = new System.Windows.Forms.TextBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.textBoxDescri = new System.Windows.Forms.TextBox();
            this.texBoxCod = new System.Windows.Forms.TextBox();
            this.textBoxTotalAPagar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(947, 445);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // texBoxData
            // 
            this.texBoxData.Location = new System.Drawing.Point(34, 90);
            this.texBoxData.Multiline = true;
            this.texBoxData.Name = "texBoxData";
            this.texBoxData.Size = new System.Drawing.Size(137, 20);
            this.texBoxData.TabIndex = 8;
            this.texBoxData.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(427, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "CARRINHO";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTotalPagar);
            this.panel1.Controls.Add(this.lbValor);
            this.panel1.Controls.Add(this.lbCompra);
            this.panel1.Controls.Add(this.llbEstoque);
            this.panel1.Controls.Add(this.ldQtd);
            this.panel1.Controls.Add(this.lbDescricao);
            this.panel1.Controls.Add(this.lbCodigo);
            this.panel1.Controls.Add(this.lbData);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.textBoxValorAtual);
            this.panel1.Controls.Add(this.textBoxCompra);
            this.panel1.Controls.Add(this.Estoque);
            this.panel1.Controls.Add(this.textBoxQuantidade);
            this.panel1.Controls.Add(this.textBoxDescri);
            this.panel1.Controls.Add(this.texBoxCod);
            this.panel1.Controls.Add(this.textBoxTotalAPagar);
            this.panel1.Controls.Add(this.texBoxData);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(11, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 483);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Location = new System.Drawing.Point(130, 122);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(92, 13);
            this.lbTotalPagar.TabIndex = 26;
            this.lbTotalPagar.Text = "TOTAL A PAGAR";
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Location = new System.Drawing.Point(932, 71);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(43, 13);
            this.lbValor.TabIndex = 25;
            this.lbValor.Text = "VALOR";
            // 
            // lbCompra
            // 
            this.lbCompra.AutoSize = true;
            this.lbCompra.Location = new System.Drawing.Point(759, 69);
            this.lbCompra.Name = "lbCompra";
            this.lbCompra.Size = new System.Drawing.Size(92, 13);
            this.lbCompra.TabIndex = 24;
            this.lbCompra.Text = "VALOR COMPRA";
            // 
            // llbEstoque
            // 
            this.llbEstoque.AutoSize = true;
            this.llbEstoque.Location = new System.Drawing.Point(629, 74);
            this.llbEstoque.Name = "llbEstoque";
            this.llbEstoque.Size = new System.Drawing.Size(59, 13);
            this.llbEstoque.TabIndex = 23;
            this.llbEstoque.Text = "ESTOQUE";
            // 
            // ldQtd
            // 
            this.ldQtd.AutoSize = true;
            this.ldQtd.Location = new System.Drawing.Point(500, 74);
            this.ldQtd.Name = "ldQtd";
            this.ldQtd.Size = new System.Drawing.Size(78, 13);
            this.ldQtd.TabIndex = 22;
            this.ldQtd.Text = "QUANTIDADE";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Location = new System.Drawing.Point(348, 71);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(69, 13);
            this.lbDescricao.TabIndex = 21;
            this.lbDescricao.Text = "DESCRIÇÂO";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(220, 71);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(49, 13);
            this.lbCodigo.TabIndex = 20;
            this.lbCodigo.Text = "CODIGO";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(81, 64);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(36, 13);
            this.lbData.TabIndex = 19;
            this.lbData.Text = "DATA";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 186);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1011, 253);
            this.dataGridView1.TabIndex = 18;
            // 
            // textBoxValorAtual
            // 
            this.textBoxValorAtual.Location = new System.Drawing.Point(882, 90);
            this.textBoxValorAtual.Multiline = true;
            this.textBoxValorAtual.Name = "textBoxValorAtual";
            this.textBoxValorAtual.Size = new System.Drawing.Size(137, 20);
            this.textBoxValorAtual.TabIndex = 17;
            // 
            // textBoxCompra
            // 
            this.textBoxCompra.Location = new System.Drawing.Point(739, 90);
            this.textBoxCompra.Multiline = true;
            this.textBoxCompra.Name = "textBoxCompra";
            this.textBoxCompra.Size = new System.Drawing.Size(137, 20);
            this.textBoxCompra.TabIndex = 16;
            // 
            // Estoque
            // 
            this.Estoque.Location = new System.Drawing.Point(596, 90);
            this.Estoque.Multiline = true;
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(137, 20);
            this.Estoque.TabIndex = 15;
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Location = new System.Drawing.Point(463, 90);
            this.textBoxQuantidade.Multiline = true;
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.Size = new System.Drawing.Size(137, 20);
            this.textBoxQuantidade.TabIndex = 14;
            // 
            // textBoxDescri
            // 
            this.textBoxDescri.Location = new System.Drawing.Point(320, 90);
            this.textBoxDescri.Multiline = true;
            this.textBoxDescri.Name = "textBoxDescri";
            this.textBoxDescri.Size = new System.Drawing.Size(137, 20);
            this.textBoxDescri.TabIndex = 13;
            // 
            // texBoxCod
            // 
            this.texBoxCod.Location = new System.Drawing.Point(177, 90);
            this.texBoxCod.Multiline = true;
            this.texBoxCod.Name = "texBoxCod";
            this.texBoxCod.Size = new System.Drawing.Size(137, 20);
            this.texBoxCod.TabIndex = 12;
            // 
            // textBoxTotalAPagar
            // 
            this.textBoxTotalAPagar.Location = new System.Drawing.Point(114, 134);
            this.textBoxTotalAPagar.Multiline = true;
            this.textBoxTotalAPagar.Name = "textBoxTotalAPagar";
            this.textBoxTotalAPagar.Size = new System.Drawing.Size(137, 20);
            this.textBoxTotalAPagar.TabIndex = 11;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Carrinho";
            this.Text = "Carrinho";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox texBoxData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxValorAtual;
        private System.Windows.Forms.TextBox textBoxCompra;
        private System.Windows.Forms.TextBox Estoque;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.TextBox textBoxDescri;
        private System.Windows.Forms.TextBox texBoxCod;
        private System.Windows.Forms.TextBox textBoxTotalAPagar;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.Label lbValor;
        private System.Windows.Forms.Label lbCompra;
        private System.Windows.Forms.Label llbEstoque;
        private System.Windows.Forms.Label ldQtd;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbData;
    }
}