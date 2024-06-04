using StellarShip_Express.Sucursal;
using StellarShip_Express.Vehiculos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Destino
{
    public partial class frmSucursal : Form
    {
        DataSet dsTabla = new DataSet();
        int PagInico = 1, Indice = 0, NumFilas = 16, PaginaFinal;
        public frmSucursal()
        {
            PaginaFinal = NumFilas;
            InitializeComponent();
        }
        public void MostrarSuc()
        {
            ConsultasSucursal consultas = new ConsultasSucursal();
            dgvDatos.DataSource = consultas.ListarSucursal();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosSucursal.AccionS = "Alta";
            frmRegistrarSucursal frm = new frmRegistrarSucursal();
            frm.ShowDialog();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
           
            cargarDT();
           
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDT();
           
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            DatosSucursal.AccionS = "Modifica";
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DatosSucursal.AccionS = "Modifica";
                DatosSucursal.IdDestino = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdDestino"].Value);
                DatosSucursal.NombreSuc = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                DatosSucursal.PaisS = dgvDatos.CurrentRow.Cells["Pais"].Value.ToString();
               // DatosSucursal.EstadoS = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Estado"].Value);
               // DatosSucursal.MunicipioS = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Municipio"].Value);
                DatosSucursal.CPS= dgvDatos.CurrentRow.Cells["CP"].Value.ToString();
                DatosSucursal.Calle = dgvDatos.CurrentRow.Cells["Calle"].Value.ToString();
                DatosSucursal.TelefS = dgvDatos.CurrentRow.Cells["Telefono"].Value.ToString();
                frmRegistrarSucursal frm = new frmRegistrarSucursal();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show(this, "Seleccione la fila de los datos que desea modificar.\nPor favor", "Seleccione los datos"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        ConsultasSucursal dato = new ConsultasSucursal();
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DatosSucursal.AccionS = "Baja";
            if (dgvDatos.SelectedRows.Count > 0)
            {
                DatosSucursal.IdDestino = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdDestino"].Value);
                DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar esta sucursal",
                "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    var Elimina = dato.EliminaSucursal(DatosSucursal.IdDestino);
                    if (Elimina == true)
                    {
                        MessageBox.Show(this, "Sucursal Eliminada exitosamente", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarSuc();
                    }
                    else
                        MessageBox.Show(this, "La Sucursal no existe en la base de datos", "Sucursal Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show(this, "Seleccione la fila de los datos que desea modificar.\nPor favor", "Seleccione los datos"
                , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int Pagina = Convert.ToInt32(comboBox1.Text);
            Indice = Pagina - 1;
            PagInico = (Pagina - 1) * NumFilas + 1;
            PaginaFinal = Pagina * NumFilas;
            cargarDT();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ConsultasSucursal consultas = new ConsultasSucursal();
            try
            {

                if (cmbFiltros.Texts == "IdDestino")
                {
                    dgvDatos.DataSource = consultas.BuscarIdSuc(txtBusqueda.Texts);
                }
                if (cmbFiltros.Texts == "Nombre")
                {
                    dgvDatos.DataSource = consultas.BuscarNombreSuc(txtBusqueda.Texts);
                }
                if (cmbFiltros.Texts == "Municipio")
                {
                    dgvDatos.DataSource = consultas.BuscarMunic(txtBusqueda.Texts);
                }


            }
            catch (Exception EX)
            {

                MessageBox.Show("Ha ocurrido un error: " + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        //Pag
        private void cargarDT()
        {
            DatosSucursal.inicioS = PagInico;
            DatosSucursal.finalS = PaginaFinal;

            dsTabla = dato.PagSuc(DatosSucursal.inicioS, DatosSucursal.finalS);
            dgvDatos.DataSource = dsTabla.Tables[1];

            int cantidad = Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) / NumFilas;
            if (Convert.ToInt32(dsTabla.Tables[0].Rows[0][0].ToString()) % NumFilas >= 0)
            {
                cantidad++;
            }

            textBox1.Text = cantidad.ToString();
            comboBox1.Items.Clear();

            for (int i = 1; i <= cantidad; i++)
            {
                comboBox1.Items.Add(i.ToString());
            }

            comboBox1.SelectedIndex = Indice;

        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
