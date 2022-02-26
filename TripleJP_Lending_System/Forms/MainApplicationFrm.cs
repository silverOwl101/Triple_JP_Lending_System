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
        private IFormsMediator _concreteMediator;
        private LogInFrmComponent _logInFrmComponent;
        private CustomerAccountFrmComponent _customerAccountFrmComponent;
        private LoanInformationFrmComponent _loanInformationFrmComponent;
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
            _concreteMediator = new ClassComponentConcreteMediator();
            _logInFrmComponent = new LogInFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_logInFrmComponent, true);
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
        #endregion
    }
}
