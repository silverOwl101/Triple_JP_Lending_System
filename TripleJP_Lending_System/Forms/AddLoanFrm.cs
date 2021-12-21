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
using TripleJPLibraryCore;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddLoanFrm : Form, IAddLoan
    {        
        public AddLoanFrm()
        {
            InitializeComponent();
            onLoadData();
        }
        private void maturityInterestDisplay()
        {
            decimal loan = Convert.ToDecimal(textBox1.Text);
            Computation comp = new Computation();
            label20.Text = String.Format("{0:N}", comp.MaturityInterest(loan));
        }
        private void maturityValueDisplay()
        {
            decimal loan = Convert.ToDecimal(textBox1.Text);
            Computation comp = new Computation();
            decimal interest = Convert.ToDecimal(label20.Text);
            label18.Text = String.Format("{0:N}", comp.MaturityValue(interest, loan));
        }
        private void perRemittanceDisplay()
        {
            Computation comp = new Computation();
            decimal _value = Convert.ToDecimal(label18.Text);
            int duration = Convert.ToInt32(comboBox2.Text);
            label17.Text = comp.PerRemittance(_value, duration).ToString();
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
            get { return Convert.ToDecimal(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
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
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputNumbersWithDecimalPlacesOnly(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maturityInterestDisplay();
            maturityValueDisplay();
            perRemittanceDisplay();
        }
    }
}
