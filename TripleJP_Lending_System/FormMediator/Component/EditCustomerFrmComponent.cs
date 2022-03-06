using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class EditCustomerFrmComponent : IOpenComponent
    {
        private EditCustomerFrm _editCustomerFrm;

        public EditCustomerFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public EditCustomerFrmComponent()
        {
            
        }
        public void Open()
        {
            _editCustomerFrm = new EditCustomerFrm();
            _editCustomerFrm.ShowDialog();
        }
    }
}
