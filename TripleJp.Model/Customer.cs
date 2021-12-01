using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJp.Model
{
    public class Customer
    {
        public Guid uid { get; set; }        
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }        
    }
}
