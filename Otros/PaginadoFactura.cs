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
    public class PaginadoFactura
    {
        private double NoFactura;
        private int Cliente;
        private int Cantidad;
        private string Monto;
        private string Fecha;
        private int Sucursal;
        private double IdEnvio;
        private int Numero;
        private int inicio;
        private int final;

        public double NoFactura1 { get => NoFactura; set => NoFactura = value; }
        public int Cliente1 { get => Cliente; set => Cliente = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string Monto1 { get => Monto; set => Monto = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public double IdEnvio1 { get => IdEnvio; set => IdEnvio = value; }
        public int Inicio { get => inicio; set => inicio = value; }
        public int Final { get => final; set => final = value; }
        public int Numero1 { get => Numero; set => Numero = value; }
        public int Sucursal1 { get => Sucursal; set => Sucursal = value; }

        private SqlDataReader LeerFilas;
        public DataSet PaginadoFac_()
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlCommand comando = new SqlCommand("PaginadoFac", connection);
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
    }
}
