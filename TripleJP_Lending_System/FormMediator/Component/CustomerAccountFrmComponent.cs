using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class CustomerAccountFrmComponent : IComponent
    {        
        internal static string[] customerInformation = new string[9];        
        private CustomerAccountFrm _customerAccountFrm;
        IEditCustomer _editCustomer;
        public CustomerAccountFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);                        
        }
        public CustomerAccountFrmComponent(IEditCustomer editCustomer)
        {
            _editCustomer = editCustomer;
            PrepareData();
        }
        public void Open()
        {
            _customerAccountFrm = new CustomerAccountFrm();
            _customerAccountFrm.ShowDialog(); 
        }
        private void PrepareData()
        {
            customerInformation[0] = _editCustomer.ID;
            customerInformation[1] = _editCustomer.CustomerName;
            customerInformation[2] = _editCustomer.CustomerAddress;
            customerInformation[3] = _editCustomer.ContactNumber;
            customerInformation[4] = _editCustomer.BusinessName;
            customerInformation[5] = _editCustomer.BusinessNature;
            customerInformation[6] = _editCustomer.BusinessAddress;
            customerInformation[7] = _editCustomer.GrossBusinessCapital.ToString();
            customerInformation[8] = _editCustomer.AveDailyGrossSales.ToString();            
        }
    }
}
