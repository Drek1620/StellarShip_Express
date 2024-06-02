using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Configuracion
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string ruta = @"C:\Backup\";
            if (Directory.Exists(ruta)) { }
            else Directory.CreateDirectory(ruta);

            string Nombre_Copia = "Bd_StellarShip_Fecha_" + DateTime.Now.ToString("dd_MM_yyyy") + "_Hora_" + DateTime.Now.ToString("hh_mm_ss");
            ConexionSQLServ conexionSQLServ = new ConexionSQLServ();

            using (var connection = conexionSQLServ.GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = @"BACKUP DATABASE [STELLARSHIP] TO  DISK = N'C:\Backup\"+Nombre_Copia+ ".tmp' WITH NOFORMAT, NOINIT,  NAME = N'STELLARSHIP-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                    command.CommandType = CommandType.Text;
                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Copia creada exitosamente");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Si desea realizar otra copia cierre y habra nuevamente esta ventana");
                    }
                    
                }
            }

           
        }
    }
}
