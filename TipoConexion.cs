using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express
{
    public static class TipoConexion
    {
        static string conexion= "Microsoft SQL Server";

        public static string Conexion { get => conexion; set => conexion = value; }
    }
}
