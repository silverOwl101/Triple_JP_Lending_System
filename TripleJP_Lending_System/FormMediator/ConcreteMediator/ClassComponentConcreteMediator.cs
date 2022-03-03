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
        private List<IComponent> _components = new List<IComponent>();
        public void Include(IComponent component)
        {
            _components.Add(component);
        }

        public void OpenForms(object sender, bool condition)
        {
            _components.ForEach(component => 
            { 
                if (sender == component && condition is true) 
                { 
                    component.Open(); 
                } 
            });            
        }
    }
}
