using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.Model
{
    internal class Administrator
    {
        // kini sakto rani nga PascalCase pero wala a lang an underscore kay naming convention violation na sa properties
        public Guid Uuid { get; set; }
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
