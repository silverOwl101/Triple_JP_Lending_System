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

        public void OnLoadData()
        {
            Loan loan = new Loan();
            Customer customer = new Customer();
            customer.Id = Iloan.CustomerID;
            LoanService loanService = new LoanService();            
            string message = loanService.OnCallInsertLoan(LoadData(loan),customer);
            MessageBox.Show(message);
        }
        private Loan LoadData(Loan loan)
        {
            loan.PaymentTerm = Iloan.PaymentTerm;
            loan.Duration = Iloan.Duration;
            loan.EffectiveDate = Iloan.EffectiveDate;
            loan.Interest = Iloan.Interest;
            loan.PrincipalLoan = Iloan.PrincipalLoan;
            loan.Penalty = Iloan.Penalty;
            return loan;
        }
    }
}
