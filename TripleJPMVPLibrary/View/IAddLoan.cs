using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface IAddLoan
    {
        string customerID { get; set; }
        string paymentTerm { get; set; }
        int duration { get; set; }
        DateTime effectiveDate { get; set; }
        decimal interest { get; set; }
        decimal principalLoan { get; set; }
        decimal penalty { get; set; }         
    }
}
