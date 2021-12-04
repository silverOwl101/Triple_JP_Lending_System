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
        IEditCustomer editCustomer;
        Customer customer = new Customer();
        CustomerBusinessInformation businessInformation = new CustomerBusinessInformation();
        public CustomerEditPresenter(IEditCustomer editCustomer)
        {
            this.editCustomer = editCustomer;
        }
        private void LoadData()
        {            
            customer.id = editCustomer.ID;
            customer.name = editCustomer.CustomerName;
            customer.address = editCustomer.CustomerAddress;
            customer.contactNumber = editCustomer.ContactNumber;
            businessInformation.businessName = editCustomer.BusinessName;
            businessInformation.businessNature = editCustomer.BusinessNature;
            businessInformation.businessAddress = editCustomer.BusinessAddress;
            businessInformation.grossBusinessCapital = editCustomer.GrossBusinessCapital;
            businessInformation.averageDailyGrossSales = editCustomer.AveDailyGrossSales;
        }
        public void PrepareUpdate()
        {
            try
            {
                LoadData();
                CustomerService customerService = new CustomerService();
                string confirmationMessage = 
                    customerService.UpdateService(customer, businessInformation);
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
