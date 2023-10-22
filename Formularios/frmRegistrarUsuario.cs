using Microsoft.Win32;
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

namespace StellarShip_Express.Formularios
{
    public partial class frmRegistrarUsuario : Form
    {
        public string ruta, path;
        Consultas dato=new Consultas();
        public frmRegistrarUsuario()
        {
            InitializeComponent();
        }

        public void ListarPuestos()
        {
            Consultas objPuesto= new Consultas();
            cmbAcces.DataSource = objPuesto.MostrarPuestos();
            cmbAcces.DisplayMember = "Puesto";
            cmbAcces.ValueMember = "IdPuesto";
        }
        private void frmRegistrarUsuario_Load(object sender, EventArgs e)
        {
            ListarPuestos();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string acces;
            path = @"C:\imgUsuarios";
            if (Directory.Exists(path))
            {
                string FilePath = @"C:\imgUsuarios\" + txtLoginName.Texts + ".jpg";
                pcbImgUser.Image.Save(FilePath, ImageFormat.Jpeg);
                ruta = FilePath;
            }
            else
            {
                Directory.CreateDirectory(path);
                string FilePath = @"C:\imgUsuarios\" + txtLoginName.Texts + ".jpg";
                pcbImgUser.Image.Save(FilePath, ImageFormat.Jpeg);
                ruta = FilePath;
            }
            acces= cmbAcces.SelectedValue.ToString();
            dato.AltaUsuario(
                txtLoginName.Texts,
                txtName.Texts,
                txtSurname.Texts,
                txtSeSurname.Texts,
                txtPass.Texts,
                acces,
                Convert.ToInt64(txtTel.Texts),
                ruta
                );
            
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

        private void rButton3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                pcbImgUser.Image = Image.FromFile(ruta);
                this.ruta = openFileDialog1.FileName;
            }
        }
    }
}
