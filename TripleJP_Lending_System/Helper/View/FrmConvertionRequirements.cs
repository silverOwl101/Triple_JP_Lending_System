using System;
using System.Windows.Forms;

namespace TripleJP_Lending_System.Helper.View
{
    internal class FrmConvertionRequirements
    {

        internal void ConvertToNumberFormat(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = Convert.ToDouble(textBox.Text).ToString("N");
            }
        }

        internal void ConvertToGeneralFormat(TextBox textBox)
        {
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = Convert.ToDouble(textBox.Text).ToString("G");
            }
        }

    }
}
