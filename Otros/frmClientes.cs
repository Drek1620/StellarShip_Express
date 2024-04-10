using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.Types;
using MySql.Data;
using MySql.Data.MySqlClient;
using StellarShip_Express.Otros;
using System.Windows.Media.Animation;

namespace StellarShip_Express.Otros
{
	public partial class frmClientes : Form
	{
		public frmClientes()
		{
			InitializeComponent();
		}


        public void MostrarClientes()
        {

            Consultas consultas = new Consultas();
            dgvDatos.DataSource = consultas.MostrarClientes();
        }

        public void MostrarBusquedaClienteN()
        {
            string terminoBusqueda = txtBusqueda.Text;
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Remitente WHERE Nombre LIKE '" + txtBusqueda.Text + "%'";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@terminoBusqueda", terminoBusqueda);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Tabla.Load(reader);
                    }
                }
            }
            dgvDatos.DataSource = Tabla;
        }

        public void MostrarBusquedaClienteI()
        {
            string terminoBusqueda = txtBusqueda.Text;
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Remitente WHERE IdRemitente LIKE '" + txtBusqueda.Text + "%'";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@terminoBusqueda", terminoBusqueda);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Tabla.Load(reader);
                    }
                }
            }
            dgvDatos.DataSource = Tabla;
        }

        public void MostrarBusquedaClienteC()
        {
            string terminoBusqueda = txtBusqueda.Text;
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Remitente WHERE Ciudad LIKE '" + txtBusqueda.Text + "%'";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@terminoBusqueda", terminoBusqueda);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Tabla.Load(reader);
                    }
                }
            }
            dgvDatos.DataSource = Tabla;
        }

        public void MostrarBusquedaClienteE()
        {
            string terminoBusqueda = txtBusqueda.Text;
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Remitente WHERE Estado LIKE '" + txtBusqueda.Text + "%'";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@terminoBusqueda", terminoBusqueda);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Tabla.Load(reader);
                    }
                }
            }
            dgvDatos.DataSource = Tabla;
        }

        public void MostrarBusquedaClienteP()
        {
            string terminoBusqueda = txtBusqueda.Text;
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Remitente WHERE Pais LIKE '" + txtBusqueda.Text + "%'";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@terminoBusqueda", terminoBusqueda);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Tabla.Load(reader);
                    }
                }
            }
            dgvDatos.DataSource = Tabla;
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            object opcionSeleccionada = cmbFiltros.SelectedItem;

            if (opcionSeleccionada.ToString() == "Nombre")
            {
                MostrarBusquedaClienteN();
            }
            else if (opcionSeleccionada.ToString() == "ID")
            {
                MostrarBusquedaClienteI();
            }
            else if (opcionSeleccionada.ToString() == "Ciudad")
            {
                MostrarBusquedaClienteC();
            }
            else if (opcionSeleccionada.ToString() == "Estado")
            {
                MostrarBusquedaClienteE();
            }
            else if (opcionSeleccionada.ToString() == "País")
            {
                MostrarBusquedaClienteP();
            }
        }

        private void cmbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarClientes();
        }

		private void frmClientes_Load_1(object sender, EventArgs e)
		{
			MostrarClientes();
		}
	}
}
