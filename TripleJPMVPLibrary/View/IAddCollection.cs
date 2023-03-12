using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface IAddCollection
    {
        string LoanId { get; set; }
        string CustomerName { get; set; }
        DateTime Date { get; set; }
        decimal Amount { get; set; }
    }
}
