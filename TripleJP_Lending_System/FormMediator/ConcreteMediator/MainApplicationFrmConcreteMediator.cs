using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.ConcreteMediator
{
    class MainApplicationFrmConcreteMediator: IMainApplicationFrmMediator
    {
        MainApplicationFrm mainApplicationFrm;
        MainApplicationFrmComponent _mainApplicationFrmComponent;
        public MainApplicationFrmConcreteMediator(MainApplicationFrmComponent
                                                    mainApplicationFrmComponent)
        {
            _mainApplicationFrmComponent = mainApplicationFrmComponent;
            _mainApplicationFrmComponent.SetMediator(this);
        }

        public void Open(bool sender)
        {
            if (sender)
            {
                mainApplicationFrm = new MainApplicationFrm();
                mainApplicationFrm.ShowDialog();
            }
        }
    }
}
