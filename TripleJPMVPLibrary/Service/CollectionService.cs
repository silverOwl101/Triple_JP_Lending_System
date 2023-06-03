using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Repository;
using TripleJPUtilityLibrary.Generator;

namespace TripleJPMVPLibrary.Service
{
    internal class CollectionService
    {
        private CollectionRepo _collectionRepo;
        private LoanInformationRepo _loanInformationRepo;
        private GetCustomerLoanInformation _customerLoanInfo = new GetCustomerLoanInformation();        
        private CustomerRepo _customerRepo;

        public void AddCollection(Collection collection, Customer customer, Loan loan) 
        {         
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();            
            _customerRepo = new CustomerRepo();

            collection.Uid = Guid.NewGuid();
            collection.Id = idGeneratorClass.NewId();            
            _collectionRepo = new CollectionRepo();
            _loanInformationRepo = new LoanInformationRepo();

            _customerLoanInfo = _loanInformationRepo.GetLoanInformation(loan);
            customer.Id = _customerLoanInfo.CustomerID;
            string guid = _customerRepo.GetGuid(customer);
            customer.Uid = Guid.Parse(guid);
            loan.Id = _customerLoanInfo.Id;
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));

            while (_collectionRepo.IsDuplicateUid(collection.Uid))
            {
                collection.Uid = Guid.NewGuid();
            }
            while (_collectionRepo.IsDuplicateId(collection.Id))
            {
                collection.Id = idGeneratorClass.NewId();
            }

            try
            {
                _collectionRepo.InsertCollection(collection,customer,loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public void AddPenalty(Penalty penalty, Customer customer, Loan loan)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            _customerRepo = new CustomerRepo();

            penalty.Uid = Guid.NewGuid();
            penalty.Id = idGeneratorClass.NewId();
            _collectionRepo = new CollectionRepo();
            _loanInformationRepo = new LoanInformationRepo();

            _customerLoanInfo = _loanInformationRepo.GetLoanInformation(loan);
            customer.Id = _customerLoanInfo.CustomerID;
            string guid = _customerRepo.GetGuid(customer);
            customer.Uid = Guid.Parse(guid);
            loan.Id = _customerLoanInfo.Id;
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));

            while (_collectionRepo.IsDuplicateUid(penalty.Uid))
            {
                penalty.Uid = Guid.NewGuid();
            }
            while (_collectionRepo.IsDuplicateId(penalty.Id))
            {
                penalty.Id = idGeneratorClass.NewId();
            }

            try
            {
                _collectionRepo.InsertPenalty(penalty, customer, loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        public void LoanStatusUpdate(Loan loan)
        {
            try
            {
                _collectionRepo = new CollectionRepo();
                _collectionRepo.LoanFullyPaidUpdate(loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }
        public decimal GetCollection(Loan loan)
        {
            _loanInformationRepo = new LoanInformationRepo();
            _collectionRepo = new CollectionRepo();
            _customerLoanInfo = _loanInformationRepo.GetLoanInformation(loan);
            loan.Id = _customerLoanInfo.Id;
            loan.Uid = Guid.Parse(_loanInformationRepo.GetGuid(loan));

            return _collectionRepo.GetTotalCollection(loan);
        }
    }
}
