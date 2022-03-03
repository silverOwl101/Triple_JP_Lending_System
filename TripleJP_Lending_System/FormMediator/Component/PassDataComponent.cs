using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class PassDataComponent 
    {
        string[] customerInformation = new string[9];
        internal string[] GetData()
        {
            customerInformation = CustomerAccountFrmComponent.customerInformation;
            return customerInformation;
        }
    }
}
