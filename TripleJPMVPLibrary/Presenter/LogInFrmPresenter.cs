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

            if (string.IsNullOrEmpty(_logIn.Username) || string.IsNullOrEmpty(_logIn.Password))
            {
                throw new ArgumentException(" either the username or password is empty ");
            }
            bool result = administratorService.IsRegistered(_logIn.Username, _logIn.Password);
            return result;
        }
    }
}
