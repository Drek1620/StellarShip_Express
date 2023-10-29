using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Vehiculos
{
    public partial class frmVehiculos : Form
    {
        public frmVehiculos()
        {
            InitializeComponent();
        }
        public void MostrarVehiculos()
        {
            Consultas consultas = new Consultas();
            dgvDatos.DataSource = consultas.MostrarVehiculos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosVehiculo.AccionV = "Alta";
            frmRegistrarVehiculo frm = new frmRegistrarVehiculo();
            frm.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarVehiculos();
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            MostrarVehiculos();
        }

        private void dgvDatos_Resize(object sender, EventArgs e)
        {
            if (dgvDatos.Width > 900)
            {
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            else
            {
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }
    }
}
