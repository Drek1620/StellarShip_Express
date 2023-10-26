using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.RegistrarPaquete
{
    public partial class frmRegistrarPaquete : Form
    {
        public frmRegistrarPaquete()
        {
            InitializeComponent();
        }

        private void frmRegistrarPaquete_Resize(object sender, EventArgs e)
        {
            txtNombre.Refresh();
            txtDireccion.Refresh();
            txtEmpresa.Refresh();
            txtNoInterior.Refresh();
        }
    }
}
