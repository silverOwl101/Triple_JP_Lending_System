using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.FormMediator.Component
{
    internal class ReportFrmDetailComponent : IOpenComponent
    {
        private ReportViewerFrm _reportViewerFrm;
        public ReportFrmDetailComponent(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public void Open()
        {
            _reportViewerFrm = new ReportViewerFrm();
            _reportViewerFrm.ShowDialog();
        }
    }
}
