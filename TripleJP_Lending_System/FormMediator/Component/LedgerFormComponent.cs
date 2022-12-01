using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class LedgerFormComponent : IOpenComponent
    {
        private LedgerForm _ledgerForm;
        public LedgerFormComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _ledgerForm = new LedgerForm();
            //_ledgerForm.ShowDialog();
            _ledgerForm.LoadCollectionandPenalty();
        }
    }
}
