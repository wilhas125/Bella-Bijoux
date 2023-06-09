﻿using MySql.Data.MySqlClient;
using Projeto_vendas_Fatec.br.com.projeto.con;
using Sistema_locadora.br.com.locadora.model;

namespace Sistema_locadora.br.com.locadora.dao
{
    class LoginDao
    {

        private MySqlConnection conexao;

        public LoginDao() {

            {
                
                this.conexao = new ConnectionFactory().getConnection();
            }

        }
        public bool tem = false;
        public string messagem = "";
        
        //Conexao con = new Conexao();

        MySqlDataReader dr;
        public bool verfificarLogin(Usuários obj) {
            
            string sql = "select * from tb_usuarios where email = @email and senha = @senha";

            // command.CommandText = "select * from tb_usuarios where email = @email and senha = @senha";
            MySqlCommand executacmd = new MySqlCommand(sql, conexao);
            executacmd.Parameters.AddWithValue("@email", obj.email);
            executacmd.Parameters.AddWithValue("@senha", obj.senha);

            try
            {
                conexao.Open();
                executacmd.ExecuteNonQuery();

                dr = executacmd.ExecuteReader();
                if (dr.HasRows) 
                {
                    tem = true;
                }
            }
            catch (MySqlException e)
            {

                this.messagem = e.Message;
            }

            conexao.Close();
            return tem;
            
        }

        
       

       
    }
}
