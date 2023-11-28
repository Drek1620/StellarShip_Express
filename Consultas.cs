using StellarShip_Express.RegistrarPaquete;
using StellarShip_Express.Vehiculos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        public DataTable MostrarSuc() 
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
        }
        public DataTable MostrarEstado()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT DISTINCT Estado FROM Sucursal";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
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

        public DataTable Factura(string hoka)
		{
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from Factura" ;

                    command.CommandType = CommandType.Text;

                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }

        
        

        public DataTable Bitacora()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from bitacora";
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

        public DataTable MostrarClientes()
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Remitente";
                    command.CommandType = CommandType.Text;
                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }

        }

        public bool AltaUsuario(string loginName, string name, string firstName, string secondName, string pass, string acces, long tel, int sucursal, string foto)
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
                    command.Parameters.AddWithValue("@Sucursal", sucursal);
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

        public bool ModificaUsuario(int id, string loginName, string name, string firstName, string secondName, string pass, string acces, long tel,int sucursal, string foto)
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
                    command.Parameters.AddWithValue("@Sucursal", sucursal);
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

        public bool AgregarSucursal(string NombreSuc, string PaisS, string EstadoS, string MunicipioS, string CPS, string TelefS)
        {
            ConexionSQLServ conexionSQL=new ConexionSQLServ();
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
                    command.Parameters.AddWithValue("Pais",PaisS);
                    command.Parameters.AddWithValue("Estado",EstadoS);
                    command.Parameters.AddWithValue("Municipio",MunicipioS);
                    command.Parameters.AddWithValue("CP",CPS);
                    command.Parameters.AddWithValue("Telefono",TelefS);
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
        public bool ModificarSucursal(int IDModi, string NombreSuc, string PaisS, string EstadoS, string MunicipioS, string CPS, string TelefS)
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
        public bool AltaVehiculos(string Marca,string Modelo, string NoPlacas,string TipoVehiculo,string Año,int IdTransportista)
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
                    command.Parameters.AddWithValue("@Responsable",DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@Marca", Marca);
                    command.Parameters.AddWithValue("@Modelo",Modelo);
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

        public bool ModificaVehiculos(int IdModifica, string Marca,string Modelo,string NoPlaca,string TipoVeh,string Año, int IdTransportista) 
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection()) 
            { 
                connection.Open();
                using (var command = new SqlCommand()) 
                { 
                    command.Connection=connection;
                    command.CommandText = "spModificaVehiculo";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Responsable",DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@IdModifica",IdModifica);
                    command.Parameters.AddWithValue("@MarcaAct",Marca);
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
                    command.Parameters.AddWithValue("@IdVehiculoBaja",IdVehiculoBaja);              
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

		public bool AgregarRemitente(string Nombre, string Telefono, string Correo, string Direccion, string Dep, string Cp, string Ciudad, string Estado, string Pais)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "spAgregarRemitente";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
					command.Parameters.AddWithValue("@Nombre", Nombre);
					command.Parameters.AddWithValue("@Telefono", Telefono);
					command.Parameters.AddWithValue("@Correo", Correo);
					command.Parameters.AddWithValue("@Direccion", Direccion);
					command.Parameters.AddWithValue("@Dep", Dep);
					command.Parameters.AddWithValue("@CP", Cp);
					command.Parameters.AddWithValue("@Ciudad", Ciudad);
					command.Parameters.AddWithValue("@Estado", Estado);
					command.Parameters.AddWithValue("@Pais", Pais);
					command.Parameters.Add("@IdCliente", SqlDbType.Int).Direction = ParameterDirection.Output;
					int a = command.ExecuteNonQuery();
					DatosCliente.IdCliente = Convert.ToInt32(command.Parameters["@IdCliente"].Value);
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

		public bool AgregarDetalleEnvio(long IdEnvio, string Destinatario,string Telefono, string DirecDest, string CpDest, string CiudadDest, string EstadoDest, string PaisDest, string Detalles)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "spAltaDetalleEnvio";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
					command.Parameters.AddWithValue("@IdEnvio", IdEnvio);
					command.Parameters.AddWithValue("@Remitente", DatosCliente.IdCliente);
					command.Parameters.AddWithValue("@Destinatario", Destinatario);
					command.Parameters.AddWithValue("@DireccionDestino", DirecDest);
					command.Parameters.AddWithValue("@CpDestino", CpDest);
					command.Parameters.AddWithValue("@CiudadDestino", CiudadDest);
					command.Parameters.AddWithValue("@EstadoDestino", EstadoDest);
					command.Parameters.AddWithValue("@PaisDestino", PaisDest);
					command.Parameters.AddWithValue("@DetallesEstado", Detalles);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
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

		public bool AgregarFactura(int sucursal, long IdEnvio)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "spFactura";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
					command.Parameters.AddWithValue("@Cliente", DatosCliente.IdCliente);
					command.Parameters.AddWithValue("@Cantidad", DatosPaquete.Cantidad);
					command.Parameters.AddWithValue("@Monto", CalcularPrecios.Total);
					command.Parameters.AddWithValue("@Sucursal", DatosUsuario.Sucursal);
					command.Parameters.AddWithValue("@IdEnvio", IdEnvio);
					command.Parameters.Add("@NoFactura", SqlDbType.BigInt).Direction = ParameterDirection.Output;
					int a = command.ExecuteNonQuery();
					if (a > 0)
					{
						DatosCliente.NoFactura= Convert.ToInt64(command.Parameters["@NoFactura"].Value);
						return true;
					}
					else
					{
						return false;
					}
				}



			}
		}

		public bool AgregarPaquete(long IdEnvio, string Embalaje, double Largo, double Ancho, double Peso, string Seguro,string Pelig, string Irreg)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "spAgregarPaquete";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
					command.Parameters.AddWithValue("@IdEnvio", IdEnvio);
					command.Parameters.AddWithValue("@Embalaje", Embalaje);
					command.Parameters.AddWithValue("@Largo", Largo);
					command.Parameters.AddWithValue("@Ancho", Ancho);
					command.Parameters.AddWithValue("@Peso", Peso);
					command.Parameters.AddWithValue("@Seguro", Seguro);
					command.Parameters.AddWithValue("@MPeligroso", Pelig);
					command.Parameters.AddWithValue("@PaqIrregular", Irreg);
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
