using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class EditCustomerFrmData : IDataComponent
    {
        public EditCustomerFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public string[] GetData()
        {
            return CustomerAccountFrmPassData.s_customerInformation;
        }
    }
}
