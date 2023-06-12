using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LoanInformationFrmComponent : IOpenComponent
    {
        private LoanInformationFrm _loanInformationFrm;
        public LoanInformationFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _loanInformationFrm = new LoanInformationFrm();
            _loanInformationFrm.ShowDialog();
        }
    }
}
