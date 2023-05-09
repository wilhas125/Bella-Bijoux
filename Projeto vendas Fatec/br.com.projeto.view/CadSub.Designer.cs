namespace Projeto_vendas_Fatec.br.com.projeto.view
{
    partial class CadSub
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
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnCadFornecedores = new System.Windows.Forms.Button();
            this.btnCadClientes = new System.Windows.Forms.Button();
            this.frmMenu = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.frmMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEstoque
            // 
            this.btnEstoque.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Location = new System.Drawing.Point(764, 102);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(208, 82);
            this.btnEstoque.TabIndex = 4;
            this.btnEstoque.Text = "Produtos";
            this.btnEstoque.UseVisualStyleBackColor = true;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(534, 102);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(204, 82);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Funcionarios";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnCadFornecedores
            // 
            this.btnCadFornecedores.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFornecedores.Location = new System.Drawing.Point(300, 102);
            this.btnCadFornecedores.Name = "btnCadFornecedores";
            this.btnCadFornecedores.Size = new System.Drawing.Size(208, 82);
            this.btnCadFornecedores.TabIndex = 2;
            this.btnCadFornecedores.Text = "Fornecedores";
            this.btnCadFornecedores.UseVisualStyleBackColor = true;
            this.btnCadFornecedores.Click += new System.EventHandler(this.btnCadFornecedores_Click);
            // 
            // btnCadClientes
            // 
            this.btnCadClientes.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadClientes.Location = new System.Drawing.Point(65, 102);
            this.btnCadClientes.Name = "btnCadClientes";
            this.btnCadClientes.Size = new System.Drawing.Size(208, 82);
            this.btnCadClientes.TabIndex = 1;
            this.btnCadClientes.Text = "Clientes";
            this.btnCadClientes.UseVisualStyleBackColor = true;
            this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
            // 
            // frmMenu
            // 
            this.frmMenu.AutoSize = true;
            this.frmMenu.Controls.Add(this.btnSair);
            this.frmMenu.Controls.Add(this.btnEstoque);
            this.frmMenu.Controls.Add(this.btnCadastro);
            this.frmMenu.Controls.Add(this.btnCadFornecedores);
            this.frmMenu.Controls.Add(this.btnCadClientes);
            this.frmMenu.Controls.Add(this.label1);
            this.frmMenu.Location = new System.Drawing.Point(17, -18);
            this.frmMenu.Name = "frmMenu";
            this.frmMenu.Size = new System.Drawing.Size(1048, 533);
            this.frmMenu.TabIndex = 1;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(922, 467);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(103, 43);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTROS";
            // 
            // CadSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 496);
            this.Controls.Add(this.frmMenu);
            this.Name = "CadSub";
            this.Text = "CadSub";
            this.frmMenu.ResumeLayout(false);
            this.frmMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnCadFornecedores;
        private System.Windows.Forms.Button btnCadClientes;
        private System.Windows.Forms.Panel frmMenu;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
    }
}