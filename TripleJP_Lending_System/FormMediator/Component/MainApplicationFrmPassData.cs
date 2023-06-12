using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    internal class MainApplicationFrmPassData : IPassDataComponent
    {
        internal static string[] reportParameter = new string[1];
        private string temp;
        public MainApplicationFrmPassData(IFormsMediator mediator, string reportViewerStr)
        {
            mediator.Include(this);
            temp = reportViewerStr;
        }
        public void PrepareData()
        {
            reportParameter[0] = temp;
        }
    }
}
