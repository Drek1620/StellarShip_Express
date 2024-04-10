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

			if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas >= 0) cantidad++;

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

		private void frmEnviosEnCurso_Load(object sender, EventArgs e)
		{
			LlenarPaquetes();
		}

		private void BtnCambiar_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Hola");
		}

		private void btnActualizar_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			LlenarPaquetes();
		}
	}
}
