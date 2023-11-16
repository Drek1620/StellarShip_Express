using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.RegistrarPaquete
{
    class ArregloCliente
    {
        private string nombre;
        private string correo;
        private string telefono;
        private string empresa;
        private string direccion;
        private string nointerior;
        private string cp;
        private string ciudad;
        private string estado;
        private string pais;

        public ArregloCliente(string nombre, string correo, string telefono, string empresa, string direccion, string nointerior, string cp, string ciudad, string estado, string pais)
        {
            this.Nombre = nombre;
            this.Correo = correo;
            this.Telefono = telefono;
            this.Empresa = empresa;
            this.Direccion = direccion;
            this.Nointerior = nointerior;
            this.Cp = cp;
            this.Ciudad = ciudad;
            this.Estado = estado;
            this.Pais = pais;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Nointerior { get => nointerior; set => nointerior = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Pais { get => pais; set => pais = value; }
    }

    class DatosCliente
    {
        static ArregloCliente[] cliente = new ArregloCliente[2];
        public static int IdCliente { get;set; }
		public static long NoFactura { get; set; }

		public static ArregloCliente[] Cliente { get => cliente; set => cliente = value; }
    }
}
