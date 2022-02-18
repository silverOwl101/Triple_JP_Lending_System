using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.BaseComponent
{
    class MainApplicationFrmBaseComponent
    {
        protected IMainApplicationFrmMediator _mainApplicationFrmMediator;
        public MainApplicationFrmBaseComponent(IMainApplicationFrmMediator 
                                                mainApplicationFrmMediator = null)
        {
            _mainApplicationFrmMediator = mainApplicationFrmMediator;
        }

        public void SetMediator(IMainApplicationFrmMediator mainApplicationFrmMediator)
        {
            _mainApplicationFrmMediator = mainApplicationFrmMediator;
        }
    }
}
