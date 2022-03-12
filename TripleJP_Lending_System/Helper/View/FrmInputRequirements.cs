using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleJP_Lending_System.Helper.View
{
    internal class FrmInputRequirements
    {
        internal void InputNumbersOnly(KeyPressEventArgs e)
        {            
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b') // enable backspace
            {
                e.Handled = false;
            }
            if (e.KeyChar == '\u0001') // enable ctrl + a
            {
                e.Handled = false;
            }            
        }
        internal void InputNumbersWithDecimalPlacesOnly(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '\b') // enable backspace
            {
                e.Handled = false;
            }
            if (e.KeyChar == '\u0001') // enable ctrl + a
            {
                e.Handled = false;
            }
            if (e.KeyChar == '.') // enable dot for decimal places
            {
                e.Handled = false;
            }
        }
    }
}
