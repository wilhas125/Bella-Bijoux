using MySql.Data.MySqlClient;
using Projeto_vendas_Fatec.br.com.projeto.con;
using Projeto_vendas_Fatec.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_vendas_Fatec.br.com.projeto.dao
{
    class ProdutosDao
    {
         
        //Conexão com o banco de dados
        private MySqlConnection conexao;

        public ProdutosDao()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        //Metodos
        #region Metodo para cadastrar Fornecedor
        public void cadastrarProdutos(Produtos obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"insert into tb_produtos (descricao,preco,qtd_estoque,for_id)
                             values (@descricao,@preco,@qtd_estoque,@for_id)";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@preco", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);


                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Produto cadastrado com sucesso");


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
                string sql = @"select p.id as 'Código',
                                      p.descricao as 'Descrição do produto',
                                      p.preco as 'Preço',
                                      p.qtd_estoque as 'QTD Estoque',
                                      f.nome as 'Fornecedor' from tb_produtos as p
                                      join tb_fornecedores as f on (p.for_id = f.id)";



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
                string sql = @"delete from tb_produtos where id = @id";

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
                string sql = @"update tb_produtos set descricao=@descricao,precos=@precos,qtd_estoque=@qtd_estoque,for_id=@for_id  where id=@id";


                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                executacmd.Parameters.AddWithValue("@precos", obj.preco);
                executacmd.Parameters.AddWithValue("@qtd_estoque", obj.qtd_estoque);
                executacmd.Parameters.AddWithValue("@for_id", obj.for_id);


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

                string sql = @"select * from tb_produtos where descricao = @descricao";

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

                string sql = @"select * from tb_produtos where descricao like @descricao";

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
    

