using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StellarShip_Express.RegistrarPaquete
{
    internal class CalcularPrecios
    {
        private double caja=500;
        private double sobre=200;
        private double seguro=150;
        private double peligroso=250;
        private double irregular=250;
        private static double servicios=0;
        private static double subtotal=0;
        private static double total=0;

        public static double Subtotal { get => subtotal; set => subtotal = value; }
        public static double Total { get => total; set => total = value; }
        public static double Servicios { get => servicios; set => servicios = value; }

        public void Calcular()
        {
            double c1 = double.Parse(DatosPaquete.Caja) * caja;
            double b2 = double.Parse(DatosPaquete.Bolsa) * sobre;
            double s1=c1+b2;
            double pesot=0;
            for (int i = 0; i < DatosPaquete.Cantidad; i++)
            {
                pesot =pesot+ DatosPaquete.Paquete[i].Peso;
                if (DatosPaquete.Paquete[i].Seguro == "Si")
                    Servicios = Servicios + seguro;
                if (DatosPaquete.Paquete[i].Mpeligroso == "Si")
                    Servicios = Servicios + peligroso;
                if (DatosPaquete.Paquete[i].Pirregular == "Si")
                    Servicios = Servicios + irregular;
            }

            if (pesot > 2 && pesot <= 4)
                s1 = s1 * 1.05;
            else if (pesot > 4 && pesot <= 8)
                s1 = s1 * 1.10;
            else if (pesot > 8 && pesot <= 16)
                s1 = s1 * 1.15;
            else if (pesot > 16 && pesot <= 32)
                s1 = s1 * 1.25;
            else if (pesot > 32)
                s1 = s1 * 1.50;

            Subtotal = Servicios + s1;
            Total = Subtotal * 1.16;
        }
    }
}
