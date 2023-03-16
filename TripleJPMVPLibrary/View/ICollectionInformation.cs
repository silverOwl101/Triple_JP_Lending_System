using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface ICollectionInformation
    {
        string Id { get; set; }
        string CustomerName { get; set; }
        string CollectionTotalAmount { get; set; }
        string LoanTotalAmount { get; set; }
    }
}
