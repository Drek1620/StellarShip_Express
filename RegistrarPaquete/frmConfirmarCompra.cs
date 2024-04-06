using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

using BarcodeLib;
using StellarShip_Express.Envios;

namespace StellarShip_Express.RegistrarPaquete
{
    public partial class frmConfirmarCompra : Form
    {
        Consultas consultas = new Consultas();
        GuiaEnvio guiaEnvio = new GuiaEnvio();
        GenerarFactura generarFactura = new GenerarFactura();
        private string NoEnvio;
        private string path;
        private string ruta;
        private DateTime Fecha;
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

			if (Convert.ToInt32(DatosPaquete.Caja) > 0)
				dgvPaquetes.Rows[0].Cells["Paquetes"].Value = DatosPaquete.Caja + " x Caja rijida\n";
            if (Convert.ToInt32(DatosPaquete.Bolsa) > 0)
                dgvPaquetes.Rows[0].Cells["Paquetes"].Value = dgvPaquetes.Rows[0].Cells["Paquetes"].Value + DatosPaquete.Bolsa + " x Sobre acolchado";

            dgvPaquetes.Rows[0].Cells["Servicios extras"].Value = CalcularPrecios.Servicios.ToString();



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
            lblDireccionD.Text = DatosCliente.Cliente[1].Direccion + ", " + DatosCliente.Cliente[1].Nointerior;
            lblCpD.Text = DatosCliente.Cliente[1].Cp + ", " + DatosCliente.Cliente[1].Ciudad + ", " + DatosCliente.Cliente[1].Estado;
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
			if (MessageBox.Show("¿Quieres cerrar la ventana de compra?", "Advertencia",
		   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				DialogResult = DialogResult.OK;

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            NoEnvio = DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
			
			Fecha = DateTime.Today;
			long IdEnvio = Convert.ToInt64(NoEnvio);

            GuiaEnvio.NoEnvio = IdEnvio;
			guiaEnvio.Fecha = Fecha;

            var Remitente = consultas.AgregarRemitente(
				DatosCliente.Cliente[0].Nombre,
				DatosCliente.Cliente[0].Telefono,
				DatosCliente.Cliente[0].Correo,
				DatosCliente.Cliente[0].Direccion,
				DatosCliente.Cliente[0].Nointerior,
				DatosCliente.Cliente[0].Cp,
				DatosCliente.Cliente[0].Ciudad,
				DatosCliente.Cliente[0].Estado,
				DatosCliente.Cliente[0].Pais
				);
            var DetalleEnvio = consultas.AgregarDetalleEnvio(
                IdEnvio,
				DatosCliente.Cliente[1].Nombre,
				DatosCliente.Cliente[1].Telefono,
                DatosCliente.Cliente[1].Correo,
                DatosCliente.Cliente[1].Direccion+","+ DatosCliente.Cliente[1].Nointerior,
				DatosCliente.Cliente[1].Nointerior,
				DatosCliente.Cliente[1].Cp,
				DatosCliente.Cliente[1].Ciudad,
				DatosCliente.Cliente[1].Estado,
				DatosCliente.Cliente[1].Pais,
                "Ingreso a la sucursal de origen"
				);
            var Factura = consultas.AgregarFactura(
                DatosUsuario.Sucursal,
                IdEnvio
                );
            for (int i = 0; i < DatosPaquete.Cantidad; i++)
            {
                consultas.AgregarPaquete(
                    IdEnvio,
                    DatosPaquete.Paquete[i].Embalaje,
                    DatosPaquete.Paquete[i].Largo,
                    DatosPaquete.Paquete[i].Ancho,
                    DatosPaquete.Paquete[i].Peso,
                    DatosPaquete.Paquete[i].Seguro,
                    DatosPaquete.Paquete[i].Mpeligroso,
                    DatosPaquete.Paquete[i].Pirregular
                    );
            }
            generarFactura.Fecha = Fecha;
            btnConfirmar.Visible = false;
            btnGuia.Visible = true;


            if (generarFactura.GenerarPDF())
            {
                MessageBox.Show("Factura generada");
            }
            else
            {
                MessageBox.Show("Error al generar la factura");
            }

            if (guiaEnvio.GenerarGuia())
			{
                MessageBox.Show("Guia de envio generada");
            }
			else
			{
                MessageBox.Show("Error al generar la guia de envio");
            }

        }

		private void btnGuia_Click(object sender, EventArgs e)
		{
           
		}
	
	}
	
}
