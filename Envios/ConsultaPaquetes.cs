using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Envios
{
	internal class ConsultaPaquetes
	{
		private SqlDataReader LeerFilas;
		private long id_Guia;
		private string recibe;
		private string destino;
		private string estatus;
		private string detalles;

		private int Inicio;
		private int Final;

		public long Id_Guia { get => id_Guia; set => id_Guia = value; }
		public string Recibe { get => recibe; set => recibe = value; }
		public string Destino { get => destino; set => destino = value; }
		public string Estatus { get => estatus; set => estatus = value; }
		public string Detalles { get => detalles; set => detalles = value; }
		public int Inicio1 { get => Inicio; set => Inicio = value; }
		public int Final1 { get => Final; set => Final = value; }


		public DataSet ListarPaquete(FlowLayoutPanel Contenedor)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "ListarPaquetes";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@inicio", Inicio1);
					command.Parameters.AddWithValue("@final", Final1);

					SqlDataAdapter da = new SqlDataAdapter(command);
					DataSet dt = new DataSet();
					da.Fill(dt);

					foreach (DataRow dr in dt.Tables[1].Rows)
					{
						//Muestras los valores obteniendolos con el Índice o el Nombre de la columna, 
						//   de la siguiente manera:
						string valor2 = dr[0].ToString();
						Id_Guia = Convert.ToInt64(dr[0]);
						Recibe = dr[1].ToString();
						Destino = dr[3].ToString();
						Estatus = dr[4].ToString();
						Detalles = dr[5].ToString();

						CuadroPaquete btn = new CuadroPaquete();

						btn.Id = Id_Guia;
						btn.Guia = id_Guia.ToString();
						btn.Recibe = Recibe;
						btn.Destino = Destino;
						btn.Estatus = Estatus;
						btn.Detalles = Detalles;

						Contenedor.Controls.Add(btn);

					}

					return dt;
				}
			}

		}

		public DataSet BusquedaPaquete(FlowLayoutPanel Contenedor, long idEnvio)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "BuscarPaquetes";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@inicio", Inicio1);
					command.Parameters.AddWithValue("@final", Final1);
                    command.Parameters.AddWithValue("@IdEnvio", idEnvio);

                    SqlDataAdapter da = new SqlDataAdapter(command);
					DataSet dt = new DataSet();
					da.Fill(dt);

					foreach (DataRow dr in dt.Tables[1].Rows)
					{
						//Muestras los valores obteniendolos con el Índice o el Nombre de la columna, 
						//   de la siguiente manera:
						string valor2 = dr[0].ToString();
						Id_Guia = Convert.ToInt64(dr[0]);
						Recibe = dr[1].ToString();
						Destino = dr[3].ToString();
						Estatus = dr[4].ToString();
						Detalles = dr[5].ToString();

						CuadroPaquete btn = new CuadroPaquete();

						btn.Id = Id_Guia;
						btn.Guia = id_Guia.ToString();
						btn.Recibe = Recibe;
						btn.Destino = Destino;
						btn.Estatus = Estatus;
						btn.Detalles = Detalles;

						Contenedor.Controls.Add(btn);

					}

					return dt;
				}
			}
		}


		public void LlenarDatos(FlowLayoutPanel Contenedor)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "select IdEnvio,Destinatario,(MunicipioDestino + ', ' + EstadoDestino + ', ' + PaisDestino) AS Destino,Status,DetallesEstado from DetalleEnvio";
					command.CommandType = CommandType.Text;
					LeerFilas = command.ExecuteReader();
					while (LeerFilas.Read())
					{
						Id_Guia = Convert.ToInt64(LeerFilas[0]);
						Recibe = LeerFilas[1].ToString();
						Destino = LeerFilas[2].ToString();
						Estatus = LeerFilas[3].ToString();
						Detalles = LeerFilas[4].ToString();

						CuadroPaquete btn = new CuadroPaquete();

						btn.Id = Id_Guia;
						btn.Guia = id_Guia.ToString();
						btn.Recibe = Recibe;
						btn.Destino = Destino;
						btn.Estatus = Estatus;
						btn.Detalles = Detalles;

						Contenedor.Controls.Add(btn);
					}
				}
			}

		}

		public bool CambiarEstatus(long id, string estatus, string detalles, int? unidad)
		{
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			using (var connection = conexionSQL.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = "spEditarEstatus";
					command.CommandType = CommandType.StoredProcedure;
					command.Parameters.AddWithValue("@Responsable", DatosUsuario.IdUser);
                    command.Parameters.AddWithValue("@Estatus", estatus);
                    command.Parameters.AddWithValue("@Detalles", detalles);
					if (unidad == null)
                        command.Parameters.AddWithValue("@Unidad", SqlDbType.Int).Value = DBNull.Value;
					else
                        command.Parameters.AddWithValue("@Unidad", SqlDbType.Int).Value = unidad;  
                    command.Parameters.AddWithValue("@IdEnvioActu", id);

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

		public DataTable VehiculosSucursal()
		{
			DataTable tabla = new DataTable();
			ConexionSQLServ conexionSQLServ = new ConexionSQLServ();
			using (var connection = conexionSQLServ.GetConnection())
			{
				connection.Open();
				using (var command = new SqlCommand())
				{
					command.Connection = connection;
					command.CommandText = @"select v.IdVehiculo 
											from Vehiculo as v
											inner join Usuario as u
											on v.IdTransportista = u.IdUsuario
											where u.NivelAcceso = 3 and u.Sucursal= @Sucursal";
					command.CommandType = CommandType.Text;
					command.Parameters.AddWithValue("@Sucursal", SqlDbType.Int).Value = DatosUsuario.Sucursal;
					LeerFilas = command.ExecuteReader();
					tabla.Load(LeerFilas);
					return tabla;

                }
			}
		}
	}
}
