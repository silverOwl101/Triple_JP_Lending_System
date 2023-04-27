﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.Forms
{
    public partial class MainApplicationFrm : Form
    {
        #region Private Fields
        private IFormsMediator _concreteMediator;
        private LogInFrmComponent _logInFrmComponent;
        private CustomerAccountFrmComponent _customerAccountFrmComponent;
        private LoanInformationFrmComponent _loanInformationFrmComponent;
        private PostingFrmComponent _postingFrmComponent;
        private ReportFrmComponent _reportFrmComponent;
        private MainApplicationFrmPassData _mainApplicationFrmPassData;
        #endregion
        public MainApplicationFrm()
        {
            InitializeComponent();
        }
        #region Log-out code
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadLogInFrm()
        {            
            Hide();
            _concreteMediator = new ClassComponentConcreteMediator();
            _logInFrmComponent = new LogInFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_logInFrmComponent, true);
            Close();            
        }
        #endregion
        #region MainFrm Tool strip
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCustomerAccountFrm();
        }
        private void loanInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoanInformationFrm();
        }
        private void postingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPostingFrm();
        }
        private void MainApplicationFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadLogInFrm();
        }
        private void collectionReportSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenSummaryReport();
        }
        private void collectionReportDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OpenDetailReport();
        }
        #endregion
        #region Methods for opening forms
        private void OpenCustomerAccountFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _customerAccountFrmComponent = new CustomerAccountFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_customerAccountFrmComponent, true);
        }
        private void OpenLoanInformationFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _loanInformationFrmComponent = new LoanInformationFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_loanInformationFrmComponent, true);
        }
        private void OpenPostingFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _postingFrmComponent = new PostingFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_postingFrmComponent, true);
        }
        private void OpenSummaryReport()
        {
            const string summaryReportParameter = "SummaryReport";
            _concreteMediator = new ClassComponentConcreteMediator();
            _mainApplicationFrmPassData = 
                                new MainApplicationFrmPassData(_concreteMediator, summaryReportParameter);
            _reportFrmComponent = new ReportFrmComponent(_concreteMediator);
            _concreteMediator.PrepareData(_mainApplicationFrmPassData);
            _concreteMediator.OpenForms(_reportFrmComponent, true);
        }
        //private void OpenDetailReport()
        //{
        //    string detailReportParameter = "DetailReport";
        //    _concreteMediator = new ClassComponentConcreteMediator();
        //    _mainApplicationFrmPassData =
        //                        new MainApplicationFrmPassData(_concreteMediator, detailReportParameter);
        //    _reportFrmComponent = new ReportFrmComponent(_concreteMediator);
        //    _concreteMediator.PrepareData(_mainApplicationFrmPassData);
        //    _concreteMediator.OpenForms(_reportFrmComponent, true);
        //}
        #endregion        
    }
}
