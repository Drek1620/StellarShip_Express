using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StellarShip_Express.Validaciones
{
    internal class ValidarTxt
    {
        public static bool SoloNumeros(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == 46)
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar) || e.KeyChar == 46)
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                return false;
            }
        }
    }
}
