using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class EditCustomerFrm : Form, IEditCustomer
    {
        string customerID = CustomerAccountFrm.customerInformation[0].ToString();
        public EditCustomerFrm()
        {
            InitializeComponent();
            LoadCustomerInformation();
        }

        public string ID // To be pass to the presenter
        {
            get { return customerID; }
            set { customerID = value; }
        }
        #region Other Methods
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
        private void LoadCustomerInformation()
        {
            CustomerNametxt.Text = CustomerAccountFrm.customerInformation[1].ToString();
            CustomerAddresstxt.Text = CustomerAccountFrm.customerInformation[2].ToString();
            ContactNumbertxt.Text = CustomerAccountFrm.customerInformation[3].ToString();
            BusinessNametxt.Text = CustomerAccountFrm.customerInformation[4].ToString();
            BusinessNaturetxt.Text = CustomerAccountFrm.customerInformation[5].ToString();
            BusinessAddresstxt.Text = CustomerAccountFrm.customerInformation[6].ToString();
            GrossBusinessCapitaltxt.Text = CustomerAccountFrm.customerInformation[7].ToString();
            AverageDailyGrossSalestxt.Text = CustomerAccountFrm.customerInformation[8].ToString();
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
        private void button1_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            CustomerEditPresenter editPresenter = new CustomerEditPresenter(this);
            editPresenter.PrepareUpdate();
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
