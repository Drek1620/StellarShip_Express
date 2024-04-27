using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf.codec.wmf;
using static AForge.Math.FourierTransform;
using System.Security.Cryptography;
using System.Windows.Input;

namespace StellarShip_Express.Otros
{
    internal class PaginadoClientes
    {

        private int IdRemitente;
        private string Nombre;
        private string Telefono;
        private string CorreoElectronico;
        private string Direccion;
        private string Dep;
        private string CP;
        private string Ciudad;
        private string Estado;
        private string Pais;
        private int Numero;
        private int Inicio;
        private int Final;


        public int IdRemitente1 { get => IdRemitente; set => IdRemitente = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string CorreoElectronico1 { get => CorreoElectronico; set => CorreoElectronico = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Dep1 { get => Dep; set => Dep = value; }
        public string CP1 { get => CP; set => CP = value; }
        public string Ciudad1 { get => Ciudad; set => Ciudad = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string Pais1 { get => Pais; set => Pais = value; }
        public int Numero1 { get => Numero; set => Numero = value; }
        public int Inicio1 { get => Inicio; set => Inicio = value; }
        public int Final1 { get => Final; set => Final = value; }
        
        private SqlDataReader LeerFilas;
        public DataSet PaginadoClientes_()
        {
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    SqlCommand comando = new SqlCommand("PaginadoClientes", connection);
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@inicio", Inicio1);
                    comando.Parameters.AddWithValue("@final", Final1);
                    SqlDataAdapter da = new SqlDataAdapter(comando);
                    DataSet dt = new DataSet();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable Remitente_(string hoka)
        {
            DataTable Tabla = new DataTable();
            ConexionSQLServ conexionSQL = new ConexionSQLServ();
            using (var connection = conexionSQL.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * from Remitente";

                    command.CommandType = CommandType.Text;

                    LeerFilas = command.ExecuteReader();
                    Tabla.Load(LeerFilas);
                    return Tabla;
                }
            }
        }



    }
}
