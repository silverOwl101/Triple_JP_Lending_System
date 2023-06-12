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

        internal void InputNumbersWithDecimalPlacesOnly(KeyPressEventArgs e, TextBox textbox)
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
                if (textbox.Text.Contains("."))
                {
                    e.Handled = true;
                }
                else if (string.IsNullOrEmpty(textbox.Text))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }                                
            }                       
        }

    }
}
