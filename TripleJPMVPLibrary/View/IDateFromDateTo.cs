using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface IDateFromDateTo
    {
        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }
    }
}
