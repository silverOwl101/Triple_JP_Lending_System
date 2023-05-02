using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    internal class Penalty
    {
        public Guid Uid { get; set; }
        public string Id { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
