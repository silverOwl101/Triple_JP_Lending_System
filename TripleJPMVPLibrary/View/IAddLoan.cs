using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface IAddLoan
    {
        string CustomerID { get; set; }
        string PaymentTerm { get; set; }
        int Duration { get; set; }
        DateTime EffectiveDate { get; set; }
        decimal Interest { get; set; }
        decimal PrincipalLoan { get; set; }
        decimal Penalty { get; set; }         
    }
}
