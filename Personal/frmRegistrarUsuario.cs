using Microsoft.Win32;
using StellarShip_Express.Personal;
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
        public string path;
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
            if (DatosModifPersonal.Accion == "Alta")
            {
                tgbCambiar.Visible = false;lblCambiar.Visible=false;
                txtPass.Visible = true; txtCPass.Visible = true;
                label6.Visible = true; label7.Visible = true;
            }
            else
            {
                tgbCambiar.Visible = true; lblCambiar.Visible = true;
                txtId.Text = DatosModifPersonal.IdUser.ToString();
                txtLoginName.Texts = DatosModifPersonal.LoginNombre;
                txtName.Texts = DatosModifPersonal.Nombre;
                txtPApellido.Texts = DatosModifPersonal.PrimerApellido;
                txtSApellido.Texts = DatosModifPersonal.SegundoApellido;
                txtTel.Texts = DatosModifPersonal.Telefono.ToString(); 
                cmbAcces.SelectedIndex = Convert.ToInt32(DatosModifPersonal.Acceso) - 1;
                try
                {; //Aqui cargo la imagen al pcb
                    using (Bitmap bmp = new Bitmap(@""+DatosModifPersonal.Foto))
                    {
                        MemoryStream ms = new MemoryStream();
                        bmp.Save(ms,ImageFormat.Bmp);
                        pcbImgUser.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception)
                {

                    return;
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            string acces;
            acces = cmbAcces.SelectedValue.ToString();
            string FilePath = @"C:\imgUsuarios\" + txtLoginName.Texts + ".jpg";
            string ruta = FilePath;

            if (txtLoginName.Texts != "" && txtName.Texts != "" && txtPApellido.Texts != "" && txtSApellido.Texts != "" && txtTel.Texts != "")
            {
                if (DatosModifPersonal.Accion== "Alta")
                {
                    if (txtPass.Texts.Length >5)
                    {
                        if (txtPass.Texts == txtCPass.Texts)
                        {

                            var Alta = dato.AltaUsuario(
                                    txtLoginName.Texts,
                                    txtName.Texts,
                                    txtPApellido.Texts,
                                    txtSApellido.Texts,
                                    txtPass.Texts,
                                    acces,
                                    Convert.ToInt64(txtTel.Texts),
                                    ruta
                                    );
                            if (Alta == true)
                            {
                                pcbImgUser.Image.Save(FilePath, ImageFormat.Jpeg);
                                MessageBox.Show(this, "Usuario dado de alta exitosamente", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information); Limpiar();
                            }
                            else MessageBox.Show(this, "El Usuario ya existe en la base de datos", "Usuario Existente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else MessageBox.Show(this, "Contraseñas no identicas. Compruebe que sean iguales", "Contraseña no identicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else MessageBox.Show(this, "La contraseña es demasiado corta, intente agregar mas caracteres.", "Contraseña demasiado corta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (tgbCambiar.Checked==true)
                    {
                        if (txtPass.Texts == txtCPass.Texts)
                        {

                            var Modifica = dato.ModificaUsuario(
                                    Convert.ToInt32(txtId.Text),
                                    txtLoginName.Texts,
                                    txtName.Texts,
                                    txtPApellido.Texts,
                                    txtSApellido.Texts,
                                    txtPass.Texts,
                                    acces,
                                    Convert.ToInt64(txtTel.Texts),
                                    ruta
                                    );
                            if (Modifica == true)
                            {
                                pcbImgUser.Image.Save(FilePath, ImageFormat.Jpeg); //Aqui guardo la nueva imagen al modificar
                                MessageBox.Show(this, "Usuario modificado exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show(this, "El Usuario no se ha podido modificar. Compruebe los datos", "Modificación no Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else MessageBox.Show(this, "Este nombre de login, ya esta registrado.\nPorfavor intenta con otro", "Contraseña no identicas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        var Modifica = dato.ModificaUsuario(
                                    Convert.ToInt32(txtId.Text),
                                    txtLoginName.Texts,
                                    txtName.Texts,
                                    txtPApellido.Texts,
                                    txtSApellido.Texts,
                                    DatosModifPersonal.Contraseña,
                                    acces,
                                    Convert.ToInt64(txtTel.Texts),
                                    ruta
                                    );
                        if (Modifica == true)
                        {
                            //File.Delete(FilePath);
                            pcbImgUser.Image.Save(FilePath, ImageFormat.Jpeg); //Aqui guardo la nueva imagen al modificar
                            MessageBox.Show(this, "Usuario modificado exitosamente", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }  
                        else MessageBox.Show(this, "Este nombre de login, ya esta registrado.\nPorfavor intenta con otro", "Modificación no Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                
            }
            else MessageBox.Show(this, "Ingrese todos los datos. Por favor", "Ingrese todos los datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

           
        }

        public void Limpiar()
        {
            txtLoginName.Texts = "";
            txtName.Texts = "";
            txtPApellido.Texts = "";
            txtSApellido.Texts = "";
            txtPass.Texts = "";
            txtCPass.Texts = "";
            txtTel.Texts = "";
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

        private void tgbCambiar_CheckedChanged(object sender, EventArgs e)
        {
            if (tgbCambiar.Checked==true)
            {
                txtPass.Visible = true; txtCPass.Visible = true;
                label6.Visible = true; label7.Visible= true;
            }
            else
            {
                txtPass.Visible = false; txtCPass.Visible = false;
                label6.Visible = false; label7.Visible = false;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            ofdSeleccionar.Filter = "Imagenes| *.jpg";
            if (ofdSeleccionar.ShowDialog()== DialogResult.OK)
            {
                pcbImgUser.Image = Image.FromFile(ofdSeleccionar.FileName);
            }
        }
    }
}
