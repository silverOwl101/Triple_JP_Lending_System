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
        
        internal string IsRegistered(string _username, string _password)
        {
            LogInRepo checkLogIn = new LogInRepo();
            Administrator administrator = new Administrator();
            administrator._UserName = _username;
            administrator._PassWord = _password;
            try
            {
                return checkLogIn.CheckRecord(administrator._UserName,administrator._PassWord);
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
