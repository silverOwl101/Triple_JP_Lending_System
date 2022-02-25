using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        IFormsMediator conCreteMediator;
        LogInFrmComponent logInFrmComponent;
        CustomerAccountFrmComponent customerAccountFrmComponent;
        LoanInformationFrmComponent loanInformationFrmComponent;
        public MainApplicationFrm()
        {
            InitializeComponent();
        }
        #region Log-out code
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLogInFrm();
        }
        private void LoadLogInFrm()
        {
            Hide();
            conCreteMediator = new ClassComponentConcreteMediator();
            logInFrmComponent = new LogInFrmComponent(conCreteMediator);
            conCreteMediator.OpenForms(logInFrmComponent,true);
            Close();
        }        
        #endregion
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCustomerAccountFrm();
        }
        private void loanInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenLoanInformationFrm();
        }
        #region Methods for opening forms
        private void OpenCustomerAccountFrm()
        {
            conCreteMediator = new ClassComponentConcreteMediator();
            customerAccountFrmComponent = new CustomerAccountFrmComponent(conCreteMediator);
            conCreteMediator.OpenForms(customerAccountFrmComponent,true);
        }
        private void OpenLoanInformationFrm()
        {
            conCreteMediator = new ClassComponentConcreteMediator();
            loanInformationFrmComponent = new LoanInformationFrmComponent(conCreteMediator);
            conCreteMediator.OpenForms(loanInformationFrmComponent, true);
        }
        #endregion
    }
}
