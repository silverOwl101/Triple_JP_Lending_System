using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Repository;

namespace TripleJPMVPLibrary.Service
{
    public class AdministratorService
    {
        
        public bool IsRegistered(string username, string password) // remove underscore kay parameters mani sa method
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
