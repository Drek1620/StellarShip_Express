using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.Vehiculos
{
    internal class DatosSucursal
    {
       // public static int IDModifiS { get; set; }
        public static int IdDestino { get; set; }
        public static string NombreSuc { get; set; }
        public static string PaisS { get; set; }
        public static int EstadoS { get; set; }
        public static int MunicipioS { get; set; }
        public static string CPS { get; set; }
        public static string Calle { get; set; }
        public static string TelefS { get; set; }
        public static string AccionS { get => accionS; set => accionS = value; }

        private static string accionS;

        //Variables para la paginacion
        public static int inicioS { get; set; }
        public static int finalS { get; set; }
    }
}
