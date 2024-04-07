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
    internal class ConsultasFactura
    {
        private SqlDataReader LeerFilas;

        public DataTable NoFactura(string NoFactura)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();


            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    connection.Open();
                    string consutaNoFac = "Select * from Factura where NoFactura LIKE " + NoFactura + "";
                    SqlDataAdapter adap = new SqlDataAdapter(consutaNoFac, connection);
                    adap.Fill(Tabla);
                    SqlCommand comando = new SqlCommand(consutaNoFac, connection);
                    SqlDataReader leer;
                    leer = comando.ExecuteReader();
                    connection.Close();
                }

            }
            return Tabla;
        }

        public DataTable IdCliente(string idcliente)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();

            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    connection.Open();
                    string consutaidcliente = "select * from Factura where Cliente LIKE " + idcliente + "";
                    SqlDataAdapter adap = new SqlDataAdapter(consutaidcliente, connection);
                    adap.Fill(Tabla);
                    SqlCommand comando = new SqlCommand(consutaidcliente, connection);
                    SqlDataReader leer;
                    leer = comando.ExecuteReader();
                    connection.Close();
                }

            }
            return Tabla;

        }
        public DataTable Sucursal(string Suc)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();

            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    connection.Open();
                    string consutasucursal = "Select * from Factura where Sucursal LIKE " + Suc + " ";
                    SqlDataAdapter adap = new SqlDataAdapter(consutasucursal, connection);
                    adap.Fill(Tabla);
                    SqlCommand comando = new SqlCommand(consutasucursal, connection);
                    SqlDataReader leer;
                    leer = comando.ExecuteReader();
                    connection.Close();
                }


            }
            return Tabla;
        }
        public DataTable BuscFecha(DateTimePicker fecha1, DateTimePicker fecha2)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();

            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    //No funca 
                    connection.Open();
                    string consutafecha =  $"Select * from Factura where Fecha BETWEEN '{fecha1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{fecha2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}'";
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
