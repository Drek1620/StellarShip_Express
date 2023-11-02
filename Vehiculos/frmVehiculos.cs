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
            DatosVehiculo.AccionV = "Modifica";
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DatosVehiculo.AccionV = "Modifica";
                DatosVehiculo.IdVehiculo = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdVehiculo"].Value);
                DatosVehiculo.Marca = dgvDatos.CurrentRow.Cells["Marca"].Value.ToString();
                DatosVehiculo.Modelo = dgvDatos.CurrentRow.Cells["Modelo"].Value.ToString();
                DatosVehiculo.NoPlaca = dgvDatos.CurrentRow.Cells["NoPlaca"].Value.ToString();
                DatosVehiculo.TipoVehiculo = dgvDatos.CurrentRow.Cells["TipoVehiculo"].Value.ToString();
                DatosVehiculo.Año = dgvDatos.CurrentRow.Cells["Año"].Value.ToString();
                DatosVehiculo.IdTransportista = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdTransportista"].Value);
                frmRegistrarVehiculo frm = new frmRegistrarVehiculo();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Seleccione la fila de los datos que desea modificar.\nPor favor", "Seleccione los datos"
                ,MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        Consultas dato = new Consultas();    
      
        private void btnEliminar_Click(object sender, EventArgs e)
        {          
            DatosVehiculo.AccionV = "Baja";
            if (dgvDatos.SelectedRows.Count > 0) 
            {
                DatosVehiculo.IdVehiculo = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdVehiculo"].Value);
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este vehiculo",
                "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    var Elimina = dato.EliminaVehiculos(DatosVehiculo.IdVehiculo);
                    if (Elimina == true)
                    {
                        MessageBox.Show(this, "Vehiculo Eliminado exitosamente", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show(this, "El Vehiculo No existe en la base de datos", "Vehiculo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show(this, "Seleccione la fila de los datos que desea modificar.\nPor favor", "Seleccione los datos"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
