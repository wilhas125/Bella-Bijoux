using Projeto_vendas_Fatec.br.com.projeto.model;
using Projeto_vendas_Fatec.br.com.pvf.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_vendas_Fatec.br.com.projeto.view
{
    public partial class CadSub : Form
    {
        public CadSub()
        {
            InitializeComponent();
        }

        private void btnCadClientes_Click(object sender, EventArgs e)
        {
            Frmclientes clientes = new Frmclientes();
            clientes.Show();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            
            Dispose();
        }

        private void btnCadFornecedores_Click(object sender, EventArgs e)
        {
            FrmFornecedores fornecedores= new FrmFornecedores();
            fornecedores.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FrmFucionario fucionario = new FrmFucionario();
            fucionario.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmCadastro_de_Produtos produtos= new frmCadastro_de_Produtos();
            produtos.Show();
        }
    }
}
