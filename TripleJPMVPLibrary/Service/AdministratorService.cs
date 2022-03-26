using MySql.Data.MySqlClient;
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
            LogInRepo logInRepo = new LogInRepo();

            Administrator administrator = new Administrator
            {
                UserName = username,
                PassWord = password
            };

            try
            {
                return logInRepo.CheckRecord(administrator.UserName,administrator.PassWord);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" database access denied ", ex);
            }
        }
    }
}
