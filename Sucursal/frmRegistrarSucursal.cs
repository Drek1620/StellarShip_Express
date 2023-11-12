using StellarShip_Express.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Destino
{
    public partial class frmRegistrarSucursal : Form
    {
        Consultas dato = new Consultas();
        public frmRegistrarSucursal()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void RealeaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panTitle_MouseDown(object sender, MouseEventArgs e)
        {
            RealeaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmRegistrarSucursal_Load(object sender, EventArgs e)
        {
            txtIdSuc.ReadOnly = true;
            if (DatosSucursal.AccionS == "Modifica")
            {
                txtIdSuc.ReadOnly = false;
                txtIdSuc.Text = DatosSucursal.IdDestino.ToString();
                //DatosSucursal.IDModifiS = DatosSucursal.IdDestino;
                txtNombreSuc.Texts = DatosSucursal.NombreSuc;
                txtPais.Texts = DatosSucursal.PaisS;
                txtEstado.Texts = DatosSucursal.EstadoS;
                txtMunicipio.Texts = DatosSucursal.MunicipioS;
                txtCP.Texts = DatosSucursal.CPS;
                txtTel.Texts = DatosSucursal.TelefS;
                lblTitulo.Text = "Modificar Sucursal";

            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (DatosSucursal.AccionS == "Alta")
            {

                var Alta = dato.AgregarSucursal(txtNombreSuc.Texts, txtPais.Texts, txtEstado.Texts, txtMunicipio.Texts, txtCP.Texts, txtTel.Texts);
                if (Alta == true)
                {
                    MessageBox.Show(this, "Sucursal agregada exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(this, "La sucursal ya existe en la base de datos", "Sucursal Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            if (DatosSucursal.AccionS == "Modifica")
            {

                var Modifica = dato.ModificarSucursal(
                    Convert.ToInt32(txtIdSuc.Text),
                    txtNombreSuc.Texts, txtPais.Texts, txtEstado.Texts, txtMunicipio.Texts, txtCP.Texts, txtTel.Texts);
                if (Modifica == true)
                {
                    MessageBox.Show(this, "Sucursal Modificada exitosamente", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show(this, "La sucursal no existe en la base de datos", "Sucursal Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
