using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    internal class Loan
    {
        public Guid uid { get; set; }

        public string id { get; set; }
        public string customeUid { get; set; }
        public string paymentTerm { get; set; }
        public int duration { get; set; }
        public DateTime effectiveDate { get; set; }
        public decimal interest { get; set; }
        public decimal principalLoan { get; set; }
        public decimal penalty { get; set; }       
        public string loanStatus { get; set; }
    }
}
