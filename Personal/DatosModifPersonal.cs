using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.Personal
{
    public static class DatosModifPersonal
    {
        static string accion; 
        public static int IdUser { get; set; }
        public static string LoginNombre { get; set; }
        public static string Contraseña { get; set; }
        public static string Nombre { get; set; }
        public static string PrimerApellido { get; set; }
        public static string SegundoApellido { get; set; }
        public static int Acceso { get; set; }
        public static long Telefono { get; set; }
        public static string Foto { get; set; }
        public static string Accion { get => accion; set => accion = value; }
 
    }
}
