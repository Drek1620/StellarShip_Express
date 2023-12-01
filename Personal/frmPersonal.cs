using CustomControls;
using StellarShip_Express.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Formularios
{
    public partial class frmPersonal : Form
    {
        private Form currentChildForm;

        Consultas datos=new Consultas();
        public frmPersonal()
        {
            InitializeComponent();
        }

        public void MostrarUsuarios()
        {
            Consultas consultas = new Consultas();
            dgvDatos.DataSource = consultas.MostrarUsuarios();
        }
        private void OpenChildForm(Form childForm) //Este es para cerrar la ventana actual y mostrar la que se pase como parametro
        {
            
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosModifPersonal.Accion = "Alta";
            frmRegistrarUsuario frm = new frmRegistrarUsuario(); 
            frm.ShowDialog();
        }

        private void frmPersonal_Load(object sender, EventArgs e)
        {
            MostrarUsuarios();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarUsuarios();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DatosModifPersonal.Accion = "Modificar";
                DatosModifPersonal.IdUser=Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdUsuario"].Value) ;
                DatosModifPersonal.LoginNombre = dgvDatos.CurrentRow.Cells["LoginNombre"].Value.ToString();
                DatosModifPersonal.Nombre = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                DatosModifPersonal.PrimerApellido= dgvDatos.CurrentRow.Cells["PrimerApellido"].Value.ToString();
                DatosModifPersonal.SegundoApellido = dgvDatos.CurrentRow.Cells["SegundoApellido"].Value.ToString();
                DatosModifPersonal.Acceso =Convert.ToInt32(dgvDatos.CurrentRow.Cells["NivelAcceso"].Value);
                DatosModifPersonal.Contraseña = dgvDatos.CurrentRow.Cells["Contraseña"].Value.ToString();
                DatosModifPersonal.Telefono = Convert.ToInt64(dgvDatos.CurrentRow.Cells["Telefono"].Value);
                DatosModifPersonal.Foto = dgvDatos.CurrentRow.Cells["Foto"].Value.ToString();
                frmRegistrarUsuario frm = new frmRegistrarUsuario();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Seleccione la fila de los datos que desea modificar.\nPor favor", "Seleccione los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

		private void btnEliminar_Click(object sender, EventArgs e)
		{
			Consultas dato = new Consultas();
			if (dgvDatos.SelectedRows.Count > 0)
			{
				int id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdUsuario"].Value);
				DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este Usuario?",
				"Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (resultado == DialogResult.Yes)
				{
					var Elimina = dato.EliminaUsuario(id);
					if (Elimina == true)
					{
						MessageBox.Show(this, "Usuario Eliminado exitosamente", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
						MessageBox.Show(this, "El Usuario No se pudo eliminar", "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}

			}
			else
			{
				MessageBox.Show(this, "Seleccione la fila de los datos que desea Eliminar.\nPor favor", "Seleccione los datos"
				, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
            if (txtBuscar.Texts != "")
            {

            }
		}
	}
}
