using System;
using System.Data;
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
        private LoanInformationRepo _loanRepo;
        #endregion

        internal DataSet OnSetGetLoanInformationUsingCustomerID(Customer customer)
        {

            _loanRepo = new LoanInformationRepo();

            try
            {
                return _loanRepo.GetLoanInformationUsingCustomerID(customer);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Data Access Denied", ex);
            }            
        }
        internal DataSet OnSetGetLoanInformationUsingCustomerName(Customer customer)
        {

            _loanRepo = new LoanInformationRepo();

            try
            {
                return _loanRepo.GetLoanInformationUsingCustomerName(customer);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Data Access Denied", ex);
            }
        }
        internal List<GetCollectionAndPenalty> OnSetGetCollectionAndPenalty(string LoanID)
        {

            _loanRepo = new LoanInformationRepo();

            try
            {
                return _loanRepo.GetCollectionAndPenalty(LoanID);
            }
            catch (FormatException ex)
            {
                throw new InvalidOperationException("String format problem", ex);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException("Data Access Denied", ex);
            }
        }
        internal string OnSetInsertLoan(Loan loan, Customer customer)
        {

            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            _loanRepo = new LoanInformationRepo();

            try
            {
                CustomerRepo customerRepo = new CustomerRepo();
                loan.Uid = Guid.NewGuid(); // load Guid
                loan.Id = idGeneratorClass.NewId(); // load new Id
                loan.CustomerUid = customerRepo.GetGuid(customer);
                _loanRepo.InsertLoanData(loan);
            }
            catch (MySqlException ex)
            {
                // throw exception here
                // do not return the exception

                return ex.ToString();
            }

            return "Loan added successfully";
        }
        internal bool OnSetIsLoanStatusUnpaid(string LoanID)
        {

            _loanRepo = new LoanInformationRepo();

            bool result = false;
            result = _loanRepo.CheckLoanUnpaid(LoanID);
            return result;
        }        
    }
}
