using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StellarShip_Express
{
    internal class Consultas
    {
        private SqlDataReader LeerFilas;
        //Esta es la forma base para conectarse a la clase conexion
        public DataTable MostrarUsuarios() 
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Usuario";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }

        }

        public DataTable MostrarPuestos()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Puestos";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }

        }

        public bool AltaUsuario(string loginName, string name,string firstName, string secondName, string pass, string acces, long tel, string foto)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spAltaUsuarios";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@LoginNombreNuevo", loginName);
                    command.Parameters.AddWithValue("@NombreUsuarioNuevo", name);
                    command.Parameters.AddWithValue("@PrimerApellido", firstName);
                    command.Parameters.AddWithValue("@SegundoApellido", secondName);
                    command.Parameters.AddWithValue("@TipoNuevo", acces);
                    command.Parameters.AddWithValue("@ContraUsuarioNuevo", pass);
                    command.Parameters.AddWithValue("@Telefono", tel);
                    command.Parameters.AddWithValue("@Foto", foto);
                    int a = command.ExecuteNonQuery();
                    if (a > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public bool ModificaUsuario(int id, string loginName, string name, string firstName, string secondName, string pass, string acces, long tel, string foto)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spModificarUsuario";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@idModifica", id);
                    command.Parameters.AddWithValue("@LoginNombreActualizar", loginName);
                    command.Parameters.AddWithValue("@NombreUsuarioActualizar", name);
                    command.Parameters.AddWithValue("@PrimerApellido", firstName);
                    command.Parameters.AddWithValue("@SegundoApellido", secondName);
                    command.Parameters.AddWithValue("@TipoNuevo", acces);
                    command.Parameters.AddWithValue("@ContraUsuarioActualizar", pass);
                    command.Parameters.AddWithValue("@Telefono", tel);
                    command.Parameters.AddWithValue("@Foto", foto);
                    int a = command.ExecuteNonQuery();
                    if (a > 0)
                    {
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
