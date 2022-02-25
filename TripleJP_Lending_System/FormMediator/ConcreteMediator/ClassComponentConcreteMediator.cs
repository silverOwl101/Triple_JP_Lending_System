using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.ConcreteMediator
{
    class ClassComponentConcreteMediator : IFormsMediator
    {
        List<IInclude> includes = new List<IInclude>();
        public void Include(IInclude include)
        {
            includes.Add(include);
        }

        public void OpenForms(object sender,bool condition)
        {
            foreach (var item in includes)
            {
                if (sender == item && condition is true)
                {
                    item.Open(condition);
                }
            }
        }
    }
}
