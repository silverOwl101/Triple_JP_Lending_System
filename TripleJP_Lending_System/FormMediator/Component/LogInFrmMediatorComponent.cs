using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.BaseComponent;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LogInFrmMediatorComponent : LogInFrmMediatorBaseComponent
    {
        public void OpenForm(bool sender)
        {
            _logInFrmMediator.Open(sender);
        }
    }
}
