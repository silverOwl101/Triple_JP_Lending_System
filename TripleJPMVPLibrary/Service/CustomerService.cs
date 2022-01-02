using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Repository;
using TripleJPMVPLibrary.Model;
using TripleJPLibraryCore;

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
            TripleJPUtility gennerateID = new TripleJPUtility();
            customer.uid = Guid.NewGuid();
            customer.id = gennerateID.NewId();
            customerBusinessInformation.uid = Guid.NewGuid();
            customerBusinessInformation.id = gennerateID.NewId();
            #region Check id if valid
            while (customerRepo.IsDuplicateUid(customer.uid))
            {
                customer.uid = Guid.NewGuid();
            }
            while (customerRepo.IsDuplicateId(customer.id))
            {
                customer.id = gennerateID.NewId();
            }
            while (customerRepo.IsDuplicateBusinessId(customerBusinessInformation.id))
            {
                customerBusinessInformation.id = gennerateID.NewId();
            }
            while (customerRepo.IsDuplicateBusinessGuid(customerBusinessInformation.uid))
            {
                customerBusinessInformation.uid = Guid.NewGuid();
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
