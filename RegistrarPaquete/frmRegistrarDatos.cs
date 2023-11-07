using StellarShip_Express.Formularios;
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
    public partial class frmRegistrarDatos : Form
    {
        frm_Menu frm_Menu = new frm_Menu();
        private Form currentChildForm;
        public frmRegistrarDatos()
        {
            InitializeComponent();
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

        private void frmRegistrarPaquete_Resize(object sender, EventArgs e)
        {
        }


        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmRegistrarEmpaque());
        }
    }
}
