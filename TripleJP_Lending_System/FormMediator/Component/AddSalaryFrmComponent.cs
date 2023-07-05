using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    internal class AddSalaryFrmComponent : IOpenComponent
    {
        AddSalaryFrm _addSalaryFrm;
        public AddSalaryFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _addSalaryFrm = new AddSalaryFrm();
            _addSalaryFrm.ShowDialog();
        }
    }
}
