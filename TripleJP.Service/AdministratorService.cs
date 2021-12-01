using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJp.Model;
using TripleJp.Service.Repository;

namespace TripleJp.Service
{
    public class AdministratorService
    {
        
        public string IsRegistered(string username, string password) // remove underscore kay parameters mani sa method
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
