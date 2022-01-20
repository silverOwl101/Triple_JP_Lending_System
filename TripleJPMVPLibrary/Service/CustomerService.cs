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
    public class CustomerService
    {
        CustomerRepo customerRepo = new CustomerRepo();        
        public bool CheckDuplicateName(string name)
        {
            if (customerRepo.IsDuplicateName(name))
                return true;
            else
                return false;
        }
        public string PrepareData(Customer customer,
                                  CustomerBusinessInformation customerBusinessInformation)
        {
            IdGeneratorClass idGeneratorClass = new IdGeneratorClass();
            customer.Uid = Guid.NewGuid();
            customer.Id = idGeneratorClass.NewId();
            customerBusinessInformation.Uid = Guid.NewGuid();
            customerBusinessInformation.Id = idGeneratorClass.NewId();
            #region Check id if valid
            while (customerRepo.IsDuplicateUid(customer.Uid))
            {
                customer.Uid = Guid.NewGuid();
            }
            while (customerRepo.IsDuplicateId(customer.Id))
            {
                customer.Id = idGeneratorClass.NewId();
            }
            while (customerRepo.IsDuplicateBusinessId(customerBusinessInformation.Id))
            {
                customerBusinessInformation.Id = idGeneratorClass.NewId();
            }
            while (customerRepo.IsDuplicateBusinessGuid(customerBusinessInformation.Uid))
            {
                customerBusinessInformation.Uid = Guid.NewGuid();
            }
            #endregion
            try
            {
                customerRepo.InsertData(customer,customerBusinessInformation);
                return "Entry recorded successfully";
            }
            catch (Exception)
            {
                throw;
            }                        
        }
        public List<GetCustomerInfo> GetCustomerListData(Customer customer)
        {
            try
            {
                return customerRepo.GetList(customer);
            }
            catch (Exception)
            {

                throw;
            }            
        }
        internal string UpdateService(Customer customer,
            CustomerBusinessInformation businessInformation)
        {
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
