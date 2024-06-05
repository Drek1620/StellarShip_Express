using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using StellarShip_Express.Envios;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlX.XDevAPI.Relational;

namespace StellarShip_Express.RegistrarPaquete
{
    internal class GenerarFactura
    {
        public static long NoFactura { get; set; }
        public DateTime Fecha { get; set; }
        public static string Ruta { get; set; }
        public bool GenerarPDF()
        {
            Ruta = @"C:\Facturas\"+ NoFactura +".pdf"; 
            //string PaginaHTML_Texto = "<table border=\"1\"><tr><td>HOLA MUNDO</td></tr></table>";
            string PaginaHTML_Texto = Properties.Resources.Factura.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DIRECCION", SucursalTrabajo.Nombre + " " + 
                SucursalTrabajo.Calle + " " + SucursalTrabajo.CP);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TELEFONO", SucursalTrabajo.Telefono);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FACTURA", NoFactura.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", DatosCliente.Cliente[0].Nombre.ToUpper());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DOCUMENTO", GuiaEnvio.NoEnvio.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", Fecha.ToString("d"));

            string filas = string.Empty;
            decimal total = 0;

            for (int i = 0; i < 2; i++)
            {
                if (DatosFactura.Factura[i].Cantidad > 0)
                {
                    filas += "<tr>";
                    filas += "<td>" + DatosFactura.Factura[i].Cantidad + "</td>";
                    filas += "<td>" + DatosFactura.Factura[i].Descripcion + "</td>";
                    filas += "<td>" + DatosFactura.Factura[i].Unitario + "</td>";
                    filas += "<td>" + DatosFactura.Factura[i].Extras + "</td>";
                    filas += "<td>" + DatosFactura.Factura[i].Importe + "</td>";
                    filas += "</tr>";
                }
                
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUB", CalcularPrecios.Subtotal.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@IVA", CalcularPrecios.Iva.ToString());
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", CalcularPrecios.Total.ToString());

            using (FileStream stream = new FileStream(Ruta, FileMode.Create))
            {
                //Creamos un nuevo documento y lo definimos como PDF
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                //Agregamos la imagen del banner al documento
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.StellarShip_Logo_Guia, System.Drawing.Imaging.ImageFormat.Png);
                img.ScaleToFit(250, 40);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;

                //img.SetAbsolutePosition(10,100);
                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 40);
                pdfDoc.Add(img);


                //pdfDoc.Add(new Phrase("Hola Mundo"));
                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
            }


            return true;
        }
    }
}
