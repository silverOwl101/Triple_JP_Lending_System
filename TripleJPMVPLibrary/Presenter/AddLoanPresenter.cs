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
        private const string _status = "Unpaid";
        public AddLoanPresenter(IAddLoan addloan)
        {
            _addLoan = addloan;
        }

        public void OnLoadData()
        {
            _customer.Id = _addLoan.CustomerID;
            
            if (_loanService.OnCallIsLoanStatusUnpaid(_addLoan.CustomerID, _status) is true)
            {
                ErrorMessage("Customer has pending loan", "Cannot Add loan");
            }
            else
            {
                string message = _loanService.OnCallInsertLoan(LoadData(_loan), _customer);
                SuccessfulMessage(message, "Loan Recorded");
            }            
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
        private void ErrorMessage(string text, string messageCaption)
        {
            MessageBox.Show(text, messageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
