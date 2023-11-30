using StellarShip_Express.Envios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express
{
    public partial class CuadroPaquete : UserControl
    {
		private long id = 0;
		private string status = "";
		public CuadroPaquete()
        {
            InitializeComponent();
			try
			{
				pictureBox1.Image = StellarShip_Express.Properties.Resources.Parcel_box;
			}
			catch (Exception)
			{

				return;
			}
			
        }

        public long Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Guia
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }

		public string Recibe
		{
			get { return label3.Text; }
			set { label3.Text = value; }
		}

		public string Destino
		{
			get { return label5.Text; }
			set { label5.Text = value; }
		}

		public string Estatus
		{
			get { return label7.Text; }
			set { label7.Text = value; }
		}

		public string Detalles
		{
			get { return label9.Text; }
			set { label9.Text = value; }
		}
		ConsultaPaquetes obj = new ConsultaPaquetes();
		private void btnCambiar_Click(object sender, EventArgs e)
		{
			

			var editar = obj.CambiarEstatus(this.Id,
				cmbEstatus.Text);
		}

		private void btnEntregado_Click(object sender, EventArgs e)
		{
			var editar = obj.CambiarEstatus(this.Id,
				"Entregado");
		}
	}
}
