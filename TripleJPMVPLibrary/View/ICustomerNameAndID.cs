using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface ICustomerNameAndID
    {
        string Id { get; set; }
        string CustomerName { get; set; }
    }
}
