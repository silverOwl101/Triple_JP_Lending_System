using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    public class GetCustomerInfo
    {        
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string BusinessName { get; set; }
        public string BusinessNature { get; set; }
        public string BusinessAddress { get; set; }
        public decimal GrossBusinessCapital { get; set; }
        public decimal AverageDailyGrossSales { get; set; }
    }
}
