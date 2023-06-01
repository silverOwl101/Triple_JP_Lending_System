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
        private FrmInputRequirements frmInputRequirements = new FrmInputRequirements();
        private IFormsMediator _concreteMediator;
        private AddLoanFrmData _addLoanFrmData;

        #endregion

        public AddLoanFrm()
        {
            InitializeComponent();
            OnLoadData();            
        }

        #region User Inputs
        
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
            get { return effectiveDateTimePicker.Value.Date; }
            set { effectiveDateTimePicker.Text = value.ToString(); }
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

        #region Form Events

        #region TextBoxes

        #region PrincipalLoanTxt Events

        private void PrincipalLoanTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, principalLoanTextBox);
        }
        private void PrincipalLoanTxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(principalLoanTextBox);
        }
        private void PrincipalLoanTxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(principalLoanTextBox);
        }
        private void PrincipalLoanTextBox_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
            TextMask();
        }

        #endregion

        #endregion

        #region Buttons

        #region Save Button Events

        private void SaveButton_Click(object sender, EventArgs e)
        {
            AddLoanPresenter addLoanPresenter = new AddLoanPresenter(this);
            addLoanPresenter.OnLoadData();
            Close();
        }

        #endregion


        #region Calculate Button Events

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                DisplayCalculatedProperties();
            }
            catch (Exception)
            {
                string message = "Fill all the required fields to calculate loan";
                string messageCaption = "All required fields not fill";
                ErrorMessage(message, messageCaption);
            }
        }

        #endregion

        #endregion

        #region ComboBox

        private void DurationComboBox_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }

        private void InterestComboBox_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }

        private void PenaltyComboBox_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }

        private void PaymentTermComboBox_TextChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }

        #endregion

        #region DateTimePicker

        private void EffectiveDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SaveButtonDisable();
        }

        #endregion

        #endregion

        #region Custom Methods

        #region Calculation Displays
        private void MaturityInterestDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanTextBox.Text);
            Computation comp = new Computation();
            maturityInterestLabel.Text = String.Format("{0:N}", comp.MaturityInterest(loan));
        }
        private void MaturityValueDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanTextBox.Text);
            Computation comp = new Computation();
            decimal interest = Convert.ToDecimal(maturityInterestLabel.Text);
            maturityValueLabel.Text = String.Format("{0:N}", comp.MaturityValue(interest, loan));
        }
        private void PerRemittanceDisplay()
        {
            Computation comp = new Computation();
            decimal _value = Convert.ToDecimal(maturityValueLabel.Text);
            int duration = Convert.ToInt32(durationComboBox.Text);
            perRemittanceLabel.Text = comp.PerRemittance(_value, duration).ToString();
        }
        private void MaturityDate()
        {
            Computation comp = new Computation();
            DateTime effectiveDate = effectiveDateTimePicker.Value;
            int duration = Convert.ToInt32(durationComboBox.Text);
            maturityDateLabel.Text = comp.MaturityDate(effectiveDate, duration).ToString("MM-dd-yyyy");
        }
        #endregion

        private void ErrorMessage(string text, string messageCaption)
        {
            MessageBox.Show(text, messageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnLoadData()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _addLoanFrmData = new AddLoanFrmData(_concreteMediator);
            customerIdLabel.Text = _concreteMediator.GetData(_addLoanFrmData)[0];
            customerAddressLabel.Text = _concreteMediator.GetData(_addLoanFrmData)[1];
            DefaultProperties();
        }
        private void DefaultProperties()
        {
            saveButton.Enabled = false;
            TextMask();
        }
        private void TextMask()
        {
            perRemittanceLabel.Text = "XXXX.XX";
            maturityValueLabel.Text = "XXXX.XX";
            maturityDateLabel.Text = "XXXX.XX";
            maturityInterestLabel.Text = "XXXX.XX";
        }
        private void DisplayCalculatedProperties()
        {
            MaturityInterestDisplay();
            MaturityValueDisplay();
            PerRemittanceDisplay();
            MaturityDate();
            saveButton.Enabled = true;
        }
        private void SaveButtonDisable()
        {
            saveButton.Enabled = false;
        }

        #endregion

    }
}
