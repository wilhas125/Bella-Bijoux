using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bella_Bijoux.br.com.BelaBujoux.con
{
     class ConnectionFactory
    {


        public MySqlConnection GetConnection()
            {
            string conexao = ConfigurationManager.
                                    ConnectionStrings["bd_BellaBijoux"].ConnectionString;
                return new MySqlConnection(conexao);
            }
        
    }
}
