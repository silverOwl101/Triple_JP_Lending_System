using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    internal class CollectionReport
    {
        public string CollectionID { get; set; }
        public decimal CollectionAmount { get; set; }
        public DateTime DateCollected { get; set; }
        public decimal Penalty { get; set; }
    }
}
