using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace StellarShip_Express
{
    public class ConexionMySql
    {

        private readonly string connectionString;
        public ConexionMySql()
        {
            connectionString = "server=127.0.0.1;database=stellarship;Uid=root;pwd=123456";
        }


        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
