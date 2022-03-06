using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJP_Lending_System.FormMediator.Mediator
{
    interface IFormsMediator
    {        
        void Include(IOpenComponent component);
        void Include(IDataComponent component);
        void Include(IPassDataComponent component);
        void OpenForms(object sender, bool condition);
        string[] GetData(object sender);
        void PrepareData(object sender);
    }
}
