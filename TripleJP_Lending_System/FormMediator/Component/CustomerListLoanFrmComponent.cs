using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class CustomerListLoanFrmComponent : IOpenComponent
    {
        private CustomerListLoanFrm _customerListLoanFrm;

        public CustomerListLoanFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _customerListLoanFrm = new CustomerListLoanFrm();
            _customerListLoanFrm.ShowDialog();
        }
    }
}
