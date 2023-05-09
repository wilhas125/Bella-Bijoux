using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Projeto_vendas_Fatec.br.com.projeto.con
{
    public class ConnectionFactory
    {
        public MySqlConnection getConnection()
        {

            string conexao = ConfigurationManager.
                                ConnectionStrings["bdfatec"].ConnectionString;
            return new MySqlConnection(conexao);
        }


    }
}
