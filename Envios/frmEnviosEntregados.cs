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
	public partial class frmEnviosEntregados : Form
	{

		public frmEnviosEntregados()
		{
			InitializeComponent();
		}

		private void frmEnviosEntregados_Load(object sender, EventArgs e)
		{
			MostrarEntregados();
		}

		public void MostrarEntregados()
		{
			Consultas consultas = new Consultas();
			dgvDatos.DataSource = consultas.MostrarEntregados();
		}
	}
}
