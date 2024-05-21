using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows;

namespace StellarShip_Express
{
    internal class InicioSesion
    {
        string tipo = TipoConexion.Conexion; //Esta variable solo es para saber a que BD se va a conectar
        public bool Login(string user, string pass)
        {

            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spLogueoUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@nombreUsuario", user);
                    command.Parameters.AddWithValue("@contraseñaUsuario", pass);
                    command.Parameters.Add("@idusuariologueo", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@tipo", SqlDbType.Int).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@status", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@PrimerA", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@SegundoA", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Telefono", SqlDbType.BigInt).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Sucursal", SqlDbType.Int).Direction = ParameterDirection.Output;
                    //command.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                    //command.Parameters["@ClientName"].Dirección = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    if (command.Parameters["@idusuariologueo"].Value.ToString() != "")
                    {
                        DatosUsuario.IdUser = Convert.ToInt32(command.Parameters["@idusuariologueo"].Value);
                        DatosUsuario.LoginNombre = user;
                        DatosUsuario.Contraseña = pass;
                        DatosUsuario.Nombre = command.Parameters["@nombre"].Value.ToString();
                        DatosUsuario.Acceso = Convert.ToInt32(command.Parameters["@tipo"].Value);
                        DatosUsuario.PrimerApellido = command.Parameters["@PrimerA"].Value.ToString();
                        DatosUsuario.SegundoApellido = command.Parameters["@SegundoA"].Value.ToString();
                        DatosUsuario.Telefono = Convert.ToInt64(command.Parameters["@Telefono"].Value);
                        DatosUsuario.Sucursal = Convert.ToInt32(command.Parameters["@Sucursal"].Value);

                        Trabajo(DatosUsuario.Sucursal);
                        return true;

                    }
                    else
                    {
                        return false;
                    }

                }
            }
        }

        public bool Trabajo(int IdSucursal)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spSucursalTrabajo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdSucursal", SqlDbType.Int).Value=IdSucursal;
                    command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Pais", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Estado", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Municipio", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Cp", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Calle", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.Parameters.Add("@Telefono", SqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();

                    SucursalTrabajo.Nombre = command.Parameters["@Nombre"].Value.ToString();
                    SucursalTrabajo.Pais = command.Parameters["@Pais"].Value.ToString();
                    SucursalTrabajo.Estado = command.Parameters["@Estado"].Value.ToString();
                    SucursalTrabajo.Municipio = command.Parameters["@Municipio"].Value.ToString();
                    SucursalTrabajo.CP = command.Parameters["@Cp"].Value.ToString();
                    SucursalTrabajo.Calle = command.Parameters["@Calle"].Value.ToString();
                    SucursalTrabajo.Telefono = command.Parameters["@Telefono"].Value.ToString();
                }

            }
            return true;
        }
    }
}
