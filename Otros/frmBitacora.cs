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
	public partial class frmBitacora : Form
	{
		public frmBitacora()
		{
			InitializeComponent();
		}

		public void mostrarbitacora()
        {
			Consultas consultas = new Consultas();
			dgvDatos.DataSource = consultas.Bitacora();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
			mostrarbitacora();
        }

		private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void iconButton1_Click(object sender, EventArgs e)
        {
			string opcionSeleccionada = cmbFiltros.Texts;

			DataTable Tabla = new DataTable();
			ConexionSQLServ conexionSQL = new ConexionSQLServ();
			if (opcionSeleccionada == "ID")
			{
		
				using (var connection = conexionSQL.GetConnection())
				{
					
					using (var command = new SqlCommand())
					{
						connection.Open();
						string consutaid = "Select * from  bitacora where idbitacora = " + rjTextBox1.Texts + "";
						SqlDataAdapter adap = new SqlDataAdapter(consutaid, connection);
						adap.Fill(Tabla);
						dgvDatos.DataSource = Tabla;
						SqlCommand comando = new SqlCommand(consutaid, connection);
						SqlDataReader leer;
						leer = comando.ExecuteReader();
						connection.Close();
					}
					
				}
				
				
			}
			else if (opcionSeleccionada == "ID Usuario")
			{
				using (var connection = conexionSQL.GetConnection())
				{
					
					using (var command = new SqlCommand())
					{
						connection.Open();
						string consutaidusuario = "select * from Bitacora where idusuario = " + rjTextBox1.Texts + "";
						SqlDataAdapter adap = new SqlDataAdapter(consutaidusuario, connection);
						adap.Fill(Tabla);
						dgvDatos.DataSource = Tabla;
						SqlCommand comando = new SqlCommand(consutaidusuario, connection);
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
						string consutafecha = $"Select * from bitacora where Fecha BETWEEN '{dateTimePicker1.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}' AND '{dateTimePicker2.Value.Date.ToString("yyyy-MM-dd HH:mm:ss")}'";
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
    }
}
