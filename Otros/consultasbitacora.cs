using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Otros
{
    internal class consultasbitacora
    {
        private SqlDataReader LeerFilas;

        public DataTable buscarid(string id)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();


            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    connection.Open();
                    string consutaid = "Select * from  bitacora where idbitacora = " + id + "";
                    SqlDataAdapter adap = new SqlDataAdapter(consutaid, connection);
                    adap.Fill(Tabla);
                    SqlCommand comando = new SqlCommand(consutaid, connection);
                    SqlDataReader leer;
                    leer = comando.ExecuteReader();
                    connection.Close();
                }

            }
            return Tabla;
        }

        public DataTable buscarusuario(string idusuario)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();

            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    connection.Open();
                    string consutaidusuario = "select * from Bitacora where idusuario = " + idusuario + "";
                    SqlDataAdapter adap = new SqlDataAdapter(consutaidusuario, connection);
                    adap.Fill(Tabla);
                    SqlCommand comando = new SqlCommand(consutaidusuario, connection);
                    SqlDataReader leer;
                    leer = comando.ExecuteReader();
                    connection.Close();
                }
               
            }
            return Tabla;

        }
        public DataTable buscarfecha(string fecha1,string fecha2)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();

            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    connection.Open();
                    string consutafecha = "Select * from bitacora where Fecha BETWEEN " + "'"+fecha1+"'" + " and " + "'"+fecha2+"'";
                    SqlDataAdapter adap = new SqlDataAdapter(consutafecha, connection); 
                    adap.Fill(Tabla);
                    SqlCommand comando = new SqlCommand(consutafecha, connection);
                    SqlDataReader leer;
                    leer = comando.ExecuteReader();
                    connection.Close();
                }
                

            }
            return Tabla;
        }
    }
}


        
