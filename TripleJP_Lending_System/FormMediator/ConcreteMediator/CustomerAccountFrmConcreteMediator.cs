using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.ConcreteMediator
{
    class CustomerAccountFrmConcreteMediator : ICustomerAccountFrmMediator
    {
        private CustomerAccountFrm customerAccountFrm;
        private CustomerAccountFrmComponent _customerAccountFrmComponent;
        public CustomerAccountFrmConcreteMediator(CustomerAccountFrmComponent
                                                        customerAccountFrmComponent)
        {
            _customerAccountFrmComponent = customerAccountFrmComponent;
            _customerAccountFrmComponent.SetMediator(this);
        }

        public void Open(bool sender)
        {
            if (sender)
            {
                customerAccountFrm = new CustomerAccountFrm();
                customerAccountFrm.ShowDialog();
            }
        }
    }
}
