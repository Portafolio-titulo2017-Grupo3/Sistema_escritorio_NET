using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrionEscritoriok
{
    class validar
    {
        public static void soloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }

        public static void soloUsuario(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }
        }


        public static void solorut(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (v.KeyChar.ToString().Equals("-"))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }

        }
        public static void solonum(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
         
            else
            {
                v.Handled = true;
            }

        }
        public static void letrasynum(KeyPressEventArgs v)
        {

            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
            }




        }
        public static void letrasynumv2(KeyPressEventArgs v)
        {

            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }

            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
             
            
            else
            {
                v.Handled = true;
            }




        }

    }
}
