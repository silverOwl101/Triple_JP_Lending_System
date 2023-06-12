using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LedgerFormData: IDataComponent
    {
        public LedgerFormData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public string[] GetData()
        {
            return LoanInformationFrmPassData.s_loanParameters;
        }
    }
}
