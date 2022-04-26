using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Repository;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.Generator;
using MySql.Data.MySqlClient;

namespace TripleJPMVPLibrary.Service
{
    public class CustomerService
    {
        #region Fields

        private CustomerRepo _customerRepo;

        #endregion

        public bool IsNameDuplicate(string name)
        {
            _customerRepo = new CustomerRepo();

            try
            {
                if(_customerRepo.IsDuplicateName(name) is true)
                {
                    throw new ArgumentException(" Duplicate Name ", name);
                } 
                else
                {
                    return false;
                }
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }

        public string PrepareData(Customer customer, CustomerBusinessInformation customerBusinessInformation)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            customer.Uid = Guid.NewGuid();
            customer.Id = idGeneratorClass.NewId();
            customerBusinessInformation.Uid = Guid.NewGuid();
            customerBusinessInformation.Id = idGeneratorClass.NewId();
            _customerRepo = new CustomerRepo();

            #region Check id if valid

            while (_customerRepo.IsDuplicateUid(customer.Uid))
            {
                customer.Uid = Guid.NewGuid();
            }
            while (_customerRepo.IsDuplicateId(customer.Id))
            {
                customer.Id = idGeneratorClass.NewId();
            }
            while (_customerRepo.IsDuplicateBusinessId(customerBusinessInformation.Id))
            {
                customerBusinessInformation.Id = idGeneratorClass.NewId();
            }
            while (_customerRepo.IsDuplicateBusinessGuid(customerBusinessInformation.Uid))
            {
                customerBusinessInformation.Uid = Guid.NewGuid();
            }

            #endregion

            try
            {
                _customerRepo.InsertData(customer,customerBusinessInformation);
                return "Entry recorded successfully";
            }
            catch (Exception)
            {
                throw;
            }                        
        }
        public List<GetCustomerInfo> GetCustomerList(Customer customer)
        {
            _customerRepo = new CustomerRepo();

            try
            {
                return _customerRepo.GetList(customer);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Database Access Denied ", ex);
            }
        }
        internal string UpdateService(Customer customer,CustomerBusinessInformation businessInformation)
        {
            _customerRepo = new CustomerRepo();
            string confirmationMessage = "Data updated";

            try
            {
                CustomerRepo customerRepo = new CustomerRepo();
                customerRepo.UpdateData(customer, businessInformation);
            }
            catch (Exception)
            {

                throw;
            }
            return confirmationMessage;
        }
    }
}
