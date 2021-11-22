using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.Service.Repository;
using TripleJP_Lending_System.Model;

namespace TripleJP_Lending_System.Service
{
    class CustomerService
    {        
        internal string PrepareData(Customer customer)
        {
            CustomerRepo customerRepo = new CustomerRepo();

            try
            {
                customerRepo.InsertData(customer);
            }
            catch (Exception)
            {

                throw;
            }
            
            return "";
        }
    }
}
