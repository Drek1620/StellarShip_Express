using StellarShip_Express.Personal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Vehiculos
{
    public partial class frmRegistrarVehiculo : Form
    {
        Consultas dato = new Consultas();
        Consultas IDcon = new Consultas();
       
        public frmRegistrarVehiculo()
        {
            InitializeComponent();
           
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
            string conductor;

            conductor = cmbConductor.SelectedValue.ToString();

            if (DatosVehiculo.AccionV == "Alta") {

                var Alta = dato.AltaVehiculos(txtMarca.Texts, txtModelo.Texts, txtNoPlaca.Texts, txtTipo.Texts, txtYear.Texts, Convert.ToInt32(conductor));
                if (Alta == true)
                {
                    MessageBox.Show(this, "Vehiculo dado de alta exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(this, "El Vehiculo ya existe en la base de datos", "Vehiculo Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (DatosVehiculo.AccionV=="Modifica")
            {
                var Modifica = dato.ModificaVehiculos(Convert.ToInt32(txtIDMod.Text),txtMarca.Texts,txtModelo.Texts,txtNoPlaca.Texts,txtTipo.Texts,txtYear.Texts, Convert.ToInt32(conductor));
                if (Modifica == true)
                {
                    MessageBox.Show(this, "Vehiculo Modificado exitosamente", "Modificacion Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show(this, "El Vehiculo No existe en la base de datos", "Vehiculo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

       

        private void frmRegistrarVehiculo_Load(object sender, EventArgs e)
        {
            txtIDMod.ReadOnly = true;
            cmbConductor.DisplayMember = "Idusuario";
            cmbConductor.ValueMember = "Idusuario";
            cmbConductor.DataSource = IDcon.Conductores();

            if (DatosVehiculo.AccionV=="Modifica")
            {
                txtIDMod.ReadOnly = false;
                txtIDMod.Text = DatosVehiculo.IdVehiculo.ToString();
                txtMarca.Texts = DatosVehiculo.Marca;
                txtModelo.Texts=DatosVehiculo.Modelo;
                txtNoPlaca.Texts = DatosVehiculo.NoPlaca;
                txtTipo.Texts = DatosVehiculo.TipoVehiculo;
                txtYear.Texts = DatosVehiculo.Año;
                lblTitulo.Text = "Modificar Vehiculo";
               
            }


        }

        private void cmbConductor_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNoPlaca__TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
