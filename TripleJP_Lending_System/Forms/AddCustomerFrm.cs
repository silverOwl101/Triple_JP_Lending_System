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
using TripleJP_Lending_System.Helper.View;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddCustomerFrm : Form, IAddCustomer
    {
        #region Fields

        private FrmInputRequirements _frmInputRequirements = new FrmInputRequirements();
        private FrmConvertionRequirements _frmConvertionRequirements = new FrmConvertionRequirements();
        private AddCustomerPresenter _addCustomerPresenter;

        #endregion

        public AddCustomerFrm()
        {            
            InitializeComponent();
            Submitbutton.Enabled = false;
            ClearTextbox();            
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
            set { GrossBusinessCapitaltxt.Text = value.ToString("G"); }
        }
        public decimal AverageDailyGrossSales
        {
            get { return Convert.ToDecimal(AverageDailyGrossSalestxt.Text); }
            set { AverageDailyGrossSalestxt.Text = value.ToString("G"); }
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
                _addCustomerPresenter.AddCustomerData();

                const string MessageContent = "Customer's information successfully added to the system.";
                const string MessageCaption = "Entry Successfully Added";
                MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextbox();
            } 
            catch (ArgumentException)
            {
                const string MessageContent = "The name of the customer has the same name recorded in the system. Would you like to continue saving the entry?";
                const string MessageCaption = "Duplicate Credentials";
                var result = MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                _addCustomerPresenter.RetryAddEntry(result);

                ClearTextbox();
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                if (ex.InnerException.HResult == -2147467259)
                {
                    const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
                    const string MessageCaption = "System Access Denied";
                    MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        #endregion

        #endregion

        #region TextBox

        #region ContactNumberTxt Events
        private void ContactNumbertxt_KeyPress(object sender, KeyPressEventArgs e)
        {            
            _frmInputRequirements.InputNumbersOnly(e);
            ContactNumbertxt.MaxLength = 14;
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
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, GrossBusinessCapitaltxt);
            GrossBusinessCapitaltxt.MaxLength = 14;            
            SubmitButtonDisable();            
        }
        private void GrossBusinessCapitaltxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(GrossBusinessCapitaltxt);
            IsAllTextBoxNotEmpty();
        }
        private void GrossBusinessCapitaltxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(GrossBusinessCapitaltxt);
        }
        #endregion

        #region AverageDailyGrossSalesTxt Events
        private void AverageDailyGrossSalestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, AverageDailyGrossSalestxt);
            AverageDailyGrossSalestxt.MaxLength = 14;
            SubmitButtonDisable();
        }
        private void AverageDailyGrossSalestxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(AverageDailyGrossSalestxt);
            IsAllTextBoxNotEmpty();
        }
        private void AverageDailyGrossSalestxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(AverageDailyGrossSalestxt);
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
            CustomerNametxt.Clear();
            CustomerAddresstxt.Clear();
            ContactNumbertxt.Clear();
            BusinessNametxt.Clear();
            BusinessNaturetxt.Clear();
            BusinessAddresstxt.Clear();
            GrossBusinessCapitaltxt.Clear();
            AverageDailyGrossSalestxt.Clear();
        }
        private void SubmitButtonDisable()
        {
            Submitbutton.Enabled = false;
        }
        private void IsAllTextBoxNotEmpty()
        {
            int count = 0;
            foreach (Control item in groupBox1.Controls)
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
                Submitbutton.Enabled = true;
            }
            else
            {
                Submitbutton.Enabled = false;
            }
        }
        #endregion     

    }
}
