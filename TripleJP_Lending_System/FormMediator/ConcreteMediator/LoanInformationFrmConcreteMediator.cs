using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.ConcreteMediator
{
    class LoanInformationFrmConcreteMediator : ILoanInformationFrmMediator
    {
        private LoanInformationFrm loanInformationFrm;
        private LoanInformationFrmComponent _loanInformationFrmComponent;
        public LoanInformationFrmConcreteMediator(LoanInformationFrmComponent 
                                                        loanInformationFrmComponent)
        {
            _loanInformationFrmComponent = loanInformationFrmComponent;
            _loanInformationFrmComponent.SetMediator(this);
        }
        public void Open(bool sender)
        {
            if (sender)
            {
                loanInformationFrm = new LoanInformationFrm();
                loanInformationFrm.ShowDialog();
            }
        }
    }
}
