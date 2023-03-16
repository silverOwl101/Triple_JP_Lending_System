using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface ICompareCollectionAndLoan
    {
        decimal CollectionTotalAmount { get; set; }
        decimal LoanTotalAmount { get; set; }
    }
}
