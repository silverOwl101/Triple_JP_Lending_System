using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LoanInformationFrmComponent : IInclude
    {
        LoanInformationFrm loanInformationFrm;
        public LoanInformationFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open(bool sender)
        {
            loanInformationFrm = new LoanInformationFrm();
            loanInformationFrm.ShowDialog();
        }
    }
}
