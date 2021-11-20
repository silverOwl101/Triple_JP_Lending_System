using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJP_Lending_System.View
{
    interface IAddCustomer
    {
        string CustomerName { get; set; }
        string CustomerAddress { get; set; }
        uint ContactNumber { get; set; }
        string BusinessName { get; set; }
        string BusinessNature { get; set; }
        string BusinessAddress { get; set; }
        decimal GrossBusinessCapital { get; set; }
        decimal AveDailyGrossSales { get; set; }

    }
}
