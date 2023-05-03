using Bella_Bijoux.br.com.BelaBujoux.con;
using MySql.Data.MySqlClient;
using Sistema_locadora.br.com.locadora.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bella_Bijoux.br.com.locadora.dao
{
    internal class ProdutoDao
    {
        private MySqlConnection conexao;

        public ProdutoDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Produtos


        public void CadastrarProdutos(Produtos obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"insert into tb_Produtos (codigo,descricao,quantidade,valor_de_compra,valor_de_venda)
                             values (@codigo,@descricao,@quantidade,@valor_de_compra,@valor_de_venda)";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@valor_de_compra", obj.valor_compra);
                executacmd.Parameters.AddWithValue("@valor_de_venda", obj.valor_venda);
                



                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Droduto cadastrado com sucesso");


                //Fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);
            }

        }

        #endregion

        #region Metodo para listar Produtos
        public DataTable listarProdutos()
        {
            try
            {
                //1º Passo - criar o DataTable e o comando sql
                DataTable tabelaProdutos = new DataTable();
                string sql = @"select p.codigo as 'Código',
                                      p.descricao as 'Descrição do produto',
                                      p.Quantidade as 'Quantidade',
                                      p.Estoque as 'QTD Estoque',
                                      p.ValorCompra as 'VALOR DE COMPRA',
                                      p.Valor as 'VALOR DE VENDA')";



                //2º - Passo Organizar e executar o comando sql
                //2º - Organozar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3º Passo - executar  o comando sql
                conexao.Open();

                //4º Passo - Criar o MySqlDatApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaProdutos);

                //Fechar conexão
                conexao.Close();
                return tabelaProdutos;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                return null;
            }
        }
        #endregion

        #region  Metodo excluir
        public void excluir(Produtos obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"delete from tb_Produtos where id = @id";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Produto excluido com sucesso");


                //Fecha a conexão
                conexao.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);


            }
        }
        #endregion

        #region AlterarProduto
        public void alterarProdutos(Produtos obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_Produtos set codigo=@codigo,descricao=@descricao,quantidade=@quantidade,valor_Compra=@valor_de_compra,valor_Venda=@valor_de_compra  where id=@id";


                //2 passo - Organizar o cmd sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@codigo", obj.codigo);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@quantidade", obj.quantidade);
                executacmd.Parameters.AddWithValue("@valor_de_compra", obj.valor_compra);
                executacmd.Parameters.AddWithValue("@valor_de_venda", obj.valor_venda);


                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Pruduto Alterado com sucesso!");

                //Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region Metodo que lista por nome.
        public DataTable ConsultarProdutosPorDescricao(string descricao)
        {
            try
            {
                //Criar o Data Table
                DataTable tabelaProdutos = new DataTable();

                //Criar o comando sql

                string sql = @"select * from tb_Produtos where descricao = @descricao";

                //Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                adapter.Fill(tabelaProdutos);

                conexao.Close();
                return tabelaProdutos;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro !!" + erro);
                return null;
            }
        }

        #endregion

        #region Metodo de lista clientes por nome
        public DataTable ListarProdutosPorDescricao(String descricao)
        {
            try
            {
                //Criar o Data Table
                DataTable tabelaProdutos = new DataTable();

                //Criar o comando sql

                string sql = @"select * from tb_Produtos where descricao like @descricao";

                //Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", descricao);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                adapter.Fill(tabelaProdutos);

                conexao.Close();
                return tabelaProdutos;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro !!" + erro);
                return null;
            }
        }


        #endregion
        
    }

}
