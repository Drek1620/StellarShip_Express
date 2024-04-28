using BarcodeLib;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using StellarShip_Express.RegistrarPaquete;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Win32;
using System.Windows.Controls;



namespace StellarShip_Express.Envios
{
    internal class GuiaEnvio
    {
        public static long NoEnvio { get; set; }
        public DateTime Fecha { get; set; }
        public static string RutaPDF { get; set; }
        public bool GenerarGuia()
        {
            string ruta = @"C:\GuiasEnvio\Temporal\";
            string size;

            if (Directory.Exists(ruta)) { }
            else Directory.CreateDirectory(ruta);

            System.Drawing.Image imagenCodigo;


            BarcodeLib.Barcode codigo = new BarcodeLib.Barcode();
            codigo.IncludeLabel = true;
            codigo.LabelPosition = LabelPositions.BOTTOMCENTER;

            //AQUI PASALE EL TEXTO DEL TXT  "CODIGO"
            imagenCodigo = codigo.Encode(BarcodeLib.TYPE.CODE128, NoEnvio.ToString(), Color.Black, Color.White, 500, 100);


            //EXTRA Y AL ULTIMO
            Bitmap imagenTitulo = convertirTextoImagen("Guia de Envio", 500, Color.White);

            int alto_imagen_nuevo = imagenCodigo.Height + imagenTitulo.Height;  

            //Bitmap bitmap = new Bitmap(imagenCodigo);

            //using (Graphics graphics = Graphics.FromImage(bitmap))
            //{
            //    // Dibuja la imagen en el objeto de gráficos
            //    graphics.DrawImage(imagenCodigo, 0, 0, 500,100);
            //}

            Bitmap imagenNueva = new Bitmap(500, alto_imagen_nuevo);
            Graphics dibujar = Graphics.FromImage(imagenNueva);
            
            dibujar.DrawImage(imagenTitulo, new Point(0, 0));
            dibujar.DrawImage(imagenCodigo,0 ,imagenTitulo.Height, 500,100);
            

            System.Drawing.Image imagenCodigoNuevo = imagenNueva;

            imagenCodigoNuevo.Save(@"C:\GuiasEnvio\img.png");

            for (int i = 0; i < DatosPaquete.Cantidad; i++)
            {
                ruta = @"C:\GuiasEnvio\Temporal\" + NoEnvio + $"_{i}.pdf";

                string paginahtml_texto = Properties.Resources.Plantilla_Guia.ToString();
                paginahtml_texto = paginahtml_texto.Replace("@REMITENTE", DatosCliente.Cliente[0].Nombre);
                paginahtml_texto = paginahtml_texto.Replace("@TELEFONO", DatosCliente.Cliente[0].Telefono);
                paginahtml_texto = paginahtml_texto.Replace("@CALLE", DatosCliente.Cliente[0].Direccion);
                paginahtml_texto = paginahtml_texto.Replace("@DEP", DatosCliente.Cliente[0].Nointerior);
                paginahtml_texto = paginahtml_texto.Replace("@CP", DatosCliente.Cliente[0].Cp);
                paginahtml_texto = paginahtml_texto.Replace("@MUNICIPIO", DatosCliente.Cliente[0].Ciudad);
                paginahtml_texto = paginahtml_texto.Replace("@ESTADO", DatosCliente.Cliente[0].Estado);
                paginahtml_texto = paginahtml_texto.Replace("@PAIS", DatosCliente.Cliente[0].Pais);

                paginahtml_texto = paginahtml_texto.Replace("@DESTINATARIO", DatosCliente.Cliente[1].Nombre);
                paginahtml_texto = paginahtml_texto.Replace("@Telefono", DatosCliente.Cliente[1].Telefono);
                paginahtml_texto = paginahtml_texto.Replace("@Calle", DatosCliente.Cliente[1].Direccion);
                paginahtml_texto = paginahtml_texto.Replace("@Dep", DatosCliente.Cliente[1].Nointerior);
                paginahtml_texto = paginahtml_texto.Replace("@Cp", DatosCliente.Cliente[1].Cp);
                paginahtml_texto = paginahtml_texto.Replace("@Municipio", DatosCliente.Cliente[1].Ciudad);
                paginahtml_texto = paginahtml_texto.Replace("@Estado", DatosCliente.Cliente[1].Estado);
                paginahtml_texto = paginahtml_texto.Replace("@Pais", DatosCliente.Cliente[1].Pais);

                size = DatosPaquete.Paquete[i].Largo + " x " + DatosPaquete.Paquete[i].Ancho;

                paginahtml_texto = paginahtml_texto.Replace("@PESO", DatosPaquete.Paquete[i].Peso.ToString());
                paginahtml_texto = paginahtml_texto.Replace("@FECHA", Fecha.ToString("d"));
                paginahtml_texto = paginahtml_texto.Replace("@Size", size);

                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    Document Pdfdoc = new Document(PageSize.A4, 25, 25, 25, 25);


                    PdfWriter writer = PdfWriter.GetInstance(Pdfdoc, stream);

                    Pdfdoc.Open();

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.StellarShip_Logo_Guia, ImageFormat.Png);
                    img.ScaleToFit(250, 40);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(135, Pdfdoc.Top - 40);
                    Pdfdoc.Add(img);

                    iTextSharp.text.Image img2 = iTextSharp.text.Image.GetInstance(imagenCodigoNuevo, ImageFormat.Png);
                    
                    img2.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img2.SetAbsolutePosition(25, Pdfdoc.Top - 420 );
                    img2.ScaleToFit(500, 100);
                    Pdfdoc.Add(img2);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, Pdfdoc, sr);
                    }
                    Pdfdoc.Close();
                    stream.Close();

                }
            }
            ruta = @"C:\GuiasEnvio\Temporal\";
            string path = @"C:\GuiasEnvio\" + NoEnvio + ".pdf";
            RutaPDF = path;
            CreacionPDF(path, ruta);
            Thread.Sleep(1000); 
            foreach (var item in Directory.GetFiles(ruta, "*.pdf"))
            {
                File.Delete(item);
            }

            if (Directory.Exists(ruta))
            { return true;}
            else { return false; }
            
        }

        public bool ConsultaGuia()
        {
            
            var conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Connection = connection;
                    command.CommandText = "spConsultarGuiaEnvio";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdEnvio", NoEnvio);

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet dt = new DataSet();
                    da.Fill(dt);

                    DatosPaquete.Cantidad = Convert.ToInt32(dt.Tables[0].Rows[0][0].ToString());
                    Fecha =DateTime.Parse(dt.Tables[0].Rows[0][1].ToString());

                    DatosCliente.Cliente[0] = new ArregloCliente(
                    dt.Tables[1].Rows[0][0].ToString(),
                    dt.Tables[1].Rows[0][1].ToString(),
                    dt.Tables[1].Rows[0][2].ToString(),
                    null,
                    dt.Tables[1].Rows[0][3].ToString(),
                    dt.Tables[1].Rows[0][4].ToString(),
                    dt.Tables[1].Rows[0][5].ToString(),
                    dt.Tables[1].Rows[0][6].ToString(),
                    dt.Tables[1].Rows[0][7].ToString(),
                    dt.Tables[1].Rows[0][8].ToString());
                    DatosCliente.Cliente[1] = new ArregloCliente(
                    dt.Tables[2].Rows[0][0].ToString(),
                    dt.Tables[2].Rows[0][1].ToString(),
                    dt.Tables[2].Rows[0][2].ToString(),
                    null,
                    dt.Tables[2].Rows[0][3].ToString(),
                    dt.Tables[2].Rows[0][4].ToString(),
                    dt.Tables[2].Rows[0][5].ToString(),
                    dt.Tables[2].Rows[0][6].ToString(),
                    dt.Tables[2].Rows[0][7].ToString(),
                    dt.Tables[2].Rows[0][8].ToString());

                    for (int i = 0; i < DatosPaquete.Cantidad; i++)
                    {
                        DatosPaquete.Paquete[i] = new Paquete(
                        dt.Tables[3].Rows[i][0].ToString(),
                        double.Parse(dt.Tables[3].Rows[i][1].ToString()),
                        double.Parse(dt.Tables[3].Rows[i][2].ToString()),
                        double.Parse(dt.Tables[3].Rows[i][3].ToString()),
                        dt.Tables[3].Rows[i][4].ToString(),
                        dt.Tables[3].Rows[i][5].ToString(),
                        dt.Tables[3].Rows[i][6].ToString()
                        );
                    }
                    
                }
            }
            if (GenerarGuia())
            {
                return true;
            }
            else return false;
        }

        public void CreacionPDF(string targetPDF, string sourceDir)
        {
            using (FileStream stream = new FileStream(targetPDF, FileMode.Create))
            {

                using (Document pdfDoc = new Document(PageSize.A4))
                {
                    using (PdfCopy pdf = new PdfCopy(pdfDoc, stream))
                    {

                        pdfDoc.Open();
                        PdfReader r;
                        foreach (var file in Directory.GetFiles(sourceDir, "*.pdf"))
                        {
                            r = new PdfReader(file);
                            pdf.AddDocument(r);
                            r.Close(); //Este cierra el proceso
                        }


                        if (pdfDoc != null)
                            pdfDoc.Close();
                    }
                }



            }

        }

        public static Bitmap convertirTextoImagen(string texto, int ancho, Color color)
        {
            //creamos el objeto imagen Bitmap
            Bitmap objBitmap = new Bitmap(1, 1);
            int Width = 0;
            int Height = 0;
            //formateamos la fuente (tipo de letra, tamaño)
            System.Drawing.Font objFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);

            //creamos un objeto Graphics a partir del Bitmap
            Graphics objGraphics = Graphics.FromImage(objBitmap);

            //establecemos el tamaño según la longitud del texto
            Width = ancho;
            Height = (int)objGraphics.MeasureString(texto, objFont).Height + 5;
            objBitmap = new Bitmap(objBitmap, new Size(Width, Height));

            objGraphics = Graphics.FromImage(objBitmap);

            objGraphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            objGraphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            objGraphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            objGraphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            StringFormat drawFormat = new StringFormat();
            objGraphics.Clear(color);

            drawFormat.Alignment = StringAlignment.Center;
            objGraphics.DrawString(texto, objFont, new SolidBrush(Color.Black), new RectangleF(0, (objBitmap.Height / 2) - (objBitmap.Height - 10), objBitmap.Width, objBitmap.Height), drawFormat);
            objGraphics.Flush();


            return objBitmap;
        }
    }
}
