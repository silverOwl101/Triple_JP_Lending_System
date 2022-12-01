using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Repository;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.Generator;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TripleJPMVPLibrary.Service
{
    internal class LoanService
    {
        #region Fields

        private LoanInformationRepo _loanRepo = new LoanInformationRepo();

        #endregion

        internal List<GetCustomerLoanInformation> OnCallGetLoanInformation(Customer customer)
        {           
            try
            {
                return _loanRepo.GetLoanInformation(customer);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Data Access Denied", ex);
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
            catch (MySqlException ex)
            {
                // throw exception here
                // do not return the exception

                return ex.ToString();
            }

            return "Loan added successfully";
        }

        internal List<GetCollectionAndPenalty> OnCallGetCollectionAndPenalty(string LoanID)
        {
            try
            {
                return _loanRepo.GetCollectionAndPenalty(LoanID);
            }
            catch (Exception)
            {
                const string MessageContent = "No records of collection yet";
                const string MessageCaption = "Collection not found";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }
        internal bool OnCallIsLoanStatusUnpaid(string LoanID)
        {
            bool result = false;
            result = _loanRepo.isLoanUnpaid(LoanID);
            return result;
        }
    }
}
