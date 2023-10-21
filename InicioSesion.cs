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
            
            if (tipo== "Microsoft SQL Server") //Para SQLServer
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
                            DatosUsuario.PrimerApellido = command.Parameters["@SegundoA"].Value.ToString();
                            DatosUsuario.Telefono = Convert.ToInt64(command.Parameters["@Telefono"].Value);
                            return true;

                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }
            else //Para MySQL
            {
                ConexionMySql conexionSQL = new ConexionMySql();
                using (var connection = conexionSQL.GetConnection())
                {
                    connection.Open();
                    using (var command = new MySqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "spLogueoUsuario";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@_nombreUsuario", user);
                        command.Parameters.AddWithValue("@_contraseñaUsuario", pass);
                        command.Parameters.Add("@_idusuariologueo", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@_tipo", MySqlDbType.Int32).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@_estado", MySqlDbType.Bit).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@_nombre", MySqlDbType.VarChar, 20).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@_PrimerA", MySqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                        command.Parameters.Add("@_SegundoA", MySqlDbType.VarChar, 50).Direction = ParameterDirection.Output;
                        //command.Parameters.Add("@nombre", SqlDbType.VarChar, 50);
                        //command.Parameters["@ClientName"].Dirección = ParameterDirection.Output;
                        command.ExecuteNonQuery();
                        if (command.Parameters["@_idusuariologueo"].Value.ToString() != "")
                        {
                            DatosUsuario.IdUser = Convert.ToInt32(command.Parameters["@_idusuariologueo"].Value);
                            DatosUsuario.LoginNombre = user;
                            DatosUsuario.Contraseña = pass;
                            DatosUsuario.Nombre = command.Parameters["@_nombre"].Value.ToString();
                            DatosUsuario.Acceso = Convert.ToInt32(command.Parameters["@_tipo"].Value);
                            DatosUsuario.PrimerApellido= command.Parameters["@_PrimerA"].Value.ToString();
                            // MessageBox.Show(command.Parameters["@_idusuariologueo"].Value.ToString());
                            return true;

                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }
        }
    }
}
