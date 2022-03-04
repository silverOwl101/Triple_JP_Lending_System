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
        internal static string[] s_loanID = new string[1];
        private string _id;
        public LoanInformationFrmPassData(IFormsMediator mediator, string id)
        {
            mediator.Include(this);
            _id = id;
        }

        public void PrepareData()
        {
            s_loanID[0] = _id;
        }
    }
}
