using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.RegistrarPaquete
{
    internal class Factura
    {
        private int cantidad =0;
        private string descripcion;
        private double unitario = 0;
        private double extras = 0;
        private double importe = 0;


        public Factura(int cantidad, string descripcion, double unitario, double extras, double importe, double subtotal, double total)
        {
            this.Cantidad = cantidad;
            this.Descripcion = descripcion;
            this.Unitario = unitario;
            this.Extras = extras;
            this.Importe = importe;
        }

        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Unitario { get => unitario; set => unitario = value; }
        public double Extras { get => extras; set => extras = value; }
        public double Importe { get => importe; set => importe = value; }
    } 

    class DatosFactura
    {
        static Factura[] factura = new Factura[2];

        internal static Factura[] Factura { get => factura; set => factura = value; }
    }
}
