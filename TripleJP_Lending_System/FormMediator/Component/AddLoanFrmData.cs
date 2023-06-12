using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class AddLoanFrmData : IDataComponent
    {
        public AddLoanFrmData(IFormsMediator mediator)
        {
            mediator.Include(this);
        }
        public string[] GetData()
        {
            return CustomerListLoanFrmPassData.customerArray;
        }
    }
}
