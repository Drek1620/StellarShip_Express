using CustomControls;
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
            OpenChildForm(new frmRegistrarUsuario()); //llama al metodo y abre el form que se pase como parametro
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
        }
    }
}
