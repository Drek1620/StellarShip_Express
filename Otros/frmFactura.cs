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

		public frmFactura()
		{
			InitializeComponent();
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
		private void iconButton1_Click(object sender, EventArgs e)
		{
			
			string opcionSeleccionada = cmbFiltros.Texts;
			Consultas consultas = new Consultas();
			DataTable Tabla = new DataTable();
			ConexionSQLServ conexionSQL = new ConexionSQLServ();

			try
			{

				if (opcionSeleccionada == "NoFactura")
				{
					if (rjTextBox1.Texts == "")
					{
						MostrarFactura();
						return;
					}
					dgvDatos.DataSource = consultas.BuscarNoFac(rjTextBox1.Texts);

				}
				if (opcionSeleccionada == "ID Cliente")
				{
					if(rjTextBox1.Texts == "")
					{
						MostrarFactura();
						return;
					}
					dgvDatos.DataSource = consultas.BuscarIdcliente(rjTextBox1.Texts);
				}
				if (opcionSeleccionada == "Sucursal")
				{
					if (rjTextBox1.Texts == "")
					{
						MostrarFactura();
						return;
					}
					dgvDatos.DataSource = consultas.BuscarSuc(rjTextBox1.Texts);
				}
				if (opcionSeleccionada == "Fecha")
				{
					using (var connection = conexionSQL.GetConnection())
					{

						using (var command = new SqlCommand())
						{
							connection.Open();
							string consutafecha = $"Select * from Factura where Fecha BETWEEN '{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}'";
							SqlDataAdapter adap = new SqlDataAdapter(consutafecha, connection);
							adap.Fill(Tabla);
							dgvDatos.DataSource = Tabla;
							SqlCommand comando = new SqlCommand(consutafecha, connection);
							SqlDataReader leer;
							leer = comando.ExecuteReader();
							connection.Close();
						}

					}
				}


			}
			catch (Exception EX)
			{

				MessageBox.Show("Ha ocurrido un error: " + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			MostrarFactura();
		}

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
