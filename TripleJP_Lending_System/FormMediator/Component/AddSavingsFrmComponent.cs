using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    internal class AddSavingsFrmComponent : IOpenComponent
    {
        private AddSavingsFrm _addSavingsFrm;
        public AddSavingsFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _addSavingsFrm = new AddSavingsFrm();
            _addSavingsFrm.ShowDialog();
        }
    }
}
