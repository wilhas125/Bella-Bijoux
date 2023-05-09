using Projeto_vendas_Fatec.br.com.projeto.dao;
using Projeto_vendas_Fatec.br.com.projeto.model;
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
    public partial class frmCadastro_de_Produtos : Form
    {
        public frmCadastro_de_Produtos()
        {
            InitializeComponent();
        }

        private void Cadastro_de_Produtos_Load(object sender, EventArgs e)
        
        {
            //Carregue o compobox de formecedores com os dados do fornecedor
            FornecedorDao dao_fornecedor = new FornecedorDao();
            cbbFornecedor.DataSource = dao_fornecedor.listarFornecedores();

            //O que vc gostaria que seja exibido
            cbbFornecedor.DisplayMember = "nome";

            //O que vc gostaria de capturar 
            cbbFornecedor.ValueMember = "id";


            ProdutosDao dao = new ProdutosDao();
            dgProdutos.DataSource = dao.listarProdutos();

        }
        
        #region//Botão cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            
            try
            {
                // 1 Passo - receber os dados da tela no objeto model de cliente
                Produtos obj = new Produtos();

                obj.descricao = txtDescricao.Text;
                obj.preco = decimal.Parse(txtPreco.Text);
                obj.qtd_estoque = int.Parse(txtQtdEstoque.Text);
                obj.for_id = int.Parse(cbbFornecedor.SelectedValue.ToString());

                ProdutosDao dao = new ProdutosDao();
                dao.cadastrarProdutos(obj);




                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente

                dgProdutos.DataSource = dao.listarProdutos();
                // dgclientes.DataSource = dao.lista();

                //MEtodos para limpar a tela de entrada de dados
                txtcodigo.Text = "";
                txtDescricao.Clear();

                txtPreco.Text = "";
                txtQtdEstoque.Text = "";
                cbbFornecedor.Text = "";


                txtDescricao.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }
        #endregion

        private void dgProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        #region//Pegando os dados da linha selecionada
        private void dgProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados da linha selecionada

            txtcodigo.Text = dgProdutos.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = dgProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = dgProdutos.CurrentRow.Cells[2].Value.ToString();
            txtQtdEstoque.Text = dgProdutos.CurrentRow.Cells[3].Value.ToString();
            cbbFornecedor.Text = dgProdutos.CurrentRow.Cells[4].Value.ToString();


            tabControl1.SelectedTab = tabPage1;
           
        }
        #endregion
        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        #region//Botão Excluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
               
                // 1 Passo - criar o comando sql
                Produtos obj = new Produtos();
                obj.id= int.Parse(txtcodigo.Text);

                //2º passo rxecutar o metodo excluirCliente
                ProdutosDao dao = new ProdutosDao();
                dao.excluir(obj);
                dgProdutos.DataSource = dao.listarProdutos();

                txtcodigo.Text = "";
                txtDescricao.Text = "";
                txtPesquisa.Text = "";
                txtPreco.Text = "";
                txtQtdEstoque.Text = "";
                cbbFornecedor.Text = "";
                

                txtDescricao.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!!" + erro);
            }
        }
        #endregion
        private void cbbFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region Botão editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Produtos obj = new Produtos();
                obj.descricao = txtDescricao.Text;
                obj.preco = decimal.Parse(txtPreco.Text);
                obj.qtd_estoque  = int.Parse(txtQtdEstoque.Text);
                obj.for_id = int.Parse(cbbFornecedor.Text);
                obj.id = int.Parse(txtcodigo.Text);

                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                ProdutosDao dao = new ProdutosDao();
                dao.alterarProdutos(obj);


                dgProdutos.DataSource = dao.listarProdutos();

                txtDescricao.Clear();
                txtPreco.Text = "";
                txtQtdEstoque.Text = "";
                cbbFornecedor.Text = "";
                txtDescricao.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro!!" + erro);
            }
        }
        #endregion

        #region Botão Consultar
        private void btncusultar_Click(object sender, EventArgs e)
        {

            // Receber o nome do campo de texto

            string Descricao = txtPesquisa.Text;

            //Criar o objeto ClienteDAO
            ProdutosDao dao = new ProdutosDao();

            dgProdutos.DataSource = dao.ConsultarProdutosPorDescricao(Descricao);

            if (dgProdutos.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente encontrado!!");
                dgProdutos.DataSource = dao.listarProdutos();
            }
        }
        #endregion

        #region Botão pesquisar
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            // Receber o nome do campo de texto

            string descricao = "%" + txtPesquisa.Text + "%";

            //Criar o objeto ClienteDAO
            ProdutosDao dao = new ProdutosDao();

            dgProdutos.DataSource = dao.ListarProdutosPorDescricao(descricao);
        }
        #endregion
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
