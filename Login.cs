using AForge.Imaging.Filters;
using FontAwesome.Sharp;
using StellarShip_Express.Encriptacion;
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

namespace StellarShip_Express
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtUser.Texts != "")
            {
                if (txtPass.Texts != "")
                {
                    InicioSesion inicio = new InicioSesion();
                    var validLogin = inicio.Login(txtUser.Texts, Encrypt.GetSHA256( txtPass.Texts));
                    if (validLogin == true)
                    {
                        frm_Menu f1 = new frm_Menu();
                        f1.Show();
                        f1.FormClosed += Logout;
                        this.Hide();
                        

                    }
                    else
                    {
                        lblError.Text = " Contraseña o Usuario Incorrecto. \n   Porfavor intenta otra vez."; lblError.Visible = true;
                    }
                }
                else lblError.Text = " Contraseña Incorrecta"; lblError.Visible = true;
            }
            else lblError.Text = " Usuario Incorrecto"; lblError.Visible = true;
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            frmConexion frm= new frmConexion();
            if (frm.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("Conexion establecida a: " + TipoConexion.Conexion);
            }
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtPass.Texts = "";
            txtUser.Texts = "";
            txtUser.Focus();
            lblError.Visible=false;
            this.Show();
        }

		private void btnMostrar_Click(object sender, EventArgs e)
		{
            if (txtPass.PasswordChar == false)
            {
				txtPass.PasswordChar = true;
				btnMostrar.IconChar = IconChar.Eye;
				
			}
            else
            {
				if (txtPass.PasswordChar == true)
				{
					txtPass.PasswordChar = false;
					btnMostrar.IconChar = IconChar.EyeSlash;
				}
			}
            
            
		}
	}
}
