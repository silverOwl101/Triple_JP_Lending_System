using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Repository;
using TripleJPMVPLibrary.Model;

namespace TripleJPMVPLibrary.Service
{
    class LoanService
    {
        internal List<GetCustomerLoanInformation> onCallGetLoanInformation(Customer customer)
        {
            try
            {
                LoanInformationRepo loanRepo = new LoanInformationRepo();
                return loanRepo.GetLoanInformation(customer);
            }
            catch (Exception)
            {
                throw;
            }            
        }
    }
}
