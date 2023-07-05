using System;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.Forms
{
    public partial class MainApplicationFrm : Form
    {

        #region Fields

        private IFormsMediator _concreteMediator;
        private LogInFrmComponent _logInFrmComponent;
        private CustomerAccountFrmComponent _customerAccountFrmComponent;
        private LoanInformationFrmComponent _loanInformationFrmComponent;
        private PostingFrmComponent _postingFrmComponent;
        private ReportFrmDetailComponent _reportFrmDetailomponent;        
        private LoanInformationFrmPassData _loanInformationFrmPassData;
        private AddSavingsFrmComponent _addSavingsFrmComponent;
        private AddSalaryFrmComponent _addSalaryFrmComponent;

        #endregion

        public MainApplicationFrm()
        {
            InitializeComponent();
        }

        #region Form Events

        #region Menu Tool Strip

        #region Log-out code

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void addSavingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddSavingsFrm();
        }
        private void addSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddSalaryFrm();
        }
        #endregion

        #endregion

        #endregion

        #region Custom Methods

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
            _loanInformationFrmPassData = 
                                new LoanInformationFrmPassData(_concreteMediator,"", summaryReportParameter);
            _reportFrmDetailomponent = new ReportFrmDetailComponent(_concreteMediator);
            _concreteMediator.PrepareData(_loanInformationFrmPassData);
            _concreteMediator.OpenForms(_reportFrmDetailomponent, true);
        }
        private void OpenAddSavingsFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _addSavingsFrmComponent = new AddSavingsFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_addSavingsFrmComponent, true);
        }
        private void OpenAddSalaryFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _addSalaryFrmComponent = new AddSalaryFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_addSalaryFrmComponent, true);
        }
        #endregion

        
    }
}
