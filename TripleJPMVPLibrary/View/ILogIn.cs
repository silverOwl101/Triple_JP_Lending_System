using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPMVPLibrary.View
{
    public interface ILogIn
    {
        string UserName { get; set; }
        string PassWord { get; set; }
    }
}
