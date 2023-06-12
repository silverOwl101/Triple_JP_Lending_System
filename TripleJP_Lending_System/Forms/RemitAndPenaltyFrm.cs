using System;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.Helper.View;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Presenter;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System.Forms
{
    public partial class RemitAndPenaltyFrm : Form, IAddCollection, ICompareCollectionAndLoan, IAddPenalty
    {

        #region Fields

        private FrmConvertionRequirements _frmConvertionRequirements = new FrmConvertionRequirements();
        private FrmInputRequirements _frmInputRequirements = new FrmInputRequirements();
        private CollectionFrmData _collectionFrmData;
        private ClassComponentConcreteMediator _concreteMediator;
        private CollectionFrmPresenter _collectionFrmPresenter;
        private string _loanId;
        private string _customerName;
        private decimal _loanTotalAmount;
        private decimal _totalRemmitance;
        private decimal remainingCredit;

        #endregion

        public RemitAndPenaltyFrm()
        {
            InitializeComponent();
            LoadData();
        }

        #region User Inputs

        #region IAddCollection Properties

        public string LoanId
        {
            get { return _loanId; }
            set { _loanId = value; }
        }
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public DateTime Date
        {
            get { return remitDateTimePicker.Value.Date; }
            set { remitDateTimePicker.Text = value.ToString(); }
        }
        public decimal Amount
        {
            get { return Convert.ToDecimal(remitAmountTextBox.Text); }
            set { remitAmountTextBox.Text = value.ToString(); }
        }      

        #endregion

        #region IAddPenalty Properties

        public DateTime DateOfPenalty
        {
            get { return penaltyDateTimePicker.Value.Date; }
            set { penaltyDateTimePicker.Text = value.ToString(); }
        }
        public decimal PenaltyAmount
        {
            get { return Convert.ToDecimal(penaltyAmountTextBox.Text); }
            set { penaltyAmountTextBox.Text = value.ToString(); }
        }

        public decimal loanAmount
        {
            get;
            set;
        }

        #endregion

        #endregion

        #region Form Events

        #region Buttons

        #region Savebutton Events

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _collectionFrmPresenter = new CollectionFrmPresenter(this, this, this);

            try
            {
                if (!string.IsNullOrEmpty(remitAmountTextBox.Text))
                {
                    LoadAddCollectionCondition();
                }
                else if (string.IsNullOrEmpty(remitAmountTextBox.Text) && string.IsNullOrEmpty(penaltyAmountTextBox.Text))
                {
                    string messageContent = "Input remittance or penalty amount to proceed";
                    string messageCaption = "Input remittance/penalty";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox(messageContent, messageCaption, button, icon);
                }
                if (!string.IsNullOrEmpty(penaltyAmountTextBox.Text))
                {
                    _collectionFrmPresenter.AddPenalty();

                    string messageContent = "Penalty added";
                    string messageCaption = "Penalty";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox(messageContent, messageCaption, button, icon);
                }
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                string messageContent = "There is a problem to the system please contact" +
                                        "your I.T officer for further information.";
                string messageCaption = "System Access Denied";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Error;
                MessageBox(messageContent, messageCaption, button, icon);
            }
        }

        #endregion

        #endregion

        #region TextBox

        #region RemitTextBox Events

        private void RemitTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, remitAmountTextBox);
        }

        private void RemitTextBox_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(remitAmountTextBox);
        }

        private void RemitTextBox_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(remitAmountTextBox);
        }

        #endregion

        #region RemitAmountTextBox Events

        private void RemitAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(remitAmountTextBox.Text))
            {
                decimal calculateCredit = remainingCredit - Convert.ToDecimal(remitAmountTextBox.Text);
                remainingCreditLabel.Text = String.Format("{0:N}", calculateCredit);
            }
            else
            {
                remainingCreditLabel.Text = String.Format("{0:N}", remainingCredit);
            }
        }

        #endregion

        #region PenaltyAmountTextBox

        private void PenaltyAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(penaltyAmountTextBox.Text))
            {
                decimal getPenalty = _collectionFrmPresenter.GetPenalty();
                decimal calculatePenalty = getPenalty + Convert.ToDecimal(penaltyAmountTextBox.Text);
                penaltyLabel.Text = String.Format("{0:N}", calculatePenalty);
            }
            else
            {
                penaltyLabel.Text = String.Format("{0:N}", _collectionFrmPresenter.GetPenalty());
            }
        }

        #endregion

        #endregion

        #endregion

        #region Custom Methods

        private void LoadData()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _collectionFrmData = new CollectionFrmData(_concreteMediator);

            _loanId = _concreteMediator.GetData(_collectionFrmData)[0];// get Loan Id
            _customerName = _concreteMediator.GetData(_collectionFrmData)[1];// get Customer Name                       
            _loanTotalAmount = Convert.ToDecimal(_concreteMediator.GetData(_collectionFrmData)[2]);// get Loan Total Amount
            _totalRemmitance = Convert.ToDecimal(_concreteMediator.GetData(_collectionFrmData)[3]);// get Collection Total Amount

            loanIdlabel.Text = _loanId;
            customerNameLabel.Text = _customerName;
            loanAmount = _loanTotalAmount;
            loanBalanceLabel.Text = String.Format("{0:N}", loanAmount);
            _collectionFrmPresenter = new CollectionFrmPresenter(this);
            penaltyLabel.Text = String.Format("{0:N}", _collectionFrmPresenter.GetPenalty());
            decimal totalAmountDue = Convert.ToDecimal(loanBalanceLabel.Text) +
                                     Convert.ToDecimal(penaltyLabel.Text);
            remainingCredit = totalAmountDue - _totalRemmitance;
            remainingCreditLabel.Text = String.Format("{0:N}", remainingCredit);
            remittanceLabel.Text = String.Format("{0:N}", _totalRemmitance);
            totalAmountDueLabel.Text = String.Format("{0:N}", totalAmountDue);
        }

        private void LoadAddCollectionCondition()
        {
            if (_collectionFrmPresenter.AddCollection())
            {
                string messageContent = "Remitted successfully";
                string messageCaption = "Remittance";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBoxIcon icon = MessageBoxIcon.Information;
                MessageBox(messageContent, messageCaption, button, icon);
            }
            else
            {
                string messageContent = "Please check if the amount entered is greater than the remaining balance";
                string messageCaption = "Task Error";
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

        #endregion

    }
}
