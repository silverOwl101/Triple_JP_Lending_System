using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    internal class LoanInformationReport
    {
        public string CustomerID { get; set; }
        public string NameOfOwner { get; set; }
        public decimal PrincipalLoan { get; set; }
        public decimal Interest { get; set; }
        public decimal TotalLoan { get; set; }
        public decimal DailyPayment { get; set; }
        public string Terms { get; set; }
    }
}
