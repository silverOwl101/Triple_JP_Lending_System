using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    internal class Savings
    {
        public Guid Uid { get; set; }
        public string Id { get; set; }
        public decimal SavingsAmount { get; set; }
        public DateTime CollectionDate { get; set; }
        public DateTime DateRemmited { get; set; }
    }
}
