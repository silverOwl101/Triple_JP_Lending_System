using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.BaseComponent
{
    class CustomerAccountFrmBaseComponent
    {
        protected ICustomerAccountFrmMediator _customerAccountFrmMediator;
        public CustomerAccountFrmBaseComponent(ICustomerAccountFrmMediator
                                            customerAccountFrmMediator = null)
        {
            _customerAccountFrmMediator = customerAccountFrmMediator;
        }
        public void SetMediator(ICustomerAccountFrmMediator customerAccountFrmMediator)
        {
            _customerAccountFrmMediator = customerAccountFrmMediator;
        }
    }
}
