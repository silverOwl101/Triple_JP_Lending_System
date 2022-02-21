using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.BaseComponent;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LoanInformationFrmComponent : LoanInformationFrmBaseComponent
    {
        public void OpenForm()
        {
            _loanInformationFrmMediator.Open(true);
        }
    }
}
