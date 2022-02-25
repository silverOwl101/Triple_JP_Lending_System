using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class CustomerAccountFrmComponent : IInclude
    {
        CustomerAccountFrm customerAccountFrm;
        public CustomerAccountFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
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
