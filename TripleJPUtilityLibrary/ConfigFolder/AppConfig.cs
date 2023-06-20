using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJPUtilityLibrary.ConfigFolder
{
    internal class AppConfig
    {
        [DefaultValue("")]
        public string DATABASE_CONNECTION_STRING { get; set; }
    }
}
