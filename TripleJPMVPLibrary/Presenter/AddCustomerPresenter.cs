using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Service;
using TripleJPMVPLibrary.View;
using System.Windows.Forms;

namespace TripleJPMVPLibrary.Presenter
{
    public class AddCustomerPresenter
    {
        private IAddCustomer _addCustomer;
        private Customer _customer = new Customer();
        private CustomerBusinessInformation _customerBusinessInformation = new CustomerBusinessInformation();
        private CustomerService _customerService = new CustomerService();
        public AddCustomerPresenter(IAddCustomer addCustomer)
        {
            _addCustomer = addCustomer;
        }        
        public bool CustomerDataPreparation()
        {            
            try
            {
                _customer = new Customer
                {
                    Name = _addCustomer.CustomerName,
                    Address = _addCustomer.CustomerAddress,
                    ContactNumber = _addCustomer.ContactNumber
                };

                _customerBusinessInformation = new CustomerBusinessInformation
                {
                    BusinessName = _addCustomer.BusinessName,
                    BusinessNature = _addCustomer.BusinessNature,
                    BusinessAddress = _addCustomer.BusinessAddress,
                    GrossBusinessCapital = _addCustomer.GrossBusinessCapital,
                    AverageDailyGrossSales = _addCustomer.AverageDailyGrossSales
                };

                if (!_customerService.IsNameDuplicate(_customer.Name))
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
            rslt = _customerService.PrepareData(_customer, _customerBusinessInformation);
            string MessageContent = rslt;
            const string MessageCaption = "Triple JP Lending System";
            MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DoubleCheckEntry()
        {
            string MessageContent = "The Name " + _customer.Name + " is recorded in the system already. Would you like to continue your entry?";
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
