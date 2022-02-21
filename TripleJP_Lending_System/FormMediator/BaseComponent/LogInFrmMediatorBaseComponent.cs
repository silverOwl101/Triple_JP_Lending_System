using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.BaseComponent
{
    class LogInFrmMediatorBaseComponent
    {
        protected ILogInFrmMediator _logInFrmMediator;
        public LogInFrmMediatorBaseComponent(ILogInFrmMediator logInFrmMediator = null)
        {
            _logInFrmMediator = logInFrmMediator;
        }
        public void SetMediator(ILogInFrmMediator logInFrmMediator)
        {
            _logInFrmMediator = logInFrmMediator;
        }
    }
}
