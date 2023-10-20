using FontAwesome.Sharp;
using StellarShip_Express.Destino;
using StellarShip_Express.Formularios;
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
    public partial class frm_Menu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        
        public frm_Menu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 255);
        }

        public void OcultarSubMenu()
        {

            if (panAlmacen.Visible == true)
                panAlmacen.Visible = false;
            if(panPersonal.Visible==true)
                panPersonal.Visible=false;
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 52, 72);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                if (panMenu.Width == 220)
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                else
                    currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(24, 34, 48);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                pcbIconTitle.IconChar = currentBtn.IconChar;
            }

        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panInicio.Controls.Add(childForm);
            panInicio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            pcbIconTitle.IconChar = IconChar.Home;
            lblTitleChildForm.Text = "Inicio";
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
 
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Menu_Load(object sender, EventArgs e)
        {
            lblNombre.Text = DatosUsuario.Nombre + " " + DatosUsuario.PrimerApellido;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnMinum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnParcel_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panAlmacen);
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panPersonal);
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {

            OpenChildForm(new frmPersonal());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnVehicles_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            ActivateButton(sender, RGBColors.color1);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
            ActivateButton(sender, RGBColors.color1);
            OpenChildForm(new frmSucursal());
        }

        private void btnTransportista_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }
    }
}
