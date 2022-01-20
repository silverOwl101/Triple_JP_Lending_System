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
            customer.Id = editCustomer.ID;
            customer.Name = editCustomer.CustomerName;
            customer.Address = editCustomer.CustomerAddress;
            customer.ContactNumber = editCustomer.ContactNumber;
            businessInformation.BusinessName = editCustomer.BusinessName;
            businessInformation.BusinessNature = editCustomer.BusinessNature;
            businessInformation.BusinessAddress = editCustomer.BusinessAddress;
            businessInformation.GrossBusinessCapital = editCustomer.GrossBusinessCapital;
            businessInformation.AverageDailyGrossSales = editCustomer.AveDailyGrossSales;
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
