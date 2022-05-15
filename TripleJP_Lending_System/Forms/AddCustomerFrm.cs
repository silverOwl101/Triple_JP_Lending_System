﻿using System;
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

        private FrmInputRequirements _frmInputRequirements;
        private FrmConvertionRequirements _frmConvertionRequirements;
        private AddCustomerPresenter _addCustomerPresenter;

        #endregion

        public AddCustomerFrm()
        {            
            InitializeComponent();
            SubmitButton.Enabled = false;
            ClearTextbox();            
        }

        #region User Inputs

        public string CustomerName 
        {
            get { return CustomerNameTxt.Text; }
            set { CustomerNameTxt.Text = value; }
        }
        public string CustomerAddress
        {
            get { return CustomerAddressTxt.Text; }
            set { CustomerAddressTxt.Text = value; }
        }
        public string ContactNumber
        {
            get { return ContactNumberTxt.Text; }
            set { ContactNumberTxt.Text = value; }
        }
        public string BusinessName
        {
            get { return BusinessAddressTxt.Text; }
            set { BusinessAddressTxt.Text = value; }
        }
        public string BusinessNature
        {
            get { return BusinessNatureTxt.Text; }
            set { BusinessNatureTxt.Text = value; }
        }
        public string BusinessAddress
        {
            get { return BusinessAddressTxt.Text; }
            set { BusinessAddressTxt.Text = value; }
        }
        public decimal GrossBusinessCapital
        {
            get { return Convert.ToDecimal(GrossBusinessCapitalTxt.Text); }
            set { GrossBusinessCapitalTxt.Text = value.ToString("G"); }
        }
        public decimal AverageDailyGrossSales
        {
            get { return Convert.ToDecimal(AverageDailyGrossSalesTxt.Text); }
            set { AverageDailyGrossSalesTxt.Text = value.ToString("G"); }
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
            catch (ArgumentException ex) when (ex.ParamName is "Name")
            {
                const string MessageContent = "The name of the customer has the same name recorded in the system. Would you like to continue saving the entry?";
                const string MessageCaption = "Duplicate Credentials";
                var result = MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                _addCustomerPresenter.RetryAddEntry(result);

                ClearTextbox();
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
            ContactNumberTxt.MaxLength = 14;
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
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, GrossBusinessCapitalTxt);
            GrossBusinessCapitalTxt.MaxLength = 14;            
            SubmitButtonDisable();            
        }
        private void GrossBusinessCapitaltxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToNumberFormat(GrossBusinessCapitalTxt);
            IsAllTextBoxNotEmpty();
        }
        private void GrossBusinessCapitaltxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToGeneralFormat(GrossBusinessCapitalTxt);
        }

        #endregion

        #region AverageDailyGrossSalesTxt Events

        private void AverageDailyGrossSalestxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements = new FrmInputRequirements();
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, AverageDailyGrossSalesTxt);
            AverageDailyGrossSalesTxt.MaxLength = 14;
            SubmitButtonDisable();
        }
        private void AverageDailyGrossSalestxt_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToNumberFormat(AverageDailyGrossSalesTxt);
            IsAllTextBoxNotEmpty();
        }
        private void AverageDailyGrossSalestxt_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements = new FrmConvertionRequirements();
            _frmConvertionRequirements.ConvertToGeneralFormat(AverageDailyGrossSalesTxt);
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
            CustomerNameTxt.Clear();
            CustomerAddressTxt.Clear();
            ContactNumberTxt.Clear();
            BusinessNameTxt.Clear();
            BusinessNatureTxt.Clear();
            BusinessAddressTxt.Clear();
            GrossBusinessCapitalTxt.Clear();
            AverageDailyGrossSalesTxt.Clear();
        }

        private void SubmitButtonDisable()
        {
            SubmitButton.Enabled = false;
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
                SubmitButton.Enabled = true;
            }
            else
            {
                SubmitButton.Enabled = false;
            }
        }

        #endregion     

    }
}
