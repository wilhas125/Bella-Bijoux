using Bella_Bijoux.br.com.locadora.dao;
using Sistema_locadora.br.com.locadora.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bella_Bijoux
{
    public partial class Cadastro : Form
    {
        public Cadastro(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {

                //1 Passo - receber os dados da tela no objeto model de cliente
                Produtos obj = new Produtos();

                obj.codigo = int.Parse(texBoxCod.Text);
                obj.descricao = textBoxDescri.Text;
                obj.quantidade = int.Parse(textBoxQuantidade.Text);
                obj.estoque = int.Parse(textBoxEstoque.Text);
                obj.valor_compra = decimal.Parse(textBoxCompra.Text);
                obj.valor_venda = decimal.Parse(textBoxValorAtual.Text);




                //2º Passo - Criar o objeto ClienteDAO para chamar o metodo cadastrarCliente
                ProdutoDao dao = new ProdutoDao();
                dao.CadastrarProdutos(obj);



                //MEtodos para limpar a tela de entrada de dados
                texBoxCod.Text = "";
                textBoxDescri.Text = "";
                textBoxQuantidade.Text = "";
                textBoxEstoque.Text = "";
                textBoxCompra.Text = "";
                textBoxValorAtual.Text = "";
                texBoxCod.Focus();
            }
            catch (Exception erro)
            {

                MessageBox.Show("Ocorreu um erro, digite  os dados novamente!" + erro);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
