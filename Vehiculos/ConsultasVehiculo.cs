using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.Vehiculos
{
    public class ConsultasVehiculo
    {
        private SqlDataReader LeerFilas;

        //METODO PARA LA PAGINACION LO MANDO A MI CLASE FRMVEHICULO
        public DataSet ListarVehiculos(int inicio, int final)
        {
            
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "splistarVehiculos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@inicio", inicio);
                    command.Parameters.AddWithValue("@final",final);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet dt = new DataSet(); 
                    da.Fill(dt);    
                    return dt;  
                   
                }
            }

        }


        public DataTable MostrarVehiculos()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Vehiculo";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }

        }

        //metodos para busqueda de vehiculos
        public DataTable BuscarMarca(string marca)
        {

            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Idvehiculo,Marca,Modelo,NoPlaca,TipoVehiculo,Año,IdTransportista FROM Vehiculo WHERE Marca LIKE '" + marca + "%'";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }

        }

        public DataTable BuscarID(string id)
        {

            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Idvehiculo,Marca,Modelo,NoPlaca,TipoVehiculo,Año,IdTransportista  FROM Vehiculo WHERE IdVehiculo LIKE '" + id + "%'";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }

        }

        public DataTable BuscarTipoV(string tipo)
        {

            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Idvehiculo,Marca,Modelo,NoPlaca,TipoVehiculo,Año,IdTransportista  FROM Vehiculo WHERE TipoVehiculo LIKE '" + tipo + "%'";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }

        }



        public DataTable Conductores()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT Idusuario FROM Usuario where NivelAcceso = 3";
                    command.CommandType = CommandType.Text;

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(Tabla);
                    return Tabla;
                }
            }

        }

        public bool AltaVehiculos(string Marca, string Modelo, string NoPlacas, string TipoVehiculo, string Año, int IdTransportista)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spAltaVehiculos";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@Marca", Marca);
                    command.Parameters.AddWithValue("@Modelo", Modelo);
                    command.Parameters.AddWithValue("@Noplacas", NoPlacas);
                    command.Parameters.AddWithValue("@TipoVehiculo", TipoVehiculo);
                    command.Parameters.AddWithValue("@Año", Año);
                    command.Parameters.AddWithValue("@IdTransportista", IdTransportista);
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

        public bool ModificaVehiculos(int IdModifica, string Marca, string Modelo, string NoPlaca, string TipoVeh, string Año, int IdTransportista)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spModificaVehiculo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@IdModifica", IdModifica);
                    command.Parameters.AddWithValue("@MarcaAct", Marca);
                    command.Parameters.AddWithValue("@ModeloAct", Modelo);
                    command.Parameters.AddWithValue("@NoPlacaAct", NoPlaca);
                    command.Parameters.AddWithValue("@TipoVehiculoAct", TipoVeh);
                    command.Parameters.AddWithValue("@AñoAct", Año);
                    command.Parameters.AddWithValue("@IdTransportistaAct", IdTransportista);
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
        public bool EliminaVehiculos(int IdVehiculoBaja)
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "spBajaVehiculo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@IdVehiculoBaja", IdVehiculoBaja);
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
