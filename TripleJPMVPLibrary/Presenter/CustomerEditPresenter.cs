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
        #region Fields

        private IEditCustomer _editCustomer;
        private Customer _customer;
        private CustomerBusinessInformation _businessInformation;
        private CustomerService _customerService;

        #endregion

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
                AverageDailyGrossSales = _editCustomer.AverageDailyGrossSales
            };

        }
        public void OnLoadUpdateCustomerData()
        {
            LoadData();
            _customerService = new CustomerService();
            _customerService.OnSetUpdateCustomerData(_customer, _businessInformation);
        }
    }
}
