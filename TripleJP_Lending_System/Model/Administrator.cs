using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleJP_Lending_System.Model
{
    class Administrator
    {
        public Guid _Uuid { get; set; }
        public string _Id { get; set; }
        public string _UserName { get; set; }
        public string _PassWord { get; set; }
    }
}
