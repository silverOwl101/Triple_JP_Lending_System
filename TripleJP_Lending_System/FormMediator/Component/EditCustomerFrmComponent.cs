using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class EditCustomerFrmComponent : IComponent
    {
        private EditCustomerFrm _editCustomerFrm;
        private DataMediator _dataMediator;

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
        internal string[] GetData()
        {
            _dataMediator = new DataMediator();
            return _dataMediator.GetMediatedData();
        }
    }
}
