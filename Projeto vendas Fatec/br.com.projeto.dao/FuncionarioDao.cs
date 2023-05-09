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
    class FuncionarioDao
    {

        //Conexão com o banco de dados
        private MySqlConnection conexao;

        public FuncionarioDao()
        {
            this.conexao = new ConnectionFactory().getConnection();
        }

        //Metodos

        #region  Metodo excluir
        public void excluir(Funcionarios obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"delete from tb_funcionarios where id = @id";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Funcionario excluido com sucesso");


                //Fecha a conexão
                conexao.Close();



            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);


            }
        }
        #endregion

        #region cadastrarFuncionarios(Funcionarios obj)
        public void cadastrarFuncionarios(Funcionarios obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                             values (@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);



                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Furcionario cadastrado com sucesso");


                //Fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);
            }
        }
        #endregion

        #region Metodo para listar Funcionarios
        public DataTable listarFuncionarios()
        {
            try
            {
                //1º Passo - criar o DataTable e o comando sql
                DataTable tabelaFucionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                //2º - Passo Organizar e executar o comando sql
                //2º - Organozar o comando sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);

                //3º Passo - executar  o comando sql
                conexao.Open();

                //4º Passo - Criar o MySqlDatApter para preencher os dados no DataTable
                MySqlDataAdapter da = new MySqlDataAdapter(executacmd);
                da.Fill(tabelaFucionario);

                //Fechar conexão
                conexao.Close();
                return tabelaFucionario;
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!" + erro);
                return null;
            }
        }
        #endregion

        #region Alterar
        public void alterarFucionario(Funcionarios obj)
        {
            try
            {
                //1 passo - definir o cmd sql -  insert into
                string sql = @"update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,telefone=@telefone,
                            celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado
                                     where id=@id";

                //2 passo - Organizar o cmd sql
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@senha", obj.Senha);
                executacmd.Parameters.AddWithValue("@cargo", obj.Cargo);
                executacmd.Parameters.AddWithValue("@nivel_acesso", obj.Nivel);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Bairro);
                executacmd.Parameters.AddWithValue("@cidade", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);

                executacmd.Parameters.AddWithValue("@id", obj.Id);

                //3 passo - Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();

                MessageBox.Show("Fucionario Alterado com sucesso!");

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
        public DataTable ConsultarFucionarioPorNome(string nome)
        {
            try
            {
                //Criar o Data Table
                DataTable tabelaFucionarios = new DataTable();

                //Criar o comando sql

                string sql = @"select * from tb_funcionarios where nome = @nome";

                //Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                adapter.Fill(tabelaFucionarios);

                conexao.Close();
                return tabelaFucionarios;


            }
            catch (Exception erro)
            {

                MessageBox.Show("Aconteceu um erro !!" + erro);
                return null;
            }
        }

        #endregion


        #region Metodo de lista clientes por nome
        public DataTable ListarFucionariosPorNome(String nome)
        {
            try
            {
                //Criar o Data Table
                DataTable tabelaFucionarios = new DataTable();

                //Criar o comando sql

                string sql = @"select * from tb_funcionarios where nome like nome";

                //Organizar e executar o comando sql

                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", nome);
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(executacmd);
                adapter.Fill(tabelaFucionarios);

                conexao.Close();
                return tabelaFucionarios;


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

