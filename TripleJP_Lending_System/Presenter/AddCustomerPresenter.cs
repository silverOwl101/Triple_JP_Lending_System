using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.Service;
using TripleJP_Lending_System.View;
using TripleJP_Lending_System.Model;
using System.Windows.Forms;

namespace TripleJP_Lending_System.Presenter
{
    class AddCustomerPresenter
    {
        IAddCustomer addCustomer;
        public AddCustomerPresenter(IAddCustomer addCustomer)
        {
            this.addCustomer = addCustomer;
        }

        internal string CustomerDataPreparation()
        {
            try
            {
                Customer customer = new Customer();
                CustomerService customerService = new CustomerService();
                customer.uid = Guid.NewGuid();
                customer.id = "";
                customer.name = addCustomer.CustomerName;
                customer.address = addCustomer.CustomerAddress;
                customer.contactNumber = addCustomer.ContactNumber;
                customerService.PrepareData(customer);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            
            return "";
        }
    }
}
