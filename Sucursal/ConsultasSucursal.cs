using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.Sucursal
{
    internal class ConsultasSucursal
    {
        private SqlDataReader LeerFilas;

        public bool AgregarSucursal(string NombreSuc, string PaisS, string EstadoS, string MunicipioS, string CPS, string Calle, string TelefS)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spAgregarSucursal";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("Nombre", NombreSuc);
                    command.Parameters.AddWithValue("Pais", PaisS);
                    command.Parameters.AddWithValue("Estado", EstadoS);
                    command.Parameters.AddWithValue("Municipio", MunicipioS);
                    command.Parameters.AddWithValue("CP", CPS);
                    command.Parameters.AddWithValue("Calle", Calle);
                    command.Parameters.AddWithValue("Telefono", TelefS);
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
       /* public DataTable MostrarSuc()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Sucursal";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }*/

        public bool ModificarSucursal(int IDModi, string NombreSuc, string PaisS, string EstadoS, string MunicipioS, string CPS, string Calle, string TelefS)
        {

            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "spEditarSucursal";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@idActua", IDModi);
                    command.Parameters.AddWithValue("NombreActua", NombreSuc);
                    command.Parameters.AddWithValue("PaisActua", PaisS);
                    command.Parameters.AddWithValue("EstadoActua", EstadoS);
                    command.Parameters.AddWithValue("MunicipioActua", MunicipioS);
                    command.Parameters.AddWithValue("CPActua", CPS);
                    command.Parameters.AddWithValue("CalleActua", Calle);
                    command.Parameters.AddWithValue("TelefonoActua", TelefS);
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
        public bool EliminaSucursal(int IdEliminaSuc)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spBajaSucursal";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@idBajaSuc", IdEliminaSuc);
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

        public DataTable BuscarIdSuc(string idDesti)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Sucursal WHERE IdDestino LIKE '" + idDesti + "%'";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }
        public DataTable BuscarNombreSuc(string NombreSuc)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Sucursal WHERE Nombre LIKE '" + NombreSuc + "%'";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }

        public DataTable BuscarMunic(string MunicSuc)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Sucursal WHERE Municipio LIKE '" + MunicSuc + "%'";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }

        public DataTable ListarEstados()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarEstados";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }



        public DataTable ListarSucursal()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "ListarSucursal";
                    command.CommandType = CommandType.StoredProcedure;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }

    }
}
