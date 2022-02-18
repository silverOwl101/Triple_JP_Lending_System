using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.View;
using System.Windows.Forms;
using TripleJPMVPLibrary.Service;

namespace TripleJPMVPLibrary.Presenter
{
    public class LogInFrmPresenter
    {
        private ILogIn _logIn;
        public LogInFrmPresenter(ILogIn logIn)
        {
            _logIn = logIn;
        }        
        public bool LogInConfirmation()
        {
            AdministratorService administratorService = new AdministratorService();
            bool result = administratorService.IsRegistered(_logIn.UserName, _logIn.PassWord);
            return result;
        }
    }
}
