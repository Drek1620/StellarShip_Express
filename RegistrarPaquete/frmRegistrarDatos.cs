using CustomControls.RJControls;
using StellarShip_Express.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.RegistrarPaquete
{
    public partial class frmRegistrarDatos : Form
    {
        frm_Menu frm_Menu = new frm_Menu();
        private Form currentChildForm;
        Consultas consultas = new Consultas();
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
            this.Controls.Clear();
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.FormClosed += AgregarControles;
            childForm.Show();
        }

        private void frmRegistrarPaquete_Resize(object sender, EventArgs e)
        {
            txtNombre.Refresh();
            txtCorreo.Refresh();
            txtTelefono.Refresh();
            txtDireccion.Refresh();
            txtEmpresa.Refresh();
            txtNoInterior.Refresh();
            txtCP.Refresh();
            txtNombreD.Refresh();
            txtCorreoD.Refresh();
            txtTelD.Refresh();
            txtDireccionD.Refresh();
            txtEmpresaD.Refresh();
            txtNointernoD.Refresh();
            txtCpD.Refresh();
        }

        private bool ValidarCampo()
        {
            bool vr = !string.IsNullOrEmpty(txtNombre.Texts) &&
                !string.IsNullOrEmpty(txtCorreo.Texts) &&
                !string.IsNullOrEmpty(txtTelefono.Texts) &&
                !string.IsNullOrEmpty(txtDireccion.Texts) &&
                !string.IsNullOrEmpty(txtCP.Texts) &&
                !string.IsNullOrEmpty(txtNombreD.Texts) &&
                !string.IsNullOrEmpty(txtDireccionD.Texts) &&
                !string.IsNullOrEmpty(txtTelD.Texts) &&
                !string.IsNullOrEmpty(txtCpD.Texts);
            return vr;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (ValidarCampo()==true)
            {
                if (ComprobarFormatoEmail(txtCorreo.Texts) && ComprobarFormatoEmail(txtCorreoD.Texts))
                {

                }
                else
                {
                    MessageBox.Show(this, "Correo electronico no valido", "Correo no valido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                DatosCliente.Cliente[0] = new ArregloCliente(
                    txtNombre.Texts,
                    txtCorreo.Texts.ToUpper(),
                    txtTelefono.Texts,
                    txtEmpresa.Texts,
                    txtDireccion.Texts,
                    txtNoInterior.Texts,
                    txtCP.Texts,
                    cmbCiudad.Texts,
                    cmbEstado.Texts,
                    cmbPais.Texts);
                DatosCliente.Cliente[1] = new ArregloCliente(
                    txtNombreD.Texts,
                    txtCorreoD.Texts.ToUpper(),
                    txtTelD.Texts,
                    txtEmpresaD.Texts,
                    txtDireccionD.Texts,
                    txtNointernoD.Texts,
                    txtCpD.Texts,
                    cmbCiudadD.Texts,
                    cmbEstadoD.Texts,
                    cmbPaisD.Texts);
                OpenChildForm(new frmRegistrarEmpaque());
                Limpiar();
            }
            else
                MessageBox.Show(this, "Ingrese todos los campos obligatorios.\nPor favor", "Ingrese todos los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        public void AgregarControles(object sender, FormClosedEventArgs e)
        {
            InitializeComponent();
        }

        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sEmailAComprobar, sFormato))
            {
                if (Regex.Replace(sEmailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void frmRegistrarDatos_Load(object sender, EventArgs e)
        {
            Ubicaciones();
        }

        public void Ubicaciones()
        {
            

            cmbEstadoD.DataSource = consultas.MostrarEstado();
            cmbEstado.DataSource = consultas.MostrarEstado();
            cmbEstadoD.DisplayMember = "Descripcion";
            cmbEstadoD.ValueMember = "EstadoId";
            cmbEstado.DisplayMember = "Descripcion";
            cmbEstado.ValueMember = "EstadoId";

            
        }
        public void Limpiar()
        {
            txtNombre.Texts="";
            txtCorreo.Texts="";
            txtTelefono.Texts="";
            txtDireccion.Texts="";
            txtEmpresa.Texts="";
            txtNoInterior.Texts="";
            txtCP.Texts="";

            txtNombreD.Texts="";
            txtCorreoD.Texts="";
            txtTelD.Texts="";
            txtDireccionD.Texts="";
            txtEmpresaD.Texts="";
            txtNointernoD.Texts="";
            txtCpD.Texts=""; 
        }


        private void cmbEstado_OnSelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCiudad.DataSource = consultas.MostrarMun(Convert.ToInt32(cmbEstado.SelectedValue));
                cmbCiudad.DisplayMember = "Descripcion";
                cmbCiudad.ValueMember = "MunicipioId";
            }
            catch (Exception)
            {
                return;
            }
            
        }

        private void cmbEstadoD_OnSelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cmbCiudad.DataSource = consultas.MostrarMun(Convert.ToInt32(cmbEstadoD.SelectedValue));
                cmbCiudadD.DisplayMember = "Descripcion";
                cmbCiudadD.ValueMember = "MunicipioId";
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
