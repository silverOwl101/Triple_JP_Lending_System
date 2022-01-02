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
        internal string onCallInsertLoan(Loan loan,Customer customer)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            try
            {
                CustomerRepo customerRepo = new CustomerRepo();
                loan.uid = Guid.NewGuid(); // load Guid
                loan.id = idGeneratorClass.NewId(); // load new id
                loan.customeUid = customerRepo.GetGuid(customer);
                LoanInformationRepo loanRepo = new LoanInformationRepo();
                loanRepo.InsertData(loan);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }

            return "Success";
        }
    }
}
