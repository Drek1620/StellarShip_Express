using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
