using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsOnDemmand_Proyecto.Utility_Class
{
    public class ValidarKeyPress
    {
        public static void Numeros(KeyPressEventArgs KpE)
        {
            if (char.IsDigit(KpE.KeyChar))
            {
                KpE.Handled = false;
            }
            else if (char.IsControl(KpE.KeyChar))
            {
                KpE.Handled = false;
            }
            else
                KpE.Handled = true;
        }
        public static void Letras(KeyPressEventArgs KpE)
        {
            if (Char.IsLetter(KpE.KeyChar))
            {
                KpE.Handled = false;
            }
            else if (char.IsControl(KpE.KeyChar))
            {
                KpE.Handled = false;
            }
            else if (char.IsSeparator(KpE.KeyChar))
            {
                KpE.Handled = false;
            }
            else
                KpE.Handled = true;
        }
    }
}
