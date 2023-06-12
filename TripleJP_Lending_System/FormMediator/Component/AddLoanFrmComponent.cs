using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class AddLoanFrmComponent : IOpenComponent
    {
        private AddLoanFrm _addLoanFrm;
        public AddLoanFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public void Open()
        {
            _addLoanFrm = new AddLoanFrm();
            _addLoanFrm.ShowDialog();
        }
    }
}
