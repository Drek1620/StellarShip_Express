using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Vehiculos
{
    public partial class frmVehiculos : Form
    {
        DataSet dsTabla = new DataSet();
        int PagInico = 1, Indice = 0, NumFilas = 10, PaginaFinal;
        public frmVehiculos()
        {
            PaginaFinal = NumFilas;
            InitializeComponent();
        }
        public void MostrarVehiculos()
        {
            ConsultasVehiculo consultas = new ConsultasVehiculo();
            dgvDatos.DataSource = consultas.MostrarVehiculos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosVehiculo.AccionV = "Alta";
            frmRegistrarVehiculo frm = new frmRegistrarVehiculo();
            frm.ShowDialog();          
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosVehiculo.AccionV = "Modifica";
                if (dgvDatos.SelectedRows.Count > 0)
                {
                    DatosVehiculo.AccionV = "Modifica";
                    DatosVehiculo.IdVehiculo = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdVehiculo"].Value);
                    DatosVehiculo.Marca = dgvDatos.CurrentRow.Cells["Marca"].Value.ToString();
                    DatosVehiculo.Modelo = dgvDatos.CurrentRow.Cells["Modelo"].Value.ToString();
                    DatosVehiculo.NoPlaca = dgvDatos.CurrentRow.Cells["NoPlaca"].Value.ToString();
                    DatosVehiculo.TipoVehiculo = dgvDatos.CurrentRow.Cells["TipoVehiculo"].Value.ToString();
                    DatosVehiculo.Año = dgvDatos.CurrentRow.Cells["Año"].Value.ToString();
                    DatosVehiculo.IdTransportista = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdTransportista"].Value);
                    frmRegistrarVehiculo frm = new frmRegistrarVehiculo();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show(this, "Seleccione la fila de los datos que desea modificar.\nPor favor", "Seleccione los datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show("Ha ocurrido un error: " + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        

        }

        ConsultasVehiculo dato = new ConsultasVehiculo(); 
        
        
        //PAGINACION
        private void cargarDT() 
        {
            DatosVehiculo.inicio = PagInico;
            DatosVehiculo.final = PaginaFinal;

            dsTabla = dato.ListarVehiculos(DatosVehiculo.inicio, DatosVehiculo.final);
            dgvDatos.DataSource= dsTabla.Tables[1];

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

   
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DatosVehiculo.AccionV = "Baja";
                if (dgvDatos.SelectedRows.Count > 0)
                {
                    DatosVehiculo.IdVehiculo = Convert.ToInt32(dgvDatos.CurrentRow.Cells["IdVehiculo"].Value);
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este vehiculo?",
                    "Confirmar acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        var Elimina = dato.EliminaVehiculos(DatosVehiculo.IdVehiculo);
                        if (Elimina == true)
                        {
                            MessageBox.Show(this, "Vehiculo Eliminado exitosamente", "Eliminacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show(this, "El Vehiculo No existe en la base de datos", "Vehiculo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show(this, "Seleccione la fila de los datos que desea modificar.\nPor favor", "Seleccione los datos"
                    , MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception EX)
            {

                MessageBox.Show("Ha ocurrido un error: " + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarDT();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)//PARA LA PAGINACION
        {
            int Pagina = Convert.ToInt32(comboBox1.Text);
            Indice = Pagina - 1;
            PagInico = (Pagina - 1) * NumFilas + 1;
            PaginaFinal=Pagina*NumFilas;
            cargarDT();
        }

        private void frmVehiculos_Load(object sender, EventArgs e)
        {
            cargarDT(); //metodo para mostrar dg de paginacion 
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //boton busqueda 
        private void iconButton1_Click(object sender, EventArgs e)
        {
            ConsultasVehiculo consultas = new ConsultasVehiculo();
           

            try
            {
                             
                if (cmbFiltros.Texts == "ID")
                {
                    dgvDatos.DataSource = consultas.BuscarID(txtBusqueda.Texts);
                }
                if (cmbFiltros.Texts == "Marca")                       
                {
                    dgvDatos.DataSource = consultas.BuscarMarca(txtBusqueda.Texts);
                }
                if (cmbFiltros.Texts == "Tipo Vehiculo")
                {
                    dgvDatos.DataSource = consultas.BuscarTipoV(txtBusqueda.Texts);
                }
                

            }
            catch (Exception EX)
            {

                MessageBox.Show("Ha ocurrido un error: " + EX.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
