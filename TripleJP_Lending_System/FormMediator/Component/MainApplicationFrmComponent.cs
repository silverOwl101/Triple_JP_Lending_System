using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.BaseComponent;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class MainApplicationFrmComponent : MainApplicationFrmBaseComponent
    {        
        public void OpenForm(bool result)
        {
            if (result)
            {
                _mainApplicationFrmMediator.Open(true);
            }
            
        }
    }
}
