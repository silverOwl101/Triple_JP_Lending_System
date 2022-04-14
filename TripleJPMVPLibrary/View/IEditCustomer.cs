using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface IEditCustomer
    {
        string ID { get; set; }
        string CustomerName { get; set; }
        string CustomerAddress { get; set; }
        string ContactNumber { get; set; }
        string BusinessName { get; set; }
        string BusinessNature { get; set; }
        string BusinessAddress { get; set; }
        decimal GrossBusinessCapital { get; set; }
        decimal AverageDailyGrossSales { get; set; }
    }
}
