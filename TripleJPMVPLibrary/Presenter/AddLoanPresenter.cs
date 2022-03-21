using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Service;
using TripleJPMVPLibrary.View;
using System.Windows.Forms;

namespace TripleJPMVPLibrary.Presenter
{
    public class AddLoanPresenter
    {
        private IAddLoan _addLoan;
        private Loan _loan = new Loan();
        private Customer _customer = new Customer();
        private LoanService _loanService = new LoanService();
        public AddLoanPresenter(IAddLoan addloan)
        {
            _addLoan = addloan;
        }

        public void OnLoadData()
        {
            _customer.Id = _addLoan.CustomerID;          
            string message = _loanService.OnCallInsertLoan(LoadData(_loan), _customer);
            SuccessfulMessage(message,"Loan Recorded");
        }
        private Loan LoadData(Loan loan)
        {
            loan.PaymentTerm = _addLoan.PaymentTerm;
            loan.Duration = _addLoan.Duration;
            loan.EffectiveDate = _addLoan.EffectiveDate;
            loan.Interest = _addLoan.Interest;
            loan.PrincipalLoan = _addLoan.PrincipalLoan;
            loan.Penalty = _addLoan.Penalty;
            return loan;
        }
        private void SuccessfulMessage(string text, string messageCaption)
        {                        
            MessageBox.Show(text, messageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
