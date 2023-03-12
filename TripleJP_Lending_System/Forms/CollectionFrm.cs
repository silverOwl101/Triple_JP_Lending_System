﻿using System;
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
    public partial class CollectionFrm : Form , IAddCollection
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
        #endregion

        private void LoadData()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _collectionFrmData = new CollectionFrmData(_concreteMediator);

            _loanId = _concreteMediator.GetData(_collectionFrmData)[0];// get Loan Id
            _customerName = _concreteMediator.GetData(_collectionFrmData)[1];// get Customer Name

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
            _collectionFrmPresenter = new CollectionFrmPresenter(this);

            try
            {
                _collectionFrmPresenter.AddCollection();

                const string MessageContent = "Collection successfully added to the system.";
                const string MessageCaption = "Entry Successfully Added";
                MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }            
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
                const string MessageCaption = "System Access Denied";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
