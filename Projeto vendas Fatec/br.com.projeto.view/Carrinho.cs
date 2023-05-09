using MySql.Data.MySqlClient;
using Projeto_vendas_Fatec.br.com.projeto.dao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bella_Bijoux
{
    public partial class Carrinho : Form
    {
       
        public Carrinho(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {

            // Receber o nome do campo de texto

            string descricao = "%" + texBoxCod.Text + "%";

            //Criar o objeto ClienteDAO
            ProdutosDao dao = new ProdutosDao();

            dgCarrinho.DataSource = dao.ListarProdutosPorDescricao(descricao);
        }
        private void Carrinho_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=bdfatec;uid=root;password=Ww@53375507;";
            MySqlConnection conexao = new MySqlConnection(connectionString);


            {
                conexao.Open();
                string consulta = "SELECT * FROM tb_fornecedores";
                using (MySqlCommand cmd = new MySqlCommand(consulta, conexao))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgCarrinho.DataSource = dt;
                    }
                    conexao.Close();
                }
               
            }



        }

        private void dgCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgCarrinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegando os dados da linha selecionada
            texBoxCod.Text = dgCarrinho.CurrentRow.Cells[0].Value.ToString();
            textBoxDescri.Text = dgCarrinho.CurrentRow.Cells[0].Value.ToString();
            textBoxQuantidade.Text = dgCarrinho.CurrentRow.Cells[0].Value.ToString();
            textBoxEstoque.Text = dgCarrinho.CurrentRow.Cells[0].Value.ToString();
            textBoxCompra.Text = dgCarrinho.CurrentRow.Cells[0].Value.ToString();
            textBoxValorAtual.Text = dgCarrinho.CurrentRow.Cells[0].Value.ToString();
            
            


        }
    }
    
}
