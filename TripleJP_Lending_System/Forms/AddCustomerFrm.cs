using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.View;
using TripleJP_Lending_System.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddCustomerFrm : Form, IAddCustomer
    {
        public AddCustomerFrm()
        {
            InitializeComponent();
            ClearTextbox();
        }
        #region Other methods
        private void ClearTextbox()
        {
            CustomerNametxt.Clear();
            CustomerAddresstxt.Clear();
            ContactNumbertxt.Clear();
            BusinessNametxt.Clear();
            BusinessNaturetxt.Clear();
            BusinessAddresstxt.Clear();
            GrossBusinessCapitaltxt.Clear();
            AverageDailyGrossSalestxt.Clear();
        }
        private void InputNumbersOnly(KeyPressEventArgs e)
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
        private void InputNumbersWithDecimalPlacesOnly(KeyPressEventArgs e)
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
        #endregion
        #region User Inputs
        public string CustomerName 
        {
            get { return CustomerNametxt.Text; }
            set { CustomerNametxt.Text = value; }
        }
        public string CustomerAddress
        {
            get { return CustomerAddresstxt.Text; }
            set { CustomerAddresstxt.Text = value; }
        }
        public string ContactNumber
        {
            get { return ContactNumbertxt.Text; }
            set { ContactNumbertxt.Text = value; }
        }
        public string BusinessName
        {
            get { return BusinessAddresstxt.Text; }
            set { BusinessAddresstxt.Text = value; }
        }
        public string BusinessNature
        {
            get { return BusinessNaturetxt.Text; }
            set { BusinessNaturetxt.Text = value; }
        }
        public string BusinessAddress
        {
            get { return BusinessAddresstxt.Text; }
            set { BusinessAddresstxt.Text = value; }
        }
        public decimal GrossBusinessCapital
        {
            get { return Convert.ToDecimal(GrossBusinessCapitaltxt.Text); }
            set { GrossBusinessCapitaltxt.Text = value.ToString(); }
        }
        public decimal AveDailyGrossSales
        {
            get { return Convert.ToDecimal(AverageDailyGrossSalestxt.Text); }
            set { AverageDailyGrossSalestxt.Text = value.ToString(); }
        }
        #endregion

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            AddCustomerPresenter addcustomer = new AddCustomerPresenter(this);            
            bool rslt = addcustomer.CustomerDataPreparation();
            if (rslt)
            {
                ClearTextbox();
            }
        }

        private void ContactNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbersOnly(e);
        }
        
        private void GrossBusinessCapitaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbersWithDecimalPlacesOnly(e);
        }

        private void AverageDailyGrossSalestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbersWithDecimalPlacesOnly(e);
        }
    }
}
