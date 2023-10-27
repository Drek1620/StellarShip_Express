using AForge.Video;
using AForge.Video.DirectShow;
using StellarShip_Express.Formularios;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Personal
{
    public partial class frmTomarFoto : Form
    {
        public frmTomarFoto()
        {
            InitializeComponent();
        }
        private FilterInfoCollection DispocitivosVideo;//lista de dispocitivos
        private VideoCaptureDevice FuenteVideo;//dispocitivo seleccionado para fuente de video
        bool existeDis;
        private void frmTomarFoto_Load(object sender, EventArgs e)
        {
            BuscaDispocitivosVideo();

            if (existeDis == true)
            {
                TerminarFvideo();
                int i = cboDispocitivos.SelectedIndex;
                string NombreVideo = DispocitivosVideo[i].MonikerString;
                FuenteVideo = new VideoCaptureDevice(NombreVideo);
                FuenteVideo.NewFrame += new NewFrameEventHandler(videoNewFrameCapturado);
                FuenteVideo.Start();

            }
            else
            {
                MessageBox.Show("No hay camaras Disponibles");
            }

        }

        private void videoNewFrameCapturado(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap imagen = (Bitmap)eventArgs.Frame.Clone();
            pcbCamara.Image = imagen;
        }

        public void BuscaDispocitivosVideo()
        {
            DispocitivosVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispocitivosVideo.Count == 0)
            {
                existeDis = false;
            }
            else
            {
                existeDis = true;
                cargarDispocitovos(DispocitivosVideo);
            }

        }

        void cargarDispocitovos(FilterInfoCollection Dispocitivos)
        {
            for (int i = 0; i < Dispocitivos.Count; i++)
            {
                cboDispocitivos.Items.Add(Dispocitivos[i].Name.ToString());
            }
            cboDispocitivos.Text = cboDispocitivos.Items[0].ToString();
            
        }

        void TerminarFvideo()
        {
            if (!(FuenteVideo == null))
            {
                if (FuenteVideo.IsRunning)
                {
                    FuenteVideo.SignalToStop();
                    FuenteVideo.Stop();
                    FuenteVideo = null;
                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TerminarFvideo();
            this.Close();
        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {

            if (!(FuenteVideo == null))
            { 
                if (FuenteVideo.IsRunning)
                {
                    ImagenTomada.Foto = (Bitmap)pcbCamara.Image.Clone();

                }
            }
            TerminarFvideo();
            DialogResult = DialogResult.OK;
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
    }
}
