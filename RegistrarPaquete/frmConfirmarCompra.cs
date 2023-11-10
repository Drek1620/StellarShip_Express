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
    public partial class frmConfirmarCompra : Form
    {
        public frmConfirmarCompra()
        {
            InitializeComponent();
        }

        private void frmConfirmarCompra_Load(object sender, EventArgs e)
        {
            dgvPaquetes.Columns.Add("Cantidad", "Cantidad");
            dgvPaquetes.Columns.Add("Paquetes", "Paquetes");
            dgvPaquetes.Columns.Add("Servicios extras", "Servicios extras");
        }
    }
}
