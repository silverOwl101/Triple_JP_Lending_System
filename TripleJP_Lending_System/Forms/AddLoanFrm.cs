using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddLoanFrm : Form, IAddLoan
    {        
        public AddLoanFrm()
        {
            InitializeComponent();
            onLoadData();
        }
        #region User input                                
        public string customerID
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string paymentTerm
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        public int duration
        {
            get { return Convert.ToInt32(comboBox2.Text); }
            set { comboBox2.Text = value.ToString(); }
        }
        public DateTime effectiveDate
        {
            get { return dateTimePicker1.Value.Date; }
            set { dateTimePicker1.Text = value.ToString(); }
        }
        public decimal interest
        {
            get { return Convert.ToDecimal(comboBox4.Text); }
            set { comboBox4.Text = value.ToString(); }
        }
        public decimal principalLoan
        {
            get { return Convert.ToDecimal(comboBox5.Text); }
            set { comboBox5.Text = value.ToString(); }
        }
        public decimal penalty
        {
            get { return Convert.ToDecimal(comboBox6.Text); }
            set { comboBox6.Text = value.ToString(); }
        }        
        #endregion
        private void onLoadData()
        {
            label2.Text = CustomerListLoanFrm.customerLoanInformation[0];
            label3.Text = CustomerListLoanFrm.customerLoanInformation[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddLoanPresenter addLoanPresenter = new AddLoanPresenter(this);
            addLoanPresenter.onLoadData();
        }
    }
}
