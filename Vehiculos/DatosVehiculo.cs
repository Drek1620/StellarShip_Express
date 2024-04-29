using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.Vehiculos
{
    internal class DatosVehiculo
    {
        public static int IdVehiculo { get; set; }
        public static string Marca { get; set; }
        public static string Modelo { get; set; }
        public static string NoPlaca { get; set; }
        public static string TipoVehiculo { get; set; }
        public static string Año { get; set; }
        public static int IdTransportista { get; set; }
        public static string AccionV { get => accionV; set => accionV = value; }
        public int Numero { get; set; }

        public static int inicio { get; set; }    
        public static int final { get; set; }

        private static string accionV;

    }
}
