using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.RegistrarPaquete
{
    internal class Paquete
    {
        private string embalaje;
        private double largo;
        private double ancho;
        private double peso;
        private string seguro;
        private string mpeligroso;
        private string pirregular;

        public Paquete(string embalaje, double largo, double ancho, double peso, string seguro, string mpeligroso, string pirregular)
        {
            this.Embalaje = embalaje;
            this.Largo = largo;
            this.Ancho = ancho;
            this.Peso = peso;
            this.Seguro = seguro;
            this.Mpeligroso = mpeligroso;
            this.Pirregular = pirregular;
        }

        public string Embalaje { get => Embalaje1; set => Embalaje1 = value; }
        public string Embalaje1 { get => embalaje; set => embalaje = value; }
        public double Largo { get => largo; set => largo = value; }
        public double Ancho { get => ancho; set => ancho = value; }
        public double Peso { get => peso; set => peso = value; }
        public string Seguro { get => seguro; set => seguro = value; }
        public string Mpeligroso { get => mpeligroso; set => mpeligroso = value; }
        public string Pirregular { get => pirregular; set => pirregular = value; }
    }
    class DatosPaquete
    {
        static Paquete[] paquete = new Paquete[10];
        static int cantidad;
        static string caja;
        static string bolsa;

        public static Paquete[] Paquete { get => paquete; set => paquete = value; }
        public static int Cantidad { get => cantidad; set => cantidad = value; }
        public static string Caja { get => caja; set => caja = value; }
        public static string Bolsa { get => bolsa; set => bolsa = value; }
    }
}
