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
		PaginadoBitacora objb = new PaginadoBitacora();
		DataSet dstabla;
		int paginicio = 1, indice = 0, numfilas = 18, pagfinal;

       

        public frmBitacora()
		{
			InitializeComponent();
			pagfinal = numfilas;
			cargardg();
		}
		
		private void cargardg()
		{
			objb.Inicio = paginicio;
			objb.Final = pagfinal;
			dstabla = objb.paginacionbitacora();
			dgvDatos.DataSource = dstabla.Tables[1];

            int cantidad = Convert.ToInt32(dstabla.Tables[0].Rows[0][0].ToString()) / numfilas;

			if (Convert.ToInt32(dstabla.Tables[0].Rows[0][0].ToString()) % numfilas >= 0)
			{
				cantidad++;
			}

			txtNumPag.Text= cantidad.ToString();
			cmbNumPag.Items.Clear();

			for (int i = 0; i <= cantidad; i++)
			{
				cmbNumPag.Items.Add(i.ToString());
			}

		    cmbNumPag.SelectedIndex = indice;
        }
		public void mostrarbitacora()
        {	
			Consultas consultas = new Consultas();
			dgvDatos.DataSource = consultas.Bitacora();
        }

        private void cmbNumPag_SelectionChangeCommitted(object sender, EventArgs e)
        {
			int pagina = Convert.ToInt32(cmbNumPag.Text);
			indice = pagina - 1;
			paginicio=(pagina - 1)* numfilas + 1;
			pagfinal = pagina * numfilas;
			cargardg();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pagfinal = numfilas;
			cargardg();
        }

        private void frmBitacora_Load(object sender, EventArgs e)
        {
			mostrarbitacora();
            pagfinal = numfilas;
            cargardg();

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
