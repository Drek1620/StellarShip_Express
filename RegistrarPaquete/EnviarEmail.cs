using StellarShip_Express.Envios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.RegistrarPaquete
{
    internal class EnviarEmail
    {
        private string myEmail = "stellarshipexpress@gmail.com";
        private string myPassword = "edzx rrnp sckx ndoo";
        private string myAlias = "StellarShip Express";
        private MailMessage mCorreo;
        private string[] myAdjuntos;

        public void AdjuntarArchivos()
        {
            myAdjuntos[1] = GuiaEnvio.RutaPDF;
            myAdjuntos[2] = GenerarFactura.Ruta;
        }

        public void CrearCorreoRemitente()
        {
            mCorreo = new MailMessage();
            mCorreo.From = new MailAddress(myEmail, myAlias, System.Text.Encoding.UTF8);
            mCorreo.To.Add(DatosCliente.Cliente[0].Correo.Trim());
            mCorreo.Subject = "Confirmación de Envío de Su Paquete";
            mCorreo.Body = "<h1>Ha comenzado el envío de tu paquete.</h1>" +
                "<h2>Numero de envió: "+GuiaEnvio.NoEnvio+"</h2> " +
                "<h2>Puede rastrear su envio en: http://stellarship.somee.com/</h2>";
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.Normal;

            mCorreo.Attachments.Add(new Attachment(GuiaEnvio.RutaPDF));
            mCorreo.Attachments.Add(new Attachment(GenerarFactura.Ruta));

            Enviar();
        }

        public void CrearCorreoDestinatario()
        {
            mCorreo = new MailMessage();
            mCorreo.From = new MailAddress(myEmail, myAlias, System.Text.Encoding.UTF8);
            mCorreo.To.Add(DatosCliente.Cliente[1].Correo.Trim());
            mCorreo.Subject = "Confirmación de Envío de Su Paquete";
            mCorreo.Body = "<h1>Ha comenzado el envío de tu paquete.</h1>" +
                "<h2>Numero de envió: "+ GuiaEnvio.NoEnvio+"</h2> " +
                "<h2>Puede rastrear su envio en: http://stellarship.somee.com/</h2>";
            mCorreo.IsBodyHtml = true;
            mCorreo.Priority = MailPriority.Normal;


            Enviar();
        }

        private void Enviar()
        {
            SmtpClient smtp = new SmtpClient();
            smtp.UseDefaultCredentials = true;
            smtp.Port = 25;
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential(myEmail, myPassword);
            ServicePointManager.ServerCertificateValidationCallback = delegate(object s, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors) { return true; };
            smtp.EnableSsl = true;
            smtp.Send(mCorreo);
        }
    }
}
