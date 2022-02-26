using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class AddLoanFrmComponent : IComponent
    {
        private AddLoanFrm _addLoanFrm;
        public AddLoanFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }

        public void Open()
        {
            _addLoanFrm = new AddLoanFrm();
            _addLoanFrm.ShowDialog();
        }
    }
}
