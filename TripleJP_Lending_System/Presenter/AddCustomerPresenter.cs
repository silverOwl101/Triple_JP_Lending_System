using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJp.Model;
using TripleJp.Service;
using TripleJP_Lending_System.View;
using System.Windows.Forms;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.Presenter
{
    class AddCustomerPresenter
    {
        IAddCustomer addCustomer;
        Customer customer = new Customer();
        CustomerBusinessInformation customerBusinessInformation =
                               new CustomerBusinessInformation();
        CustomerService customerService = new CustomerService();
        public AddCustomerPresenter(IAddCustomer addCustomer)
        {
            this.addCustomer = addCustomer;
        }        
        internal bool CustomerDataPreparation()
        {            
            try
            {                
                customer.name = addCustomer.CustomerName;
                customer.address = addCustomer.CustomerAddress;
                customer.contactNumber = addCustomer.ContactNumber;
                customerBusinessInformation.businessName = addCustomer.BusinessName;
                customerBusinessInformation.businessNature = addCustomer.BusinessNature;
                customerBusinessInformation.businessAddress = addCustomer.BusinessAddress;
                customerBusinessInformation.grossBusinessCapital = addCustomer.GrossBusinessCapital;
                customerBusinessInformation.averageDailyGrossSales = addCustomer.AveDailyGrossSales;
                if (!customerService.CheckDuplicateName(customer.name))
                {
                    ToRecordEntry();                    
                }
                else
                {
                    DoubleCheckEntry();
                }                
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }
        private void ToRecordEntry()
        {
            string rslt;
            rslt = customerService.PrepareData(customer, customerBusinessInformation);
            string MessageContent = rslt;
            const string MessageCaption = "Triple JP Lending System";
            MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DoubleCheckEntry()
        {
            string MessageContent = "The name " + customer.name + " is recorded in the system already. Would you like to continue your entry?";
            const string MessageCaption = "Duplicate Name";
            var messageRslt = MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (messageRslt == DialogResult.Yes)
            {
                ToRecordEntry();
            }
            if (messageRslt == DialogResult.No)
            {
                ;
            }
        }        
    }
}
