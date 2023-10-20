using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express
{
    public class ConexionSQLServ
    {
        private readonly string connectionString;
        public ConexionSQLServ()
        {
            connectionString = "Server=.\\SQLEXPRESS;DataBase=STELLARSHIP; integrated security= true";
        }


        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
