using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    public class CustomerBusinessInformation
    {
        public Guid Uid { get; set; }
        public string Id { get; set; }
        public string BusinessName { get; set; }
        public string BusinessNature { get; set; }
        public string BusinessAddress { get; set; }
        public decimal GrossBusinessCapital { get; set; }
        public decimal AverageDailyGrossSales { get; set; }
    }
}
