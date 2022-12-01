using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;

namespace TripleJP_Lending_System.FormMediator.Mediator
{
    interface IEditCustomerInformation
    {
        GetCustomerInfo TransferData(GetCustomerInfo sender);
    }
}
