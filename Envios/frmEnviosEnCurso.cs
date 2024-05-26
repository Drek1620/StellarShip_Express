using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Envios
{
	public partial class frmEnviosEnCurso : Form
	{
		ConsultaPaquetes obj = new ConsultaPaquetes();
		DataSet dsTabla = new DataSet();
		int PagInicio = 1, Indice = 0, NumFilas = 6, PagFinal;
		public frmEnviosEnCurso()
		{
			InitializeComponent();
			PagFinal = NumFilas;
			
		}

		private void LlenarPaquetes()
		{
			obj.Inicio1 = PagInicio;
			obj.Final1 = PagFinal;
			dsTabla= obj.ListarPaquete(flowLayoutPanel1);

			int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas > 0) cantidad++;

			textBox1.Text = cantidad.ToString();
			comboBox1.Items.Clear();

			for (int i = 1; i <= cantidad; i++)
			{
				comboBox1.Items.Add(i.ToString());
			}

			comboBox1.SelectedIndex = Indice;
		}

		private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			int pagina = Convert.ToInt32(comboBox1.Text);
			Indice = pagina - 1;
			PagInicio = (pagina - 1) * NumFilas + 1;
			PagFinal = pagina * NumFilas;
			LlenarPaquetes();
		}
		int? unidad;
        private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
			
			if (e.KeyChar == (char)Keys.Enter)
			{
				if (cmbCambios.SelectedIndex == 0)
					unidad = Convert.ToInt32(cmbUnidades.SelectedValue);
				else
					unidad = null;
				
                var editar = obj.CambiarEstatus(Convert.ToInt64(txtBusqueda.Texts),
                cmbEstado.Texts, 
				cmbCambios.Texts + " en " + SucursalTrabajo.Municipio + ", " + SucursalTrabajo.Estado + " - "+ DateTime.Now.ToString(),
				unidad);
                txtBusqueda.Texts = "";

				if (editar)
				{
					MessageBox.Show("Correcto");
				}else
                    MessageBox.Show("Error");
            }
			
        }

		public void CargarVehiculos()
		{
			
			cmbUnidades.DataSource = obj.VehiculosSucursal();
			cmbUnidades.ValueMember = "IdVehiculo";
			cmbUnidades.DisplayMember = "IdVehiculo";
        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is CuadroPaquete) ctrl.Width = flowLayoutPanel1.ClientSize.Width - 10;
            }
            flowLayoutPanel1.ResumeLayout();
        }

        private void cmbCambios_OnSelectedValueChanged(object sender, EventArgs e)
        {
			if (cmbCambios.SelectedIndex == 0)
				cmbUnidades.Visible = true;
			else
				cmbUnidades.Visible =false;
        }

        private void frmEnviosEnCurso_Load(object sender, EventArgs e)
		{
			LlenarPaquetes();
			CargarVehiculos();
        }




		private void btnActualizar_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			LlenarPaquetes();
		}
	}
}
