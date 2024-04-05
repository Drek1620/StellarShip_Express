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

			consultasbitacora consultas = new consultasbitacora();
			string opcionSeleccionada = cmbFiltros.Texts;


			

			if (opcionSeleccionada == "ID")
			{
				dgvDatos.DataSource = consultas.buscarid(txtBusqueda.Texts);
				
			}
			else if (opcionSeleccionada == "ID Usuario")
			{

                dgvDatos.DataSource = consultas.buscarusuario(txtBusqueda.Texts);
            }
			
			else if (opcionSeleccionada == "Fecha")
			{
                dgvDatos.DataSource = consultas.buscarfecha(dateTimePicker1.Text,dateTimePicker2.Text);

            }


        }
    }
}
