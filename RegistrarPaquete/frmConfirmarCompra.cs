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
            DateTime dateTime = DateTime.Today;
            dgvPaquetes.Columns.Add("Cantidad", "Cantidad");
            dgvPaquetes.Columns.Add("Paquetes", "Paquetes");
            dgvPaquetes.Columns.Add("Servicios extras", "Servicios extras");

            CalcularPrecios precios = new CalcularPrecios();
            precios.Calcular();
            lblSubtotal.Text = CalcularPrecios.Subtotal.ToString();
            lblTotal.Text = CalcularPrecios.Total.ToString();

            dgvPaquetes.Rows[0].Cells["Cantidad"].Value = DatosPaquete.Cantidad;
            dgvPaquetes.Rows[0].Cells["Paquetes"].Value = DatosPaquete.Caja+ " x Caja rijida\n" + DatosPaquete.Bolsa+ " x Sobre acolchado";
            dgvPaquetes.Rows[0].Cells["Servicios extras"].Value = CalcularPrecios.Servicios.ToString();


            string datos= DatosPaquete.Paquete[0].Embalaje;
            lblCliente.Text = DatosCliente.Cliente[0].Nombre;
            lblCorreo.Text = DatosCliente.Cliente[0].Correo;
            lblTel.Text = DatosCliente.Cliente[0].Telefono;
            lblFecha.Text = dateTime.ToString("g");
            lblDirreccion.Text = DatosCliente.Cliente[0].Direccion + ", " + DatosCliente.Cliente[0].Nointerior;
            lblCp.Text = DatosCliente.Cliente[0].Cp + ", " + DatosCliente.Cliente[0].Ciudad + ", " + DatosCliente.Cliente[0].Estado;
            lblPais.Text = DatosCliente.Cliente[0].Pais;

            lblDestinatario.Text = DatosCliente.Cliente[1].Nombre;
            lblEmpresaD.Text =DatosCliente.Cliente[1].Empresa;
            lblCorreoD.Text = DatosCliente.Cliente[1].Correo;
            lblTelD.Text = DatosCliente.Cliente[1].Telefono;
            lblDireccionD.Text = DatosCliente.Cliente[1].Direccion + ", " + DatosCliente.Cliente[0].Nointerior;
            lblCpD.Text = DatosCliente.Cliente[1].Cp + ", " + DatosCliente.Cliente[0].Ciudad + ", " + DatosCliente.Cliente[0].Estado;
            lblPaisD.Text = DatosCliente.Cliente[1].Pais;

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
    }
}
