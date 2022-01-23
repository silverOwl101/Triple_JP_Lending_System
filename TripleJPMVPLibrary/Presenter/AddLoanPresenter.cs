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
        public AddLoanPresenter(IAddLoan addloan)
        {
            _addLoan = addloan;
        }

        public void OnLoadData()
        {
            _customer.Id = _addLoan.CustomerID;
            LoanService loanService = new LoanService();            
            string message = loanService.OnCallInsertLoan(LoadData(_loan), _customer);
            MessageBox.Show(message);
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
    }
}
