using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data.Types;
using MySql.Data;
using MySql.Data.MySqlClient;
using StellarShip_Express.Otros;
using System.Windows.Media.Animation;

namespace StellarShip_Express.Otros
{
	public partial class frmClientes : Form
	{

        PaginadoClientes objp = new PaginadoClientes();
        DataSet dsTabla; 
        public int pagInicio = 1, Indice = 0, Numfilas = 32, Pagfinal;

        public frmClientes()
        {
            InitializeComponent();
            Pagfinal = Numfilas;
            CargarDG(); //se lo dejo pero creo que no es necesario

        }

        void CargarDG()
        {
            objp.inicio1 = pagInicio;
            objp.final1 = Pagfinal;
            dsTabla = objp.PaginadoClientes_();
            dgvDatos.DataSource = dsTabla.Tables[1];

            int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / Numfilas;

            if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % Numfilas > 0) cantidad++;
            txtNumPag.Text = cantidad.ToString();
            cmbNumPag.Items.Clear();

            for (int x = 1; x <= cantidad; x++) cmbNumPag.Items.Add(x.ToString());

            cmbNumPag.SelectedIndex = Indice;

            
        }

        //public void MostrarClientes()
        //{

        //    Consultas consultas = new Consultas();
        //    dgvDatos.DataSource = consultas.MostrarClientes();
        //}

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //puto el que lo lea
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ConsultasClientes consultas = new ConsultasClientes();
            string opcionSeleccionada = cmbFiltros.Texts;

            if (opcionSeleccionada == "ID")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteI(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "Nombre")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteN(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "Ciudad")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteC(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "Estado")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteE(txtBusqueda.Text);
            }
            else if (opcionSeleccionada == "País")
            {
                dgvDatos.DataSource = consultas.MostrarBusquedaClienteP(txtBusqueda.Text);
            }
        }

        private void cmbFiltros_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            //puro coco
        }

        private void cmbNumPag_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int pagina = Convert.ToInt32(cmbNumPag.Text);
            Indice = pagina - 1;
            pagInicio = (pagina - 1) * Numfilas + 1;
            Pagfinal = pagina * Numfilas;
            CargarDG();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Pagfinal = Numfilas;
            CargarDG();
        }

		private void frmClientes_Load_1(object sender, EventArgs e)
		{
            Pagfinal = Numfilas;
            CargarDG();
        }

        private void cmbNumPag_SelectedIndexChanged(object sender, EventArgs e)
        {
            //este no era jeje
        }
    }
}
