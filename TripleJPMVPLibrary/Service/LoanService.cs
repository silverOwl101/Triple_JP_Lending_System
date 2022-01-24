using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Repository;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.Generator;

namespace TripleJPMVPLibrary.Service
{
    internal class LoanService
    {
        private LoanInformationRepo _loanRepo = new LoanInformationRepo();
        internal List<GetCustomerLoanInformation> OnCallGetLoanInformation(Customer customer)
        {
            try
            {
                return _loanRepo.GetLoanInformation(customer);
            }
            catch (Exception)
            {
                throw;
            }            
        }
        internal string OnCallInsertLoan(Loan loan, Customer customer)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            try
            {
                CustomerRepo customerRepo = new CustomerRepo();
                loan.Uid = Guid.NewGuid(); // load Guid
                loan.Id = idGeneratorClass.NewId(); // load new Id
                loan.CustomerUid = customerRepo.GetGuid(customer);
                _loanRepo.InsertData(loan);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return "Success";
        }
    }
}
