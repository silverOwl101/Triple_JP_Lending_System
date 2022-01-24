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
            _customer = new Customer
            {
                Id = _editCustomer.ID,
                Name = _editCustomer.CustomerName,
                Address = _editCustomer.CustomerAddress,
                ContactNumber = _editCustomer.ContactNumber
            };

            _businessInformation = new CustomerBusinessInformation
            {
                BusinessName = _editCustomer.BusinessName,
                BusinessNature = _editCustomer.BusinessNature,
                BusinessAddress = _editCustomer.BusinessAddress,
                GrossBusinessCapital = _editCustomer.GrossBusinessCapital,
                AverageDailyGrossSales = _editCustomer.AveDailyGrossSales
            };

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
