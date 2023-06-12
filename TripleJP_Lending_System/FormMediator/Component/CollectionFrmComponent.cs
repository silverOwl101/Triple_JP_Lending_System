using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{    
    internal class CollectionFrmComponent : IOpenComponent
    {
        private RemitAndPenaltyFrm _collectionFrm;
        public CollectionFrmComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _collectionFrm = new RemitAndPenaltyFrm();
            _collectionFrm.ShowDialog();
        }
    }
}
