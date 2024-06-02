using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.Personal
{
    internal class ConsultasPersonal
    {
        private SqlDataReader LeerFilas;
        private int inicio;
        private int final;
        public int Inicio { get => inicio; set => inicio = value; }
        public int Final { get => final; set => final = value; }

        public DataSet Personal()
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlCommand comando = new SqlCommand("ListarPersonal", connection);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@inicio", Inicio);
                    comando.Parameters.AddWithValue("@final", Final);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
