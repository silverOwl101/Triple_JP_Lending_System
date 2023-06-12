using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator
{
    internal class ReportFrmData : IDataComponent
    {
        public ReportFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public string[] GetData()
        {            
            return LoanInformationFrmPassData.s_loanParameters;
        }
    }
}
