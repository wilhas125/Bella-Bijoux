namespace Projeto_vendas_Fatec.br.com.projeto.view
{
    partial class frmCupom
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
            this.txtNomeEstabelecimento = new System.Windows.Forms.TextBox();
            this.txtCnpjEstabelecimento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFormaPagamento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textCodCupom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgCupom = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxItensVendidos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgCupom)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeEstabelecimento
            // 
            this.txtNomeEstabelecimento.Location = new System.Drawing.Point(131, 74);
            this.txtNomeEstabelecimento.Name = "txtNomeEstabelecimento";
            this.txtNomeEstabelecimento.Size = new System.Drawing.Size(169, 20);
            this.txtNomeEstabelecimento.TabIndex = 0;
            // 
            // txtCnpjEstabelecimento
            // 
            this.txtCnpjEstabelecimento.Location = new System.Drawing.Point(131, 102);
            this.txtCnpjEstabelecimento.Name = "txtCnpjEstabelecimento";
            this.txtCnpjEstabelecimento.Size = new System.Drawing.Size(169, 20);
            this.txtCnpjEstabelecimento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cnpj Estabelecimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome Estabelecimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Itens Vendidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Total";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(73, 259);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(227, 20);
            this.txtValorTotal.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Forma Pagamento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Codigo do Cupom";
            // 
            // txtFormaPagamento
            // 
            this.txtFormaPagamento.Location = new System.Drawing.Point(131, 298);
            this.txtFormaPagamento.Name = "txtFormaPagamento";
            this.txtFormaPagamento.Size = new System.Drawing.Size(169, 20);
            this.txtFormaPagamento.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(245, 37);
            this.label7.TabIndex = 14;
            this.label7.Text = "BELLA BIJOUX";
            // 
            // textCodCupom
            // 
            this.textCodCupom.Location = new System.Drawing.Point(131, 333);
            this.textCodCupom.Name = "textCodCupom";
            this.textCodCupom.Size = new System.Drawing.Size(169, 20);
            this.textCodCupom.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "CUPOM NÂO FISCAL";
            // 
            // dgCupom
            // 
            this.dgCupom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCupom.Location = new System.Drawing.Point(12, 153);
            this.dgCupom.Name = "dgCupom";
            this.dgCupom.Size = new System.Drawing.Size(287, 100);
            this.dgCupom.TabIndex = 19;
            this.dgCupom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCupom_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 24);
            this.button1.TabIndex = 20;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // listBoxItensVendidos
            // 
            this.listBoxItensVendidos.Location = new System.Drawing.Point(131, 127);
            this.listBoxItensVendidos.Name = "listBoxItensVendidos";
            this.listBoxItensVendidos.Size = new System.Drawing.Size(164, 20);
            this.listBoxItensVendidos.TabIndex = 21;
            // 
            // frmCupom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.listBoxItensVendidos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgCupom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textCodCupom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtFormaPagamento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCnpjEstabelecimento);
            this.Controls.Add(this.txtNomeEstabelecimento);
            this.Name = "frmCupom";
            this.Text = "cupom";
            this.Load += new System.EventHandler(this.button1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgCupom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeEstabelecimento;
        private System.Windows.Forms.TextBox txtCnpjEstabelecimento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFormaPagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textCodCupom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgCupom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox listBoxItensVendidos;
    }
}