using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class CustomerAccountFrmComponent : IOpenComponent
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
