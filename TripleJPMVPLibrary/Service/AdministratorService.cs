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

        #region Fields

        private LogInRepo _logInRepo;
        private Administrator _administrator;

        #endregion

        public bool IsRegistered(string username, string password)
        {
            _administrator = new Administrator
            {
                Username = username,
                Password = password
            };

            _logInRepo = new LogInRepo();

            try
            {
                return _logInRepo.CheckRecord(_administrator.Username,_administrator.Password);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" database access denied ", ex);
            }
        }
    }
}
