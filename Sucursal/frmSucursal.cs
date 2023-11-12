﻿using StellarShip_Express.Vehiculos;
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
        public frmSucursal()
        {
            InitializeComponent();
        }
        public void MostrarSuc()
        {
            Consultas consultas = new Consultas();
            dgvDatos.DataSource = consultas.MostrarSuc();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DatosSucursal.AccionS = "Alta";
            frmRegistrarSucursal frm = new frmRegistrarSucursal();
            frm.ShowDialog();
        }

        private void frmSucursal_Load(object sender, EventArgs e)
        {
            MostrarSuc();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            MostrarSuc();
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
                DatosSucursal.EstadoS = dgvDatos.CurrentRow.Cells["Estado"].Value.ToString();
                DatosSucursal.MunicipioS = dgvDatos.CurrentRow.Cells["Municipio"].Value.ToString();
                DatosSucursal.CPS= dgvDatos.CurrentRow.Cells["CP"].Value.ToString();
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
        Consultas dato = new Consultas();
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
    }
}
