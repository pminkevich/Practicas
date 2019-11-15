using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    class Validar
    {

        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                if (v.Handled)
                {
                    MessageBox.Show("Solo Letras");
                }
               // MessageBox.Show("Solo Letras");
            }
        }
        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                if (v.Handled)
                {
                    MessageBox.Show("Solo Numeros");
                }
                //MessageBox.Show("Solo Numeros");
            }
        }
    }
}
