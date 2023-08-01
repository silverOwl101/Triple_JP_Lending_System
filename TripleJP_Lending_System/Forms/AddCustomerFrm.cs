using System;
using System.Windows.Forms;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Presenter;
using TripleJP_Lending_System.Helper.View;
using MySql.Data.MySqlClient;
using System.IO;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddCustomerFrm : Form, IAddCustomer
    {
        #region Fields

        private FrmInputRequirements _frmInputRequirements;
        private FrmConvertionRequirements _frmConvertionRequirements;
        private AddCustomerPresenter _addCustomerPresenter;

        #endregion

        public AddCustomerFrm()
        {            
            InitializeComponent();
            submitButton.Enabled = false;
            ClearTextbox();            
        }

        #region User Inputs

        public string CustomerName 
        {
            get { return customerNameTxt.Text; }
            set { customerNameTxt.Text = value; }
        }
        public string CustomerAddress
        {
            get { return customerAddressTxt.Text; }
            set { customerAddressTxt.Text = value; }
        }
        public string ContactNumber
        {
            get { return contactNumberTxt.Text; }
            set { contactNumberTxt.Text = value; }
        }
        public string BusinessName
        {
            get { return businessAddressTxt.Text; }
            set { businessAddressTxt.Text = value; }
        }
        public string BusinessNature
        {
            get { return businessNatureTxt.Text; }
            set { businessNatureTxt.Text = value; }
        }
        public string BusinessAddress
        {
            get { return businessAddressTxt.Text; }
            set { businessAddressTxt.Text = value; }
        }
        public decimal GrossBusinessCapital
        {
            get { return Convert.ToDecimal(grossBusinessCapitalTxt.Text); }
            set { grossBusinessCapitalTxt.Text = value.ToString("G"); }
        }
        public decimal AverageDailyGrossSales
        {
            get { return Convert.ToDecimal(averageDailyGrossSalesTxt.Text); }
            set { averageDailyGrossSalesTxt.Text = value.ToString("G"); }
        }

        #endregion

        #region Form Events

        #region Buttons

        #region Submitbutton Events

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            _addCustomerPresenter = new AddCustomerPresenter(this);

            try
            {
                _addCustomerPresenter.OnLoadInsertData();

                const string MessageContent = "Customer's information successfully added to the system.";
                const string MessageCaption = "Entry Successfully Added";
                MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextbox();
            } 
            catch (ArgumentException ex) when (ex.ParamName is "Name")
            {
                const string MessageContent = "The name of the customer has the same name recorded in the system. Would you like to continue saving the entry?";
                const string MessageCaption = "Duplicate Credentials";
                var result = MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                _addCustomerPresenter.OnLoadRetryAddEntry(result);

                ClearTextbox();
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
                const string MessageCaption = "System Access Denied";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TypeInitializationException ex) when (ex.InnerException is FileNotFoundException)
            {
                const string MessageContent = "Configuration file is missing, please create a config file first.";
                const string MessageCaption = "Configuration lost";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #endregion

        #region TextBox

        #region ContactNumberTxt Events

        private void ContactNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements = new FrmInputRequirements();
            _frmInputRequirements.InputNumbersOnly(e);
            contactNumberTxt.MaxLength = 14;
        }
        private void ContactNumbertxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }
        private void ContactNumbertxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }

        #endregion

        #region GrossBusinessCapitalTxt Events

        private void GrossBusinessCapitaltxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements = new FrmInputRequirements();
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, grossBusinessCapitalTxt);
            grossBusinessCapitalTxt.MaxLength = 14;            
            SubmitButtonDisable();            
        }
        private void GrossBusinessCapitaltxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToNumberFormat(grossBusinessCapitalTxt);
            IsAllTextBoxNotEmpty();
        }
        private void GrossBusinessCapitaltxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToGeneralFormat(grossBusinessCapitalTxt);
        }

        #endregion

        #region AverageDailyGrossSalesTxt Events

        private void AverageDailyGrossSalestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements = new FrmInputRequirements();
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, averageDailyGrossSalesTxt);
            averageDailyGrossSalesTxt.MaxLength = 14;
            SubmitButtonDisable();
        }
        private void AverageDailyGrossSalestxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToNumberFormat(averageDailyGrossSalesTxt);
            IsAllTextBoxNotEmpty();
        }
        private void AverageDailyGrossSalestxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToGeneralFormat(averageDailyGrossSalesTxt);
        }

        #endregion

        #region CustomerNameTxt Events

        private void CustomerNametxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }
        private void CustomerNametxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }

        #endregion

        #region CustomerAddressTxt Events

        private void CustomerAddresstxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }
        private void CustomerAddresstxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }

        #endregion

        #region BusinessNameTxt Events

        private void BusinessNametxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }
        private void BusinessNametxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }

        #endregion

        #region BusinessNatureTxt Events

        private void BusinessNaturetxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }
        private void BusinessNaturetxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }

        #endregion

        #region BusinessAddressTxt Events

        private void BusinessAddresstxt_Leave(object sender, EventArgs e)
        {
            IsAllTextBoxNotEmpty();
        }               
        private void BusinessAddresstxt_TextChanged(object sender, EventArgs e)
        {
            SubmitButtonDisable();
        }

        #endregion

        #endregion

        #endregion

        #region Custom Methods

        private void ClearTextbox()
        {
            customerNameTxt.Clear();
            customerAddressTxt.Clear();
            contactNumberTxt.Clear();
            businessNameTxt.Clear();
            businessNatureTxt.Clear();
            businessAddressTxt.Clear();
            grossBusinessCapitalTxt.Clear();
            averageDailyGrossSalesTxt.Clear();
        }

        private void SubmitButtonDisable()
        {
            submitButton.Enabled = false;
        }

        private void IsAllTextBoxNotEmpty()
        {
            int count = 0;
            foreach (Control item in personalInformationGroupBox.Controls)
            {
                if (item is TextBox)
                {
                    if (!string.IsNullOrEmpty(item.Text))
                    {
                        count++;
                    }
                }
            }
            if (count == 8)
            {
                submitButton.Enabled = true;
            }
            else
            {
                submitButton.Enabled = false;
            }
        }

        #endregion     

    }
}
