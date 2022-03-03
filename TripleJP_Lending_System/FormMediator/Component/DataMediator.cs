using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class DataMediator
    {
        internal string[] GetMediatedData()
        {
            return CustomerAccountFrmComponent.customerInformation;
        }
        internal string GetMediatedID()
        {
            return LoanInformationFrmComponent._getLoanID;
        }
    }
}
