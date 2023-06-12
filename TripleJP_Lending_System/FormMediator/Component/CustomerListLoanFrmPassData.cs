using TripleJP_Lending_System.FormMediator.Mediator;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class CustomerListLoanFrmPassData : IPassDataComponent
    {
        string _name;
        string _id;
        internal static string[] customerArray = new string[2];
        public CustomerListLoanFrmPassData(IFormsMediator mediator, string name, string id)
        {
            mediator.Include(this);
            _name = name;
            _id = id;
        }

        public void PrepareData()
        {
            customerArray[1] = _name;
            customerArray[0] = _id;
        }
    }
}
