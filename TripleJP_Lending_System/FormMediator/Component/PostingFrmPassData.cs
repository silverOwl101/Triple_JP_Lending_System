using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.FormMediator.Component
{
    internal class PostingFrmPassData : IPassDataComponent
    {
        internal static string[] customerLoanInformation = new string[4];        
        private ICollectionInformation _customerLoanInformation;
        public PostingFrmPassData(IFormsMediator mediator, ICollectionInformation customerLoanInformation)
        {
            mediator.Include(this);
            _customerLoanInformation = customerLoanInformation;            
        }
        public void PrepareData()
        {
            customerLoanInformation[0] = _customerLoanInformation.Id;
            customerLoanInformation[1] = _customerLoanInformation.CustomerName;
            customerLoanInformation[2] = _customerLoanInformation.LoanTotalAmount;
            customerLoanInformation[3] = _customerLoanInformation.CollectionTotalAmount;
        }
    }
}
