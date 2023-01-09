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
        public int PostingReturn { get; set; }
        public int Interest { get; set; }
        public int TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
