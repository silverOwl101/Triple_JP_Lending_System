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

namespace TripleJP_Lending_System.Forms
{
    public partial class MainApplicationFrm : Form
    {        
        private LogInFrmMediatorComponent logInFrmMediatorComponent;
        private LogInFrmConcreteMediator logInFrmConcreteMediator;
        private CustomerAccountFrmComponent customerAccountFrmComponent;
        private CustomerAccountFrmConcreteMediator customerAccountFrmConcreteMediator;
        private LoanInformationFrmComponent loanInformationFrmComponent;
        private LoanInformationFrmConcreteMediator loanInformationFrmConcreteMediator;
        public MainApplicationFrm()
        {
            InitializeComponent();
        }
        #region Log out code
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLogInFrm();
        }
        private void LoadLogInFrm()
        {
            logInFrmMediatorComponent = new LogInFrmMediatorComponent();
            logInFrmConcreteMediator = new LogInFrmConcreteMediator(logInFrmMediatorComponent);
            logInFrmMediatorComponent.OpenForm(true);
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
            customerAccountFrmComponent = new CustomerAccountFrmComponent();
            customerAccountFrmConcreteMediator = 
                            new CustomerAccountFrmConcreteMediator(customerAccountFrmComponent);
            customerAccountFrmComponent.OpenForm();
        }
        private void OpenLoanInformationFrm()
        {
            loanInformationFrmComponent = new LoanInformationFrmComponent();
            loanInformationFrmConcreteMediator = 
                            new LoanInformationFrmConcreteMediator(loanInformationFrmComponent);
            loanInformationFrmComponent.OpenForm();
        }
        #endregion
    }
}
