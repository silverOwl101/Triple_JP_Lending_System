using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    public class GetCustomerLoanInformation
    {        
        public string id { get; set; }
        public string customerID { get; set; }
        public string name { get; set; }
        public string paymentTerm { get; set; }
        public int duration { get; set; }
        public string effectiveDate { get; set; }
        public decimal interest { get; set; }
        public decimal principalLoan { get; set; }
        public decimal penalty { get; set; }
        public string status { get; set; }
        public string returned { get; set; }
    }
}
