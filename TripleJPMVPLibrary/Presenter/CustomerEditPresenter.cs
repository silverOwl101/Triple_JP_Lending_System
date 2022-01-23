using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Service;
using System.Windows.Forms;

namespace TripleJPMVPLibrary.Presenter
{
    public class CustomerEditPresenter
    {        
        private IEditCustomer _editCustomer;
        private Customer _customer = new Customer();
        private CustomerBusinessInformation _businessInformation = new CustomerBusinessInformation();
        private CustomerService _customerService = new CustomerService();
        public CustomerEditPresenter(IEditCustomer editCustomer)
        {
            _editCustomer = editCustomer;
        }
        private void LoadData()
        {
            _customer.Id = _editCustomer.ID;
            _customer.Name = _editCustomer.CustomerName;
            _customer.Address = _editCustomer.CustomerAddress;
            _customer.ContactNumber = _editCustomer.ContactNumber;
            _businessInformation.BusinessName = _editCustomer.BusinessName;
            _businessInformation.BusinessNature = _editCustomer.BusinessNature;
            _businessInformation.BusinessAddress = _editCustomer.BusinessAddress;
            _businessInformation.GrossBusinessCapital = _editCustomer.GrossBusinessCapital;
            _businessInformation.AverageDailyGrossSales = _editCustomer.AveDailyGrossSales;
        }
        public void PrepareUpdate()
        {
            try
            {
                LoadData();
                string confirmationMessage = _customerService.UpdateService(_customer, _businessInformation);
                ConfirmationMessage(confirmationMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ConfirmationMessage(string message)
        {
            string MessageContent = message;
            const string MessageCaption = "Triple JP Lending System";
            MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
