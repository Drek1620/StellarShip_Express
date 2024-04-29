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
            //connectionString = "Server=.\\SQLEXPRESS;DataBase=STELLARSHIP; integrated security= true";
           connectionString = @"Server=STELLARSHIP.mssql.somee.com;DataBase=STELLARSHIP; User Id=Drek1620_SQLLogin_1; Password=y8clqb461k";
            

        }
        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
