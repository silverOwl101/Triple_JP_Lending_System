using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJP_Lending_System.FormMediator.Mediator
{
    interface IFormsMediator
    {        
        void Include(IComponent component);
        void OpenForms(object sender, bool condition);
    }
}
