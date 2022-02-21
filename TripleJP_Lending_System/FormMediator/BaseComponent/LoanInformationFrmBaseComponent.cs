using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.BaseComponent
{
    class LoanInformationFrmBaseComponent
    {
        protected ILoanInformationFrmMediator _loanInformationFrmMediator;
        public LoanInformationFrmBaseComponent(ILoanInformationFrmMediator
                                                    loanInformationFrmMediator = null)
        {
            _loanInformationFrmMediator = loanInformationFrmMediator;
        }
        public void SetMediator(ILoanInformationFrmMediator loanInformationFrmMediator)
        {
            _loanInformationFrmMediator = loanInformationFrmMediator;
        }
    }
}
