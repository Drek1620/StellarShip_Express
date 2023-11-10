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
        string embalaje = "", seguro = "No", Mpeligroso ="No", PaqIrreg="No";
        private void frmRegistrarEmpaque_Load(object sender, EventArgs e)
        {
            dgvPaquetes.Columns.Add("Embalaje","Embalaje");
            dgvPaquetes.Columns.Add("Largo", "Largo");
            dgvPaquetes.Columns.Add("Ancho", "Ancho");
            dgvPaquetes.Columns.Add("Peso", "Peso");
            dgvPaquetes.Columns.Add("Seguro", "Seguro");
            dgvPaquetes.Columns.Add("MPeligroso", "MPeligroso");
            dgvPaquetes.Columns.Add("PaqIrregular", "PaqIrregular");

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

            cmbEmbalaje.DisplayImagesAndText(planets);
            cmbEmbalaje.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkIrregular_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIrregular.Checked == true)
                PaqIrreg = "Si";
            else
                PaqIrreg = "No";
        }

        private void chkPeligroso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPeligroso.Checked == true)
                Mpeligroso = "Si";
            else
                Mpeligroso = "No";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            

            int indice_fila= dgvPaquetes.Rows.Add();
            DataGridViewRow fila= dgvPaquetes.Rows[indice_fila];
            
            if (cmbEmbalaje.SelectedIndex == 0)
                embalaje = "Caja";
            else if (cmbEmbalaje.SelectedIndex == 1)
                embalaje = "Sobre alcolchado";

            
            fila.Cells["Embalaje"].Value = embalaje;
            fila.Cells["Largo"].Value = txtLargo.Texts;
            fila.Cells["Ancho"].Value = txtAncho.Texts;
            fila.Cells["Peso"].Value = txtAncho.Texts;
            fila.Cells["Seguro"].Value = seguro;
            fila.Cells["MPeligroso"].Value = Mpeligroso;
            fila.Cells["PaqIrregular"].Value = PaqIrreg;
        }

        private void chkSeguro_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeguro.Checked == true)
                seguro = "Si";
            else
                seguro = "No";
        }
    }
}
