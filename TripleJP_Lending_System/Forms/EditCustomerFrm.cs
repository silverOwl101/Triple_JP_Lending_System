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
using TripleJP_Lending_System.Helper.View;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System.Forms
{
    public partial class EditCustomerFrm : Form, IEditCustomer
    {
        #region Fields

        private string[] _loadData;
        private EditCustomerFrmData _editCustomerFrmData;
        private ClassComponentConcreteMediator _concreteMediator;
        private FrmInputRequirements _frmInputRequirements;
        private FrmConvertionRequirements _frmConvertionRequirements;
        private CustomerEditPresenter _editPresenter;

        #endregion

        public EditCustomerFrm()
        {
            InitializeComponent();
            _concreteMediator = new ClassComponentConcreteMediator();
            _editCustomerFrmData = new EditCustomerFrmData(_concreteMediator);
            _loadData = _concreteMediator.GetData(_editCustomerFrmData);            
            LoadCustomerInformation();
        }

        #region User Inputs        
        public string CustomerName
        {
            get { return customerNameTextBox.Text; }
            set { customerNameTextBox.Text = value; }
        }
        public string CustomerAddress
        {
            get { return customerAddressTextBox.Text; }
            set { customerAddressTextBox.Text = value; }
        }
        public string ContactNumber
        {
            get { return contactNumberTextBox.Text; }
            set { contactNumberTextBox.Text = value; }
        }
        public string BusinessName
        {
            get { return businessAddressTextBox.Text; }
            set { businessAddressTextBox.Text = value; }
        }
        public string BusinessNature
        {
            get { return businessNatureTextBox.Text; }
            set { businessNatureTextBox.Text = value; }
        }
        public string BusinessAddress
        {
            get { return businessAddressTextBox.Text; }
            set { businessAddressTextBox.Text = value; }
        }
        public decimal GrossBusinessCapital
        {
            get { return Convert.ToDecimal(grossBusinessCapitalTextBox.Text); }
            set { grossBusinessCapitalTextBox.Text = value.ToString(); }
        }
        public decimal AverageDailyGrossSales
        {
            get { return Convert.ToDecimal(averageDailyGrossSalesTextBox.Text); }
            set { averageDailyGrossSalesTextBox.Text = value.ToString(); }
        }

        #endregion

        #region Form Events

        #region Buttons

        #region Submitbutton Events

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            _editPresenter = new CustomerEditPresenter(this);

            try
            {
                _editPresenter.UpdateCustomerInfo();

                const string MessageContent = "Customer's information successfully updated to the system.";
                const string MessageCaption = "Entry Successfully Updated";
                MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);

                Close();
            } 
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
                const string MessageCaption = "System Access Denied";
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
            contactNumberTextBox.MaxLength = 14;
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
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, grossBusinessCapitalTextBox);
            grossBusinessCapitalTextBox.MaxLength = 14;
            SubmitButtonDisable();
        }
        private void GrossBusinessCapitaltxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToNumberFormat(grossBusinessCapitalTextBox);
            IsAllTextBoxNotEmpty();
        }
        private void GrossBusinessCapitaltxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToGeneralFormat(grossBusinessCapitalTextBox);
        }

        #endregion

        #region AverageDailyGrossSalesTxt Events

        private void AverageDailyGrossSalestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements = new FrmInputRequirements();
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, averageDailyGrossSalesTextBox);
            averageDailyGrossSalesTextBox.MaxLength = 14;
            SubmitButtonDisable();
        }
        private void AverageDailyGrossSalestxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToNumberFormat(averageDailyGrossSalesTextBox);
            IsAllTextBoxNotEmpty();
        }
        private void AverageDailyGrossSalestxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToGeneralFormat(averageDailyGrossSalesTextBox);
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

        public string ID // To be pass to the presenter
        {
            get { return _loadData[0]; }
            set { _loadData[0] = value; }
        }

        private void LoadCustomerInformation()
        {
            customerNameTextBox.Text = _loadData[1];
            customerAddressTextBox.Text = _loadData[2];
            contactNumberTextBox.Text = _loadData[3];
            businessNameTextBox.Text = _loadData[4];
            businessNatureTextBox.Text = _loadData[5];
            businessAddressTextBox.Text = _loadData[6];
            grossBusinessCapitalTextBox.Text = _loadData[7];
            averageDailyGrossSalesTextBox.Text = _loadData[8];
        }
        private void SubmitButtonDisable()
        {
            submitButton.Enabled = false;
        }
        private void IsAllTextBoxNotEmpty()
        {
            int count = 0;
            foreach (Control item in personalInfoGroupBox.Controls)
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
