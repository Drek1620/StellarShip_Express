using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace StellarShip_Express.RegistrarPaquete
{
    public partial class frmConfirmarCompra : Form
    {
        Consultas consultas = new Consultas();
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
            dgvPaquetes.Rows[0].Cells["Paquetes"].Value = DatosPaquete.Caja+ " x Caja rijida\n" + DatosPaquete.Bolsa+ " x Sobre acolchado";
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            NoEnvio = DateTime.Now.ToString("ddMMyyyyHHmmss") + random.Next(1000, 9999);
			Fecha = DateTime.Today;
			long IdEnvio = Convert.ToInt64(NoEnvio);

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
            MessageBox.Show(DatosCliente.IdCliente.ToString());
            var DetalleEnvio = consultas.AgregarDetalleEnvio(
                IdEnvio,
				DatosCliente.Cliente[1].Nombre,
				DatosCliente.Cliente[1].Telefono,
				DatosCliente.Cliente[1].Direccion+","+ DatosCliente.Cliente[1].Nointerior,
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
                MessageBox.Show("Se Agrego");
            }

            if (Remitente ==true)
            {
                MessageBox.Show("Remitente ingresado exitosamente");
            }
            if (DetalleEnvio==true)
				MessageBox.Show("Envio ingresado exitosamente");
            if(Factura==true)
				MessageBox.Show("Factura ingresado exitosamente");

            btnConfirmar.Visible = false;
            btnGuia.Visible = true;
		}

		private void btnGuia_Click(object sender, EventArgs e)
		{
            ruta = @"C:\GuiasEnvio\Temporal";
            string size;

			if (Directory.Exists(ruta)) { }
			else Directory.CreateDirectory(ruta);

            for (int i = 0; i < DatosPaquete.Cantidad; i++)
            {
				path = @"C:\GuiasEnvio\Temporal\" + NoEnvio + $"_{i}.pdf";

				string paginahtml_texto = Properties.Resources.Plantilla_Guia.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@REMITENTE", DatosCliente.Cliente[0].Nombre);
                paginahtml_texto = paginahtml_texto.Replace("@TELEFONO", DatosCliente.Cliente[0].Telefono);
                paginahtml_texto = paginahtml_texto.Replace("@CALLE", DatosCliente.Cliente[0].Direccion);
                paginahtml_texto = paginahtml_texto.Replace("@DEP", DatosCliente.Cliente[0].Nointerior);
                paginahtml_texto = paginahtml_texto.Replace("@CP", DatosCliente.Cliente[0].Cp);
                paginahtml_texto = paginahtml_texto.Replace("@ESTADO", DatosCliente.Cliente[0].Estado);
                paginahtml_texto = paginahtml_texto.Replace("@PAIS", DatosCliente.Cliente[0].Pais);

                paginahtml_texto = paginahtml_texto.Replace("@DESTINATARIO", DatosCliente.Cliente[1].Nombre);
                paginahtml_texto = paginahtml_texto.Replace("@Telefono", DatosCliente.Cliente[1].Telefono);
                paginahtml_texto = paginahtml_texto.Replace("@Calle", DatosCliente.Cliente[1].Direccion);
                paginahtml_texto = paginahtml_texto.Replace("@Dep", DatosCliente.Cliente[1].Nointerior);
                paginahtml_texto = paginahtml_texto.Replace("@Cp", DatosCliente.Cliente[1].Cp);
                paginahtml_texto = paginahtml_texto.Replace("@Estado", DatosCliente.Cliente[1].Estado);
                paginahtml_texto = paginahtml_texto.Replace("@Pais", DatosCliente.Cliente[1].Pais);

                size = DatosPaquete.Paquete[i].Largo + " x " + DatosPaquete.Paquete[i].Ancho;

				paginahtml_texto = paginahtml_texto.Replace("@PESO", DatosPaquete.Paquete[i].Peso.ToString());
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", Fecha.ToString("d"));
                paginahtml_texto = paginahtml_texto.Replace("@Size",size);

                using (FileStream stream = new FileStream(path, FileMode.Create))
				{
					Document Pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);


					PdfWriter writer = PdfWriter.GetInstance(Pdfdoc, stream);

					Pdfdoc.Open();

					using (StringReader sr = new StringReader(paginahtml_texto))
					{
						XMLWorkerHelper.GetInstance().ParseXHtml(writer, Pdfdoc, sr);
					}
					Pdfdoc.Close();
					stream.Close();

				}
			}

			path = @"C:\GuiasEnvio\" + NoEnvio + ".pdf";
			CreateMergedPDF(path,ruta);
		}

		public void CreateMergedPDF(string targetPDF, string sourceDir)
		{
			using (FileStream stream = new FileStream(targetPDF, FileMode.Create))
			{
				Document pdfDoc = new Document(PageSize.A4);
				PdfCopy pdf = new PdfCopy(pdfDoc, stream);
				pdfDoc.Open();

				var files = Directory.GetFiles(sourceDir);
				foreach (string file in files)
				{
					if (file.Split('.').Last().ToUpper() == "PDF")
					{
						pdf.AddDocument(new PdfReader(file));
					}
				}
				if (pdfDoc != null)
					pdfDoc.Close();
			}
		}
	}
}
