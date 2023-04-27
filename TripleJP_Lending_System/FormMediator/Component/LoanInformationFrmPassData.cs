using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LoanInformationFrmPassData : IPassDataComponent
    {
        internal static string[] s_loanParameters = new string[2];
        private string _id;
        private string temp;
        public LoanInformationFrmPassData(IFormsMediator mediator, string id, string reportViewerStr)
        {
            mediator.Include(this);
            _id = id;
            temp = reportViewerStr;
        }

        public void PrepareData()
        {
            s_loanParameters[0] = _id;
            s_loanParameters[1] = temp;
        }
    }
}
