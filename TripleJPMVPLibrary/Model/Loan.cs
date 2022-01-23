using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    internal class Loan
    {
        public Guid Uid { get; set; }
        public string Id { get; set; }
        public string CustomerUid { get; set; }
        public string PaymentTerm { get; set; }
        public int Duration { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal Interest { get; set; }
        public decimal PrincipalLoan { get; set; }
        public decimal Penalty { get; set; }       
        public string LoanStatus { get; set; }
    }
}
