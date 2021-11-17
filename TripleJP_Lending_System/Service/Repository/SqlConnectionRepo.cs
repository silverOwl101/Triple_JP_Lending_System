using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System.Service.Repository
{
    static class SqlConnectionRepo
    {
        // internal constant mani siya so bahalag internal still walay underscore but PascalCase kay tungod constant siya
        internal const string ConnectionString = @"Server=localhost;Database=tjpdb;Uid=root;Pwd=Kuru_hunt1;";        
    }
}
