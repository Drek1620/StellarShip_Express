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
using PdfiumViewer;

namespace StellarShip_Express.Imprimir
{
    public partial class frmImprimirPDF : Form
    {
        public frmImprimirPDF()
        {
            InitializeComponent();
            MostrarPDF();
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

        public void MostrarPDF()
        {
     
            PdfDocument pdf = PdfDocument.Load(RutasPDF.RutaPDF);
            pdfViewer1.Document = pdf;
            pdfViewer1.ZoomMode = PdfViewerZoomMode.FitWidth;
        }
    }
}
