
namespace Projeto_vendas_Fatec.br.com.pvf.view
{
    partial class Frmclientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.combPesquisa = new System.Windows.Forms.ComboBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.Pesquisar = new System.Windows.Forms.Label();
            this.btncusultar = new System.Windows.Forms.Button();
            this.dgclientes = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.masktxtcelular = new System.Windows.Forms.MaskedTextBox();
            this.txtcomplemento = new System.Windows.Forms.TextBox();
            this.lbComplem = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.lbNumero = new System.Windows.Forms.Label();
            this.masktxtcep = new System.Windows.Forms.MaskedTextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.masktxttelefone = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.masktxtcpf = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.masktxtrg = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de clientes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 77);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.combPesquisa);
            this.tabPage2.Controls.Add(this.txtPesquisa);
            this.tabPage2.Controls.Add(this.Pesquisar);
            this.tabPage2.Controls.Add(this.btncusultar);
            this.tabPage2.Controls.Add(this.dgclientes);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1004, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultas de Clentes";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // combPesquisa
            // 
            this.combPesquisa.FormattingEnabled = true;
            this.combPesquisa.Items.AddRange(new object[] {
            "CPF",
            "E_MAIL",
            "RG"});
            this.combPesquisa.Location = new System.Drawing.Point(424, 47);
            this.combPesquisa.Name = "combPesquisa";
            this.combPesquisa.Size = new System.Drawing.Size(187, 32);
            this.combPesquisa.TabIndex = 4;
            this.combPesquisa.SelectedIndexChanged += new System.EventHandler(this.combPesquisa_SelectedIndexChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(191, 50);
            this.txtPesquisa.Multiline = true;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(177, 29);
            this.txtPesquisa.TabIndex = 3;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // Pesquisar
            // 
            this.Pesquisar.AutoSize = true;
            this.Pesquisar.Location = new System.Drawing.Point(32, 50);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(93, 24);
            this.Pesquisar.TabIndex = 2;
            this.Pesquisar.Text = "Pesquisar";
            this.Pesquisar.Click += new System.EventHandler(this.label13_Click);
            // 
            // btncusultar
            // 
            this.btncusultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncusultar.Location = new System.Drawing.Point(717, 39);
            this.btncusultar.Name = "btncusultar";
            this.btncusultar.Size = new System.Drawing.Size(125, 46);
            this.btncusultar.TabIndex = 1;
            this.btncusultar.Text = "Consultar";
            this.btncusultar.UseVisualStyleBackColor = true;
            this.btncusultar.Click += new System.EventHandler(this.btncusultar_Click);
            // 
            // dgclientes
            // 
            this.dgclientes.AllowUserToAddRows = false;
            this.dgclientes.AllowUserToDeleteRows = false;
            this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgclientes.Location = new System.Drawing.Point(11, 91);
            this.dgclientes.Name = "dgclientes";
            this.dgclientes.ReadOnly = true;
            this.dgclientes.Size = new System.Drawing.Size(993, 284);
            this.dgclientes.TabIndex = 0;
            this.dgclientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgclientes_CellClick);
            this.dgclientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgclientes_CellContentClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.comboestado);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.masktxtcelular);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.lbComplem);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.lbNumero);
            this.tabPage1.Controls.Add(this.masktxtcep);
            this.tabPage1.Controls.Add(this.lbCep);
            this.tabPage1.Controls.Add(this.masktxttelefone);
            this.tabPage1.Controls.Add(this.btnPesquisar);
            this.tabPage1.Controls.Add(this.txtendereco);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.masktxtcpf);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.masktxtrg);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtcodigo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1004, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // comboestado
            // 
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Location = new System.Drawing.Point(806, 254);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(157, 32);
            this.comboestado.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(760, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 24);
            this.label12.TabIndex = 29;
            this.label12.Text = "UF:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(519, 254);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(208, 29);
            this.txtcidade.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 24);
            this.label11.TabIndex = 27;
            this.label11.Text = "Cidade:";
            // 
            // masktxtcelular
            // 
            this.masktxtcelular.Location = new System.Drawing.Point(354, 156);
            this.masktxtcelular.Mask = "(##)#####-####";
            this.masktxtcelular.Name = "masktxtcelular";
            this.masktxtcelular.Size = new System.Drawing.Size(136, 29);
            this.masktxtcelular.TabIndex = 7;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.Location = new System.Drawing.Point(664, 202);
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.Size = new System.Drawing.Size(299, 29);
            this.txtcomplemento.TabIndex = 11;
            this.txtcomplemento.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // lbComplem
            // 
            this.lbComplem.AutoSize = true;
            this.lbComplem.Location = new System.Drawing.Point(523, 207);
            this.lbComplem.Name = "lbComplem";
            this.lbComplem.Size = new System.Drawing.Size(134, 24);
            this.lbComplem.TabIndex = 24;
            this.lbComplem.Text = "Complemento:";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(902, 151);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(59, 29);
            this.txtnumero.TabIndex = 9;
            // 
            // lbNumero
            // 
            this.lbNumero.AutoSize = true;
            this.lbNumero.Location = new System.Drawing.Point(792, 156);
            this.lbNumero.Name = "lbNumero";
            this.lbNumero.Size = new System.Drawing.Size(36, 24);
            this.lbNumero.TabIndex = 22;
            this.lbNumero.Text = "Nº:";
            // 
            // masktxtcep
            // 
            this.masktxtcep.Location = new System.Drawing.Point(565, 156);
            this.masktxtcep.Mask = "00000-999";
            this.masktxtcep.Name = "masktxtcep";
            this.masktxtcep.Size = new System.Drawing.Size(137, 29);
            this.masktxtcep.TabIndex = 8;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Location = new System.Drawing.Point(509, 159);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(50, 24);
            this.lbCep.TabIndex = 20;
            this.lbCep.Text = "Cep:";
            // 
            // masktxttelefone
            // 
            this.masktxttelefone.Location = new System.Drawing.Point(102, 156);
            this.masktxttelefone.Mask = "(##) ####,####";
            this.masktxttelefone.Name = "masktxttelefone";
            this.masktxttelefone.Size = new System.Drawing.Size(131, 29);
            this.masktxttelefone.TabIndex = 6;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(750, 152);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(104, 29);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(102, 202);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(273, 29);
            this.txtendereco.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Endereço:";
            // 
            // txtbairro
            // 
            this.txtbairro.Location = new System.Drawing.Point(102, 254);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(273, 29);
            this.txtbairro.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 24);
            this.label9.TabIndex = 14;
            this.label9.Text = "Bairro:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 24);
            this.label8.TabIndex = 12;
            this.label8.Text = "Telefone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Celular:";
            // 
            // masktxtcpf
            // 
            this.masktxtcpf.Location = new System.Drawing.Point(724, 104);
            this.masktxtcpf.Mask = "###,###,###-##";
            this.masktxtcpf.Name = "masktxtcpf";
            this.masktxtcpf.Size = new System.Drawing.Size(237, 29);
            this.masktxtcpf.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(660, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "CPF:";
            // 
            // masktxtrg
            // 
            this.masktxtrg.Location = new System.Drawing.Point(724, 55);
            this.masktxtrg.Mask = "##,###,###-#";
            this.masktxtrg.Name = "masktxtrg";
            this.masktxtrg.Size = new System.Drawing.Size(237, 29);
            this.masktxtrg.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(660, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "RG:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(102, 106);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(453, 29);
            this.txtemail.TabIndex = 4;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "E-mail:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(102, 60);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(453, 29);
            this.txtnome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome:";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(102, 10);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(143, 29);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 83);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1012, 428);
            this.tabControl1.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(114, 517);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(149, 59);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(668, 517);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(149, 59);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Location = new System.Drawing.Point(400, 517);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(149, 59);
            this.btnAlterar.TabIndex = 4;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(892, 517);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 59);
            this.btnSair.TabIndex = 30;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Frmclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 588);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Frmclientes";
            this.Text = "Frmclientes";
            this.Load += new System.EventHandler(this.Frmclientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox masktxtcpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox masktxtrg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtcomplemento;
        private System.Windows.Forms.Label lbComplem;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.Label lbNumero;
        private System.Windows.Forms.MaskedTextBox masktxtcep;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.MaskedTextBox masktxttelefone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox masktxtcelular;
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.DataGridView dgclientes;
        private System.Windows.Forms.Label Pesquisar;
        private System.Windows.Forms.Button btncusultar;
        private System.Windows.Forms.ComboBox combPesquisa;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnSair;
    }
}