using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class CustomerAccountFrmComponent : IComponent
    {
        private CustomerAccountFrm _customerAccountFrm;
        public CustomerAccountFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }        
        public void Open()
        {
            _customerAccountFrm = new CustomerAccountFrm();
            _customerAccountFrm.ShowDialog(); 
        }
    }
}
