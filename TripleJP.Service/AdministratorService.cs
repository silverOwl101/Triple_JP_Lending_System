using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.Model;
using TripleJP_Lending_System.Service.Repository;

namespace TripleJP_Lending_System.Service
{
    class AdministratorService
    {
        
        internal string IsRegistered(string username, string password) // remove underscore kay parameters mani sa method
        {
            // local variables mani silang tanan so wala ray underscore
            LogInRepo checkLogIn = new LogInRepo();
            Administrator administrator = new Administrator();
            administrator.UserName = username;
            administrator.PassWord = password;
            try
            {
                return checkLogIn.CheckRecord(administrator.UserName,administrator.PassWord);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
