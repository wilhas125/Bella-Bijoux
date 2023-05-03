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
    class UsuarioDao
    {
        private MySqlConnection conexao;

        public UsuarioDao() {
            this.conexao = new ConnectionFactory().GetConnection();

        }

        #region Cadastrar Usuário

        public void CadastrarUsuario(Usuários obj) {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"insert into tb_usuarios (nome,email,senha)
                             values (@nome,@email,@senha)";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
               


                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Usuário cadastrado com sucesso");


                //Fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);
            }

        }

        #endregion

        #region  Metodo excluir
        public void excluirUsuario(Usuários obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"delete from tb_usuarios where id = @id";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Usuário excluido com sucesso");


                //Fecha a conexão
                conexao.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);


            }
        }
        #endregion

        #region Alterar Usuario
        public void alterarUsuario(Usuários obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_usuarios set nome=@nome,email=@email,senha=@senha where id=@id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.nome);
                executacmd.Parameters.AddWithValue("@email", obj.email);
                executacmd.Parameters.AddWithValue("@senha", obj.senha);
               

                executacmd.Parameters.AddWithValue("@id", obj.id);

                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Usuário Alterado com sucesso!");

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
        public DataTable ConsultarUsuarioPorNome(string nome)
        {
            try
            {
                //Criar o Data Table
                DataTable tabelaUsuario = new DataTable();

                //Criar o comando sql

                string sql = @"select * from tb_usuarios where nome like @nome";

                //Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                adapter.Fill(tabelaUsuario);

                conexao.Close();
                return tabelaUsuario;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro !!" + erro);
                return null;
            }
        }

        #endregion

        #region Metodo para listar usuario
        public DataTable listarUsuario()
        {
            try
            {
                //1º Passo - criar o DataTable e o comando sql
                DataTable tabelaUsuario = new DataTable();
                string sql = "select * from tb_usuarios";

                //2º - Passo Organizar e executar o comando sql
                //2º - Organozar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3º Passo - executar  o comando sql
                conexao.Open();

                //4º Passo - Criar o MySqlDatApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaUsuario);

                //Fechar conexão
                conexao.Close();
                return tabelaUsuario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                return null;
            }
        }
        #endregion
    }
}
