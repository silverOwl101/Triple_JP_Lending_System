using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.View;
using TripleJP_Lending_System.Service;


namespace TripleJP_Lending_System.Presenter
{
    class LogInFrmPresenter
    {
        ILogIn _logIn;
        public LogInFrmPresenter(ILogIn logIn)
        {
            _logIn = logIn;
        }
        internal string LogInData()
        {
            AdministratorService administratorService = new AdministratorService();
            return administratorService.IsRegistered(_logIn.UserName,_logIn.PassWord);
        }
    }
}
