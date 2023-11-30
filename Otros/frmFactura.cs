using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StellarShip_Express.Otros
{
	public partial class frmFactura : Form
	{
		private SqlDataReader LeerFilas;
		public frmFactura()
		{
			InitializeComponent();
		}

		private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}


		public void MostrarFactura()
		{
			Consultas consultas = new Consultas();
			dgvDatos.DataSource = consultas.Factura(rjTextBox1.Texts);
		}

		private void frmFactura_Load(object sender, EventArgs e)
		{
			MostrarFactura();
		}

		public void BusquedasFactura() 
		{
			
		}

		private void iconButton1_Click(object sender, EventArgs e)
		{
			

			string opcionSeleccionada = cmbFiltros.Texts;

			DataTable Tabla = new DataTable();
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			if (opcionSeleccionada == "NoFactura")
			{
				if (rjTextBox1.Texts == "")
				{
					MostrarFactura();
					return;
				}
				using (var connection = conexionSQL.GetConnection())
				{
					
					using (var command = new SqlCommand())
					{
						connection.Open();
						string consutaNoFac = "Select * from Factura where NoFactura LIKE " + rjTextBox1.Texts + "";
						SqlDataAdapter adap = new SqlDataAdapter(consutaNoFac, connection);
						adap.Fill(Tabla);
						dgvDatos.DataSource = Tabla;
						SqlCommand comando = new SqlCommand(consutaNoFac, connection);
						SqlDataReader leer;
						leer = comando.ExecuteReader();
						connection.Close();
					}
					
				}
				
				
			}
			else if (opcionSeleccionada == "ID Cliente")
			{
				if (rjTextBox1.Texts == "")
				{
					MostrarFactura();
					return;
				}
				using (var connection = conexionSQL.GetConnection())
				{
					
					using (var command = new SqlCommand())
					{
						connection.Open();
						string consutaNoFac = "Select * from Factura where Cliente LIKE " + rjTextBox1.Texts + "";
						SqlDataAdapter adap = new SqlDataAdapter(consutaNoFac, connection);
						adap.Fill(Tabla);
						dgvDatos.DataSource = Tabla;
						SqlCommand comando = new SqlCommand(consutaNoFac, connection);
						SqlDataReader leer;
						leer = comando.ExecuteReader();
						connection.Close();
					}
					
				}
			}
			else if (opcionSeleccionada == "Sucursal")
			{
				if (rjTextBox1.Texts == "")
				{
					MostrarFactura();
					return;
				}
				using (var connection = conexionSQL.GetConnection())
				{
					
					using (var command = new SqlCommand())
					{
						connection.Open();
						string consutaNoFac = "Select * from Factura where Sucursal LIKE " + rjTextBox1.Texts + "";
						SqlDataAdapter adap = new SqlDataAdapter(consutaNoFac, connection);
						adap.Fill(Tabla);
						dgvDatos.DataSource = Tabla;
						SqlCommand comando = new SqlCommand(consutaNoFac, connection);
						SqlDataReader leer;
						leer = comando.ExecuteReader();
						connection.Close();
					}
					
				}
			}
			else if (opcionSeleccionada == "Fecha")
			{
				using (var connection = conexionSQL.GetConnection())
				{
					
					using (var command = new SqlCommand())
					{
						connection.Open();
						string consutaNoFac = $"Select * from Factura where Fecha BETWEEN '{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}'";
						SqlDataAdapter adap = new SqlDataAdapter(consutaNoFac, connection);
						adap.Fill(Tabla);
						dgvDatos.DataSource = Tabla;
						SqlCommand comando = new SqlCommand(consutaNoFac, connection);
						SqlDataReader leer;
						leer = comando.ExecuteReader();
						connection.Close(); 
					}
					
				}
			}

		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			MostrarFactura();
		}
	}
}
