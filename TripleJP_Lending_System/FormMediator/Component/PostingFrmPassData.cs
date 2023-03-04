using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.FormMediator.Component
{
    internal class PostingFrmPassData : IPassDataComponent
    {
        internal static string[] _customerInformation = new string[2];
        private ICustomerNameAndID _customerNameAndcustomerID;
        public PostingFrmPassData(IFormsMediator mediator, ICustomerNameAndID customerNameAndID)
        {
            mediator.Include(this);
            _customerNameAndcustomerID = customerNameAndID;
        }
        public void PrepareData()
        {
            _customerInformation[0] = _customerNameAndcustomerID.Id;
            _customerInformation[1] = _customerNameAndcustomerID.CustomerName;
        }
    }
}
