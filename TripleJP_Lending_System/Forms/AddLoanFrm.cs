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
using TripleJPUtilityLibrary.Accounting;
using TripleJP_Lending_System.Helper.View;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Component;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddLoanFrm : Form, IAddLoan
    {
        #region Fields
        private FrmConvertionRequirements _frmConvertionRequirements = new FrmConvertionRequirements();
        private FrmInputRequirements _frmInputRequirements = new FrmInputRequirements();
        private IFormsMediator _concreteMediator;
        private AddLoanFrmData _addLoanFrmData;
        #endregion
        public AddLoanFrm()
        {
            InitializeComponent();
            onLoadData();            
        }
        #region Calculation Displays
        private void maturityInterestDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanTextBox.Text);
            Computation comp = new Computation();
            maturityInterestLabel.Text = String.Format("{0:N}", comp.MaturityInterest(loan));
        }
        private void maturityValueDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanTextBox.Text);
            Computation comp = new Computation();
            decimal interest = Convert.ToDecimal(maturityInterestLabel.Text);
            maturityValueLabel.Text = String.Format("{0:N}", comp.MaturityValue(interest, loan));
        }
        private void perRemittanceDisplay()
        {
            Computation comp = new Computation();
            decimal _value = Convert.ToDecimal(maturityValueLabel.Text);
            int duration = Convert.ToInt32(durationComboBox.Text);
            perRemittanceLabel.Text = comp.PerRemittance(_value, duration).ToString();
        }
        private void maturityDate()
        {
            Computation comp = new Computation();
            DateTime effectiveDate = EffectiveDateTimePicker.Value;
            int duration = Convert.ToInt32(durationComboBox.Text);
            maturityDateLabel.Text = comp.MaturityDate(effectiveDate, duration).ToString("MM-dd-yyyy");
        }
        #endregion
        #region User input                                
        public string CustomerID
        {
            get { return customerIdLabel.Text; }
            set { customerIdLabel.Text = value; }
        }
        public string PaymentTerm
        {
            get { return paymentTermComboBox.Text; }
            set { paymentTermComboBox.Text = value; }
        }
        public int Duration
        {
            get { return Convert.ToInt32(durationComboBox.Text); }
            set { durationComboBox.Text = value.ToString(); }
        }
        public DateTime EffectiveDate
        {
            get { return EffectiveDateTimePicker.Value.Date; }
            set { EffectiveDateTimePicker.Text = value.ToString(); }
        }
        public decimal Interest
        {
            get { return Convert.ToDecimal(interestComboBox.Text); }
            set { interestComboBox.Text = value.ToString(); }
        }
        public decimal PrincipalLoan
        {
            get { return Convert.ToDecimal(principalLoanTextBox.Text); }
            set { principalLoanTextBox.Text = value.ToString(); }
        }
        public decimal Penalty
        {
            get { return Convert.ToDecimal(penaltyComboBox.Text); }
            set { penaltyComboBox.Text = value.ToString(); }
        }
        #endregion
        #region Calculate button events
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                displayCalculatedProperties();
            }
            catch (Exception)
            {
                string message = "Fill all the required fields to calculate loan";
                string messageCaption = "All required fields not fill";
                ErrorMessage(message, messageCaption);
            }
        }
        #endregion
        #region Save button events
        private void button2_Click(object sender, EventArgs e)
        {
            AddLoanPresenter addLoanPresenter = new AddLoanPresenter(this);
            addLoanPresenter.OnLoadData();
            Close();
        }
        #endregion
        #region Principal loan events
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, principalLoanTextBox);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {            
            _frmConvertionRequirements.ConvertToNumberFormat(principalLoanTextBox);            
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(principalLoanTextBox);
        }
        #endregion
        #region Other important methods
        private void ErrorMessage(string text, string messageCaption)
        {
            MessageBox.Show(text, messageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
        private void onLoadData()
        {            
            _concreteMediator = new ClassComponentConcreteMediator();
            _addLoanFrmData = new AddLoanFrmData(_concreteMediator);
            customerIdLabel.Text = _concreteMediator.GetData(_addLoanFrmData)[0];
            customerAddressLabel.Text = _concreteMediator.GetData(_addLoanFrmData)[1];
            defaultProperties();
        }
        private void defaultProperties()
        {
            saveButton.Enabled = false;            
            textMask();
        }
        private void textMask()
        {
            perRemittanceLabel.Text = "XXXX.XX";
            maturityValueLabel.Text = "XXXX.XX";
            maturityDateLabel.Text = "XXXX.XX";
            maturityInterestLabel.Text = "XXXX.XX";
        }
        private void displayCalculatedProperties()
        {
            maturityInterestDisplay();
            maturityValueDisplay();
            perRemittanceDisplay();
            maturityDate();
            saveButton.Enabled = true;
        }
        private void SaveButtonDisable()
        {
            saveButton.Enabled = false;
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }
        private void comboBox2_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }
        private void comboBox4_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
            textMask();            
        }
        private void comboBox6_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }
    }
}
