using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.ConcreteMediator
{
    class LogInFrmConcreteMediator : ILogInFrmMediator
    {
        private LogInFrmMediatorComponent _logInFrmMediatorComponent;
        public LogInFrmConcreteMediator(LogInFrmMediatorComponent logInFrmMediatorComponent)
        {
            _logInFrmMediatorComponent = logInFrmMediatorComponent;
            _logInFrmMediatorComponent.SetMediator(this);
        }
        Thread th;
        public void Open(bool sender)
        {
            if (sender)
            {
                LoadLogInFrm();
            }
        }
        private void LoadLogInFrm()
        {
            th = new Thread(LogInFrmLoad);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();            
        }

        private void LogInFrmLoad()
        {
            Application.Run(new LogInFrm());
        }
    }
}
