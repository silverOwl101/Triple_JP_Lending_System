using System.Collections.Generic;
using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.ConcreteMediator
{
    class ClassComponentConcreteMediator : IFormsMediator
    {
        private List<IOpenComponent> _components = new List<IOpenComponent>();
        private List<IDataComponent> _dataComponents = new List<IDataComponent>();
        private List<IPassDataComponent> _passDataComponents = new List<IPassDataComponent>();
        public void Include(IOpenComponent component)
        {
            _components.Add(component);
        }

        public void Include(IDataComponent dataComponent)
        {
            _dataComponents.Add(dataComponent);
        }

        public void Include(IPassDataComponent passDataComponents)
        {
            _passDataComponents.Add(passDataComponents);
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

        public string[] GetData(object sender)
        {
            foreach (var dataComponents in _dataComponents)
            {
                if (sender == dataComponents)
                {
                    return dataComponents.GetData();
                }
            }

            return null;            
        }

        public void PrepareData(object sender)
        {
            _passDataComponents.ForEach(passDataComponent =>
            {
                if (sender == passDataComponent)
                {
                    passDataComponent.PrepareData();
                }
            });
        }
    }
}
