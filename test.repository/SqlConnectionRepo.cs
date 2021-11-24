using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TripleJP.Service.Repository
{
    static class SqlConnectionRepo
    {       
        internal const string ConnectionString = @"Server=localhost;Database=tjpdb;Uid=root;Pwd=Kuru_hunt1;";        
    }
}
