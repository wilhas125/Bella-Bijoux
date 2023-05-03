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
    class FilmesDao
    {
        private MySqlConnection conexao;
        public FilmesDao()
        {
            this.conexao = new ConnectionFactory().GetConnection();

        }
        #region Cadastrar Filmes

        public void CadastrarFilmes(Filmes obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"insert into tb_filmes (categoria_id,nome_filme,diretor,valor_locacao)
                             values (@categoria_id,@nome_filme,@diretor,@valor_locacao)";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@categoria_id", obj.Categoria_id);
                executacmd.Parameters.AddWithValue("@nome_filme", obj.nome_filme);
                executacmd.Parameters.AddWithValue("@diretor", obj.diretor);
                executacmd.Parameters.AddWithValue("@valor_locacao", obj.valor_locacao);



                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Filme cadastrado com sucesso");


                //Fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);
            }

        }

        #endregion

        #region Alterar Filmes
        public void alterarFilmes(Filmes obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_filmes set categoria_id=@categoria_id,nome_filme=@nome_filme,diretor=@diretor,valor_locacao=@valor_locacao where id=@id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@categoria_id", obj.Categoria_id);
                executacmd.Parameters.AddWithValue("@nome_filme", obj.nome_filme);
                executacmd.Parameters.AddWithValue("@diretor", obj.diretor);
                executacmd.Parameters.AddWithValue("@valor_locacao", obj.valor_locacao);


                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Filme Alterado com sucesso!");

                //Fechar a conexao
                conexao.Close();
            }

            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }
        #endregion

        #region  Metodo excluir
        public void excluirFilmes(Filmes obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"delete from tb_filmes where id = @id";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Filme excluido com sucesso");


                //Fecha a conexão
                conexao.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);


            }
        }
        #endregion

        #region Metodo para listar Filmes
        public DataTable listarFilmes()
        {
            try
            {
                //1º Passo - criar o DataTable e o comando sql
                DataTable tabelaFilmes = new DataTable();
                string sql = "select * from tb_filmes";

                //2º - Passo Organizar e executar o comando sql
                //2º - Organozar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3º Passo - executar  o comando sql
                conexao.Open();

                //4º Passo - Criar o MySqlDatApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFilmes);

                //Fechar conexão
                conexao.Close();
                return tabelaFilmes;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                return null;
            }
        }
        #endregion

        #region Metodo que lista por nome.
        public DataTable ConsultarFilmePorNome(string nome)
        {
            try
            {
                //Criar o Data Table
                DataTable tabelaFilme = new DataTable();

                //Criar o comando sql

                string sql = @"select * from tb_filmes where nome_filme like @nome_filme";

                //Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome_filme",nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                adapter.Fill(tabelaFilme);

                conexao.Close();
                return tabelaFilme;


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
