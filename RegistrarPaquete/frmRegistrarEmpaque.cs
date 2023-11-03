using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.RegistrarPaquete
{
    public partial class frmRegistrarEmpaque : Form
    {
        public frmRegistrarEmpaque()
        {
            InitializeComponent();
        }

        private void frmRegistrarEmpaque_Load(object sender, EventArgs e)
        {
            label1.Focus();
            Font font = new Font("Microsoft Sans Serif", 14);

            // Make image and text data.
            ImageAndText[] planets =
            {
                new ImageAndText(Properties.Resources.Parcel,
                    "Caja o embalaje rígido" + '\n' +
                    "Cualquier caja personalizada o paquete grueso" + '\n',
                    font),
                new ImageAndText(Properties.Resources.SoftEnvelope,
                    "Sobre, sobre acolchado, bolsa de polietileno, paquete blando o caja en una bolsa" + '\n' +
                    "Mida y use la longitud y el ancho del sobre antes de poner cualquier cosa en él" + '\n',
                    font),
            };

            cboPlanets.DisplayImagesAndText(planets);
            cboPlanets.SelectedIndex = 0;
        }
    }
}
