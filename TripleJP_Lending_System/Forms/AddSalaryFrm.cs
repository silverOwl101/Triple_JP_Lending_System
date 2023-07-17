using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.Helper.View;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class AddSalaryFrm : Form, IAddAmountAndDate
    {
        AddSalaryPresenter _salaryPresenter;
        private FrmInputRequirements frmInputRequirements = new FrmInputRequirements();
        private FrmConvertionRequirements _frmConvertionRequirements = new FrmConvertionRequirements();

        decimal format = 0;
        decimal totalDailyCollection = 0;
        decimal totalSalaryRemitted = 0;
        decimal totalSavingsRemitted = 0;
        decimal totalRemainingCollection = 0;

        public AddSalaryFrm()
        {
            InitializeComponent();
            DefaultProperties();
        }
        public decimal Amount 
        {
            get { return Convert.ToDecimal(salaryAmountTextBox.Text); }
            set { salaryAmountTextBox.Text = value.ToString(); }
        }
        public DateTime Date
        {
            get { return remitSalaryDateTimePicker.Value.Date; }
            set { remitSalaryDateTimePicker.Text = value.ToString(); }
        }
        private void DefaultProperties()
        {         
            _salaryPresenter = new AddSalaryPresenter();

            #region Calculation Display
            if (_salaryPresenter.DailyTotalCollection(remitSalaryDateTimePicker.Value.Date) != 0)
            {
                totalDailyCollection =
                        _salaryPresenter.DailyTotalCollection(remitSalaryDateTimePicker.Value.Date);
            }
            else
            {
                totalDailyCollection = 0;
            }

            if (_salaryPresenter.TotalSalaryRemitted(remitSalaryDateTimePicker.Value.Date) != 0)
            {
                totalSalaryRemitted =
                        _salaryPresenter.TotalSalaryRemitted(remitSalaryDateTimePicker.Value.Date);
            }
            else
            {
                totalSalaryRemitted = 0;
            }

            if (_salaryPresenter.TotalSavingsRemitted(remitSalaryDateTimePicker.Value.Date) != 0)
            {
                totalSavingsRemitted =
                        _salaryPresenter.TotalSavingsRemitted(remitSalaryDateTimePicker.Value.Date);
            }
            else
            {
                totalSavingsRemitted = 0;
            }
            #endregion

            totalRemainingCollection = totalDailyCollection - (totalSalaryRemitted + totalSavingsRemitted);
            totalCollectionLabel.Text = totalRemainingCollection.ToString("N");
            salaryCalculationLabel.Text = totalSalaryRemitted.ToString("N");
            savingsCalculationLabel.Text = totalSavingsRemitted.ToString("N");
            if (salaryCalculationLabel.Text == "0.00" && totalCollectionLabel.Text != "0.00")
            {
                salaryAmountTextBox.Enabled = true;
            }
            else
            {
                salaryAmountTextBox.Enabled = false;
            }
        }
        private void remitButton_Click(object sender, EventArgs e)
        {
            _salaryPresenter = new AddSalaryPresenter(this);
            
            if (_salaryPresenter.Remit())
            {
                string messageContent = "Salary Remitted successfully";
                string messageCaption = "Salary Remittance";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox(messageContent, messageCaption, button, icon);
                salaryAmountTextBox.Text = "";
                DefaultProperties();
            }
            else
            {
                string messageContent = "Please check the date and amout to proceed";
                string messageCaption = "Salary Remit Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox(messageContent, messageCaption, button, icon);
                DefaultProperties();
            }
        }
        private void MessageBox(string messageContent, string messageCaption,
                                MessageBoxButtons messageBoxButton, MessageBoxIcon messageBoxIcon)
        {
            string MessageContent = messageContent;
            string MessageCaption = messageCaption;
            System.Windows.Forms.MessageBox.Show(MessageContent, MessageCaption,
                                            messageBoxButton, messageBoxIcon);
        }

        private void salaryAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e,salaryAmountTextBox);
        }

        private void salaryAmountTextBox_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(salaryAmountTextBox);
        }

        private void salaryAmountTextBox_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(salaryAmountTextBox);
        }

        private void remitSalaryDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DefaultProperties();
        }

        private void salaryAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(salaryAmountTextBox.Text))
            {
                format = Convert.ToDecimal(salaryAmountTextBox.Text);
                salaryCalculationLabel.Text = format.ToString("N");
                decimal rslt = totalRemainingCollection - format;
                totalCollectionLabel.Text = rslt.ToString("N");
            }
            else
            {
                salaryCalculationLabel.Text = totalSalaryRemitted.ToString("N");
                totalCollectionLabel.Text = totalRemainingCollection.ToString("N");
            }
        }
    }
}
