using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPLibraryCore
{
    public class TripleJPUtility
    {
        public string NewId()
        {
            Random rd = new Random();
            uint id;
            string getYear;
            id = (uint)rd.Next(100000000, 200000000);
            getYear = DateTime.Now.Year.ToString();
            StringBuilder sb = new StringBuilder(id.ToString() + "-" + getYear, 14);
            return sb.ToString();
        }
    }
}
