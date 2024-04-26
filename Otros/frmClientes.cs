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

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //puto el que lo lea
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ConsultasClientes consultas = new ConsultasClientes();
            string opcionSeleccionada = cmbFiltros.Texts;

            if (opcionSeleccionada == "ID")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteI(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "Nombre")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteN(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "Ciudad")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteC(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "Estado")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteE(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "País")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteP(txtBusqueda.Text);
            }
        }

        private void cmbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //puro coco
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
