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
        IAddLoan Iloan;
        public AddLoanPresenter(IAddLoan loan)
        {
            Iloan = loan;
        }

        public void onLoadData()
        {
            Loan loan = new Loan();
            Customer customer = new Customer();
            customer.id = Iloan.customerID;
            LoanService loanService = new LoanService();            
            string message = loanService.onCallInsertLoan(loadData(loan),customer);
            MessageBox.Show(message);
        }
        private Loan loadData(Loan loan)
        {
            loan.paymentTerm = Iloan.paymentTerm;
            loan.duration = Iloan.duration;
            loan.effectiveDate = Iloan.effectiveDate;
            loan.interest = Iloan.interest;
            loan.principalLoan = Iloan.principalLoan;
            loan.penalty = Iloan.penalty;
            return loan;
        }
    }
}
