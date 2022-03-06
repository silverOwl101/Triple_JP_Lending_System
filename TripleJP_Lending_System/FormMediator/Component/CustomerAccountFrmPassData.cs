using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.FormMediator.Component
{
    class CustomerAccountFrmPassData : IPassDataComponent
    {
        internal static string[] s_customerInformation = new string[9];
        private IEditCustomer _editCustomer;
        public CustomerAccountFrmPassData(IFormsMediator mediator, IEditCustomer editCustomer)
        {
            mediator.Include(this);
            _editCustomer = editCustomer;
        }
        public void PrepareData()
        {
            s_customerInformation[0] = _editCustomer.ID;
            s_customerInformation[1] = _editCustomer.CustomerName;
            s_customerInformation[2] = _editCustomer.CustomerAddress;
            s_customerInformation[3] = _editCustomer.ContactNumber;
            s_customerInformation[4] = _editCustomer.BusinessName;
            s_customerInformation[5] = _editCustomer.BusinessNature;
            s_customerInformation[6] = _editCustomer.BusinessAddress;
            s_customerInformation[7] = _editCustomer.GrossBusinessCapital.ToString();
            s_customerInformation[8] = _editCustomer.AveDailyGrossSales.ToString();
        }
    }
}
