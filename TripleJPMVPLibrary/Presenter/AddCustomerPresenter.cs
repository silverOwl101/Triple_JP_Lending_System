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
                _customer.Name = _addCustomer.CustomerName;
                _customer.Address = _addCustomer.CustomerAddress;
                _customer.ContactNumber = _addCustomer.ContactNumber;
                _customerBusinessInformation.BusinessName = _addCustomer.BusinessName;
                _customerBusinessInformation.BusinessNature = _addCustomer.BusinessNature;
                _customerBusinessInformation.BusinessAddress = _addCustomer.BusinessAddress;
                _customerBusinessInformation.GrossBusinessCapital = _addCustomer.GrossBusinessCapital;
                _customerBusinessInformation.AverageDailyGrossSales = _addCustomer.AveDailyGrossSales;
                if (!_customerService.CheckDuplicateName(_customer.Name))
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
