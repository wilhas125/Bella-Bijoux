using MySql.Data.MySqlClient;
using Projeto_vendas_Fatec.br.com.projeto.model;
using System;
using System.Windows.Forms;

namespace Projeto_vendas_Fatec.br.com.projeto.dao
{
     class ClientesDaoBase
    {
        public MySqlConnection conexao;


        #region comando SQL - Insert into
        //Metodos
        public void CadastrarClientes(Clientes obj)
        {
            try
            {
                //1º Passo- Definir o comando SQL - Insert into
                string sql = @"insert into tb_clientes (nome,rg,cpf,email,telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                             values (@nome,@rg,@cpf,@email,@telefone,@celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                //2º Passo- Organizar o comando SQL
                MySqlCommand executacmd = new MySqlCommand(sql, conexao);
                executacmd.Parameters.AddWithValue("@nome", obj.Nome);
                executacmd.Parameters.AddWithValue("@rg", obj.Rg);
                executacmd.Parameters.AddWithValue("@cpf", obj.Cpf);
                executacmd.Parameters.AddWithValue("@email", obj.Email);
                executacmd.Parameters.AddWithValue("@telefone", obj.Telefone);
                executacmd.Parameters.AddWithValue("@celular", obj.Celular);
                executacmd.Parameters.AddWithValue("@cep", obj.Cep);
                executacmd.Parameters.AddWithValue("@endereco", obj.Endereco);
                executacmd.Parameters.AddWithValue("@numero", obj.Numero);
                executacmd.Parameters.AddWithValue("@complemento", obj.Complemento);
                executacmd.Parameters.AddWithValue("@bairro", obj.Cidade);
                executacmd.Parameters.AddWithValue("@estado", obj.Estado);

                //3º PASSO- Abrir a conexao e executar o comando sql
                conexao.Open();
                executacmd.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso");


                //Fecha a conexão
                conexao.Close();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu um erro!!: " + erro);
            }

        }//Fecha o metodo cadastrar
    }
    #endregion
}