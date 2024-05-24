using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StellarShip_Express.Otros
{
    public partial class frmFactura : Form
    {


        PaginadoFactura objp = new PaginadoFactura();
        DataSet dsTabla;
        public int pagInicio = 1, Indice = 0, Numfilas = 32, Pagfinal;
        public frmFactura()
        {
            InitializeComponent();
            
        }

        void CargaDG()
        {
            objp.Inicio = pagInicio;
            objp.Final = Pagfinal;
            dsTabla = objp.PaginadoFac_();
            dgvDatos.DataSource = dsTabla.Tables[1];

            int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / Numfilas;
            cmbNumPag.Items.Clear();

            if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) %  Numfilas > 0)
            {
                cantidad++;
            }

            txtNumPag.Text = cantidad.ToString();
            cmbNumPag.Items.Clear();

            for (int x = 1; x <= cantidad; x++)  
            {
                cmbNumPag.Items.Add(x.ToString());
                
            }

            cmbNumPag.SelectedIndex = Indice;

        }

		private void frmFactura_Load(object sender, EventArgs e)
		{
            Pagfinal = Numfilas;
            CargaDG();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //culoEnorme
        }

        private void cmbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
		{
            ConsultasFactura consultas = new ConsultasFactura();
            string opcionSeleccionada = cmbFiltros.Texts;




            if (opcionSeleccionada == "NoFactura")
            {
                dgvDatos.DataSource = consultas.NoFactura(rjTextBox1.Texts);

            }

            else if (opcionSeleccionada == "ID Cliente")
            {

                dgvDatos.DataSource = consultas.IdCliente(rjTextBox1.Texts);
            }

            else if (opcionSeleccionada == "Sucursal")
            {
                dgvDatos.DataSource = consultas.Sucursal(rjTextBox1.Texts);

            }

            else if (opcionSeleccionada == "Fecha")
            {
                
                dgvDatos.DataSource = consultas.BuscFecha(dateTimePicker1.Value, dateTimePicker2.Value);

            }

        }

        private void cmbNumPag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbNumPag.Text);
            Indice = pagina - 1;
            pagInicio = (pagina - 1) * Numfilas + 1;
            Pagfinal = pagina * Numfilas;
            CargaDG();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
		{
            CargaDG();
		}
    }
}
