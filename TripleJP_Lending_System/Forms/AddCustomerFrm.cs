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

        internal void ClearTextbox()
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
        public uint ContactNumber
        {
            get { return Convert.ToUInt32(ContactNumbertxt.Text); }
            set { ContactNumbertxt.Text = value.ToString(); }
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
    }
}
