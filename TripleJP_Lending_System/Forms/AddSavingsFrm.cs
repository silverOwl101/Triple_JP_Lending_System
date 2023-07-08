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
    public partial class AddSavingsFrm : Form, IAddAmountAndDate
    {
        AddSavingsPresenter _savingsPresenter;
        private FrmInputRequirements frmInputRequirements = new FrmInputRequirements();
        private FrmConvertionRequirements _frmConvertionRequirements = new FrmConvertionRequirements();

        decimal savingsFormat = 0;
        decimal totalDailyCollection = 0;
        decimal totalSalaryRemitted = 0;
        decimal totalSavingsRemitted = 0;
        decimal totalRemainingCollection = 0;

        public AddSavingsFrm()
        {
            InitializeComponent();
            DefaultProperties();
        }

        public decimal Amount
        {
            get { return Convert.ToDecimal(remitSavingsAmountTextBox.Text); }
            set { remitSavingsAmountTextBox.Text = value.ToString(); }
        }
        public DateTime Date
        {
            get { return remitSavingsDateTimePicker.Value.Date; }
            set { remitSavingsAmountTextBox.Text = value.ToString(); }
        }

        private void DefaultProperties()
        {            
            _savingsPresenter = new AddSavingsPresenter();

            #region Calculation Display
            if (_savingsPresenter.DailyTotalCollection(remitSavingsDateTimePicker.Value.Date) != 0)
            {
                totalDailyCollection =
                        _savingsPresenter.DailyTotalCollection(remitSavingsDateTimePicker.Value.Date);
            }
            else
            {
                totalDailyCollection = 0;
            }

            if (_savingsPresenter.TotalSalaryRemitted(remitSavingsDateTimePicker.Value.Date) != 0)
            {
                totalSalaryRemitted =
                        _savingsPresenter.TotalSalaryRemitted(remitSavingsDateTimePicker.Value.Date);
            }
            else
            {
                totalSalaryRemitted = 0;
            }

            if (_savingsPresenter.TotalSavingsRemitted(remitSavingsDateTimePicker.Value.Date) != 0)
            {
                totalSavingsRemitted =
                        _savingsPresenter.TotalSavingsRemitted(remitSavingsDateTimePicker.Value.Date);
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
        }

        private void remitButton_Click(object sender, EventArgs e)
        {
            _savingsPresenter = new AddSavingsPresenter(this);

            if (_savingsPresenter.Remit())
            {
                string messageContent = "Savings Remitted successfully";
                string messageCaption = "Savings Remittance";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox(messageContent, messageCaption, button, icon);
            }
            else
            {
                string messageContent = "Please check the date and amout to proceed";
                string messageCaption = "Savings Remit Error";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox(messageContent, messageCaption, button, icon);
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

        private void remitSavingsAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, remitSavingsAmountTextBox);
        }

        private void remitSavingsAmountTextBox_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(remitSavingsAmountTextBox);
        }

        private void remitSavingsAmountTextBox_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(remitSavingsAmountTextBox);
        }

        private void remitSavingsDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DefaultProperties();
        }

        private void remitSavingsAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(remitSavingsAmountTextBox.Text))
            {
                savingsFormat = Convert.ToDecimal(remitSavingsAmountTextBox.Text);
                savingsCalculationLabel.Text = savingsFormat.ToString("N");
                decimal rslt = totalRemainingCollection - savingsFormat;
                totalCollectionLabel.Text = rslt.ToString("N");
            }
            else
            {
                savingsCalculationLabel.Text = totalSavingsRemitted.ToString("N");
                totalCollectionLabel.Text = totalRemainingCollection.ToString("N");
            }            
        }
    }
}
