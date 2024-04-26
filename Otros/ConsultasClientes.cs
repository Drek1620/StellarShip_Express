using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.Types;
using MySql.Data;
using MySql.Data.MySqlClient;
using StellarShip_Express.Otros;
using System.Windows.Media.Animation;
using System.ComponentModel.Design;
using System.Windows.Markup;

namespace StellarShip_Express.Otros
{
    internal class ConsultasClientes
    {
        public DataTable MostrarBusquedaClienteN(string nombre)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                string consultaNombreUsuario = "SELECT * FROM Remitente WHERE Nombre = @Nombre";
                using (var command = new SqlCommand(consultaNombreUsuario, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    SqlDataAdapter adap = new SqlDataAdapter(command);
                    adap.Fill(Tabla);
                }
            }
            return Tabla;
        }

        public DataTable MostrarBusquedaClienteI(string IdRemitente)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {

                using (var command = new SqlCommand())
                {
                    connection.Open();
                    string consutaidusuario = "select * from Remitente where IdRemitente = " + IdRemitente + "";
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

        public DataTable MostrarBusquedaClienteC(string Ciudad)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                string consultaCiudadUsuario = "SELECT * FROM Remitente WHERE Ciudad = @Ciudad";
                using (var command = new SqlCommand(consultaCiudadUsuario, connection))
                {
                    command.Parameters.AddWithValue("@Ciudad", Ciudad);
                    SqlDataAdapter adap = new SqlDataAdapter(command);
                    adap.Fill(Tabla);
                }
            }
            return Tabla;
        }

        public DataTable MostrarBusquedaClienteE(string Estado)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                string consultaEstadoUsuario = "SELECT * FROM Remitente WHERE Estado = @Estado";
                using (var command = new SqlCommand(consultaEstadoUsuario, connection))
                {
                    command.Parameters.AddWithValue("@Estado", Estado);
                    SqlDataAdapter adap = new SqlDataAdapter(command);
                    adap.Fill(Tabla);
                }
            }
            return Tabla;
        }

        public DataTable MostrarBusquedaClienteP(string Pais)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                string consultaPaisUsuario = "SELECT * FROM Remitente WHERE Pais = @Pais";
                using (var command = new SqlCommand(consultaPaisUsuario, connection))
                {
                    command.Parameters.AddWithValue("@Pais", Pais);
                    SqlDataAdapter adap = new SqlDataAdapter(command);
                    adap.Fill(Tabla);
                }
            }
            return Tabla;
        }
    }
}








