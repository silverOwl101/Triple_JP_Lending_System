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
        private FrmConvertionRequirements _frmConvertionRequirements
                                                    = new FrmConvertionRequirements();
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
        private void maturityDate()
        {
            Computation comp = new Computation();
            DateTime effectiveDate = dateTimePicker1.Value;
            int duration = Convert.ToInt32(comboBox2.Text);
            label19.Text = comp.MaturityDate(effectiveDate, duration).ToString("MM-dd-yyyy");
        }
        #endregion
        #region User input                                
        public string CustomerID
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string PaymentTerm
        {
            get { return comboBox1.Text; }
            set { comboBox1.Text = value; }
        }
        public int Duration
        {
            get { return Convert.ToInt32(comboBox2.Text); }
            set { comboBox2.Text = value.ToString(); }
        }
        public DateTime EffectiveDate
        {
            get { return dateTimePicker1.Value.Date; }
            set { dateTimePicker1.Text = value.ToString(); }
        }
        public decimal Interest
        {
            get { return Convert.ToDecimal(comboBox4.Text); }
            set { comboBox4.Text = value.ToString(); }
        }
        public decimal PrincipalLoan
        {
            get { return Convert.ToDecimal(textBox1.Text); }
            set { textBox1.Text = value.ToString(); }
        }
        public decimal Penalty
        {
            get { return Convert.ToDecimal(comboBox6.Text); }
            set { comboBox6.Text = value.ToString(); }
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
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, textBox1);
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {            
            _frmConvertionRequirements.ConvertToNumberFormat(textBox1);            
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(textBox1);
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
            label2.Text = _concreteMediator.GetData(_addLoanFrmData)[0];
            label3.Text = _concreteMediator.GetData(_addLoanFrmData)[1];
            defaultProperties();
        }
        private void defaultProperties()
        {
            button2.Enabled = false;            
            textMask();
        }
        private void textMask()
        {
            label17.Text = "XXXX.XX";
            label18.Text = "XXXX.XX";
            label19.Text = "XXXX.XX";
            label20.Text = "XXXX.XX";
        }
        private void displayCalculatedProperties()
        {
            maturityInterestDisplay();
            maturityValueDisplay();
            perRemittanceDisplay();
            maturityDate();
            button2.Enabled = true;
        }
        private void SaveButtonDisable()
        {
            button2.Enabled = false;
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
