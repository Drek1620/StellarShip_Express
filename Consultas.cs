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
using System.Windows.Forms;

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

		internal object BuscarFechas(string v1, string v2)
		{
			throw new NotImplementedException();
		}

		internal object BuscarFechas(string v, DateTimePicker dateTimePicker2)
		{
			throw new NotImplementedException();
		}

        public DataTable MostrarMun(int IdEstado)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"select m.MunicipioId, m.Descripcion 
                                          from cMunicipios as m
                                          inner join cEstados as e
                                          on m.EstadoId = e.EstadoId
                                          where e.EstadoId = @IdEstado";
                    command.Parameters.AddWithValue("@IdEstado", SqlDbType.Int).Value = IdEstado;
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
                    command.CommandText = "SELECT * FROM cEstados";
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

		internal object BuscarFecha(DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
		{
			throw new NotImplementedException();
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

        
        
		public bool EliminaUsuario(int IdEliminaUsu)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "spBajaUsuario";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
					command.Parameters.AddWithValue("@idBajaUsuario", IdEliminaUsu);
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

		
       // ---------------------------------------------------------------------

       
        

        //---------------------------------------------------------------------------------

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

		public bool AgregarDetalleEnvio(long IdEnvio, string Destinatario,string Telefono,string Correo, string DirecDest,string DepDest, string CpDest, string CiudadDest, string EstadoDest, string PaisDest, string Detalles)
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
                    command.Parameters.AddWithValue("@DepDestino", DepDest);
                    command.Parameters.AddWithValue("@CpDestino", CpDest);
					command.Parameters.AddWithValue("@CiudadDestino", CiudadDest);
					command.Parameters.AddWithValue("@EstadoDestino", EstadoDest);
					command.Parameters.AddWithValue("@PaisDestino", PaisDest);
					command.Parameters.AddWithValue("@DetallesEstado", Detalles);
                    command.Parameters.AddWithValue("@Telefono", Telefono);
                    command.Parameters.AddWithValue("@Correo", Correo);
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
                        
						GenerarFactura.NoFactura= Convert.ToInt64(command.Parameters["@NoFactura"].Value);
                        
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

		public DataTable MostrarEntregados()
		{
			DataTable Tabla = new DataTable();
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "select * from DetalleEnvio where Status = 'Paquete entregado'";
					command.CommandType = CommandType.Text;
					LeerFilas = command.ExecuteReader();
					Tabla.Load(LeerFilas);
					return Tabla;
				}
			}

		}



	}
}
