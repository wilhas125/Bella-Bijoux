using MySql.Data.MySqlClient;
using Sistema_locadora.br.com.locadora.con;
using Sistema_locadora.br.com.locadora.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_locadora.br.com.locadora.dao
{
    class CategoriaDao
    {
        private MySqlConnection conexao;

        public CategoriaDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();
        }

        #region Cadastrar Categoria

            public void CadastrarCategoria(Categoria obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"insert into tb_categoria (nome_categoria)
                             values (@nome_categoria)";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome_categoria", obj.nome);
               



                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Categoria cadastrado com sucesso");


                //Fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);
            }

        }

        #endregion

        #region Alterar Categoria
        public void alterarCategoria(Categoria obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_categoria set nome_categoria=@nome_categoria where id=@id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome_categoria", obj.nome);

                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Categoria Alterado com sucesso!");

                //Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion

        #region Metodo para listar categoria
        public DataTable listarCategoria()
        {
            try
            {
                //1º Passo - criar o DataTable e o comando sql
                DataTable tabelaCategoria = new DataTable();
                string sql = "select * from tb_categoria";

                //2º - Passo Organizar e executar o comando sql
                //2º - Organozar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3º Passo - executar  o comando sql
                conexao.Open();

                //4º Passo - Criar o MySqlDatApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaCategoria);

                //Fechar conexão
                conexao.Close();
                return tabelaCategoria;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                return null;
            }
        }
        #endregion

        #region Metodo que lista por nome.
        public DataTable ConsultarCategoriaNome(string nome)
        {
            try
            {
                //Criar o Data Table
                DataTable tabelacategoria = new DataTable();

                //Criar o comando sql

                string sql = @"select * from tb_categoria where nome_categoria like @nome_categoria";

                //Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome_categoria",nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                adapter.Fill(tabelacategoria);

                conexao.Close();
                return tabelacategoria;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro !!" + erro);
                return null;
            }
        }

        #endregion

        #region  Metodo excluir
        public void excluirCategoria(Categoria obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"delete from tb_categoria where id = @id";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Categoria excluido com sucesso");


                //Fecha a conexão
                conexao.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);


            }
        }
        #endregion
    }
}
