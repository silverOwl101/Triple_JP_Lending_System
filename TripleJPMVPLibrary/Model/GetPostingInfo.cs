using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    public class GetPostingInfo
    {
        public DateTime Due { get; set; }
        public string LoanId { get; set; }
        public string CustomerName { get; set; }
        public decimal PostingReturn { get; set; }
        public decimal Interest { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; }
        public decimal Collect { get; set; }        
    }
}
