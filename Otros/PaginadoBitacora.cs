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
    internal class PaginadoBitacora
    {

        private int numero;

        private int IdBitacora;

        private int IdUsuario;

        private string Fecha;
        private string Accion;
        private string TablaAfectada;
        private int inicio;
        private int final;





        public int Numero { get => numero; set => numero = value; }
        public int IdBitacora1 { get => IdBitacora; set => IdBitacora = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public string Accion1 { get => Accion; set => Accion = value; }
        public string TablaAfectada1 { get => TablaAfectada; set => TablaAfectada = value; }
        public int Inicio { get => inicio; set => inicio = value; }
        public int Final { get => final; set => final = value; }

        private SqlDataReader LeerFilas;

        public DataSet paginacionbitacora()
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlCommand comando = new SqlCommand("pagbitacora", connection);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@inicio", Inicio);
                    comando.Parameters.AddWithValue("@final", Final);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable Factura(string hoka)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from bitacora";

                    command.CommandType = CommandType.Text;

                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }
    }
}
