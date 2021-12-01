using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJp.Model
{
    public class GetCustomerList
    {        
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        public string businessName { get; set; }
        public string businessNature { get; set; }
        public string businessAddress { get; set; }
        public decimal grossBusinessCapital { get; set; }
        public decimal averageDailyGrossSales { get; set; }
    }
}
