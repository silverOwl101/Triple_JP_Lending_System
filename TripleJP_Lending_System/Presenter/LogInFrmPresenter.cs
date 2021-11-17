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
        // dili mani private or internal so camelCase lang nga walay underscore
        ILogIn logIn;
        public LogInFrmPresenter(ILogIn logIn)
        {
            // butanga ug this para wala kay warnings
            this.logIn = logIn;
        }
        internal string LogInData()
        {
            AdministratorService administratorService = new AdministratorService();
            return administratorService.IsRegistered(logIn.UserName,logIn.PassWord);
        }
    }
}
