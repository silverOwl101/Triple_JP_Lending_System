using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.Helper.View;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Presenter;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System.Forms
{
    public partial class CollectionFrm : Form , IAddCollection, ICompareCollectionAndLoan, IAddPenalty
    { 
        private FrmConvertionRequirements _frmConvertionRequirements
                                                    = new FrmConvertionRequirements();
        private FrmInputRequirements _frmInputRequirements = new FrmInputRequirements();
        private CollectionFrmData _collectionFrmData;
        private ClassComponentConcreteMediator _concreteMediator;
        private CollectionFrmPresenter _collectionFrmPresenter;
        private string _loanId;
        private string _customerName;       

        public CollectionFrm()
        {
            InitializeComponent();
            LoadData();
        }

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
            get { return dateTimePicker1.Value.Date; }
            set { dateTimePicker1.Text = value.ToString(); }
        }
        public decimal Amount
        {
            get { return Convert.ToDecimal(amountTextBox.Text); }
            set { amountTextBox.Text = value.ToString(); }
        }
        public decimal CollectionTotalAmount
        {
            get; set;
        }
        public decimal LoanTotalAmount
        {
            get; set;
        }

        #endregion
        #region IAddPenalty Properties
        public DateTime DateOfPenalty
        {
            get { return dateTimePicker2.Value.Date; }
            set { dateTimePicker2.Text = value.ToString(); }
        }
        public decimal PenaltyAmount
        {
            get { return Convert.ToDecimal(penaltyAmount.Text); }
            set { penaltyAmount.Text = value.ToString(); }
        }
        #endregion

        private void LoadData()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _collectionFrmData = new CollectionFrmData(_concreteMediator);

            _loanId = _concreteMediator.GetData(_collectionFrmData)[0];// get Loan Id
            _customerName = _concreteMediator.GetData(_collectionFrmData)[1];// get Customer Name
            LoanTotalAmount = Convert.ToDecimal(_concreteMediator.GetData(_collectionFrmData)[2]);// get total loan
            CollectionTotalAmount = Convert.ToDecimal(_concreteMediator.GetData(_collectionFrmData)[3]); // get total collection

            label1.Text = _loanId;
            label2.Text = _customerName;             
        }        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {            
            _frmInputRequirements.InputNumbersWithDecimalPlacesOnly(e, amountTextBox);
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToGeneralFormat(amountTextBox);            
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            _frmConvertionRequirements.ConvertToNumberFormat(amountTextBox);
        }
        private void CollectionFrmSubmitButton_Click(object sender, EventArgs e)
        {
            _collectionFrmPresenter = new CollectionFrmPresenter(this,this,this);

            try
            {
                if (!string.IsNullOrEmpty(amountTextBox.Text))
                {
                    _collectionFrmPresenter.AddCollection();

                    string messageContent = "Remitted successfully";
                    string messageCaption = "Remittance";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Information;
                    MessageBox(messageContent, messageCaption, button, icon);
                }
                else if(string.IsNullOrEmpty(amountTextBox.Text) && string.IsNullOrEmpty(penaltyAmount.Text))
                {
                    string messageContent = "Input remittance to proceed";
                    string messageCaption = "Input remittance";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBoxIcon icon = MessageBoxIcon.Error;
                    MessageBox(messageContent, messageCaption, button, icon);
                }
                if (!string.IsNullOrEmpty(penaltyAmount.Text))
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
        private void MessageBox(string messageContent, string messageCaption,
                                MessageBoxButtons messageBoxButton, MessageBoxIcon messageBoxIcon)
        {
            string MessageContent = messageContent;
            string MessageCaption = messageCaption;
            System.Windows.Forms.MessageBox.Show(MessageContent, MessageCaption,
                                            messageBoxButton, messageBoxIcon);
        }                
    }
}
