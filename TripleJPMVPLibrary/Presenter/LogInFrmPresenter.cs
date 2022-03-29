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

        #region Fields

        private ILogIn _logIn;
        private LogInService _logInService;

        #endregion

        public LogInFrmPresenter(ILogIn logIn)
        {
            _logIn = logIn;
        }        

        public bool LogInConfirmation()
        {
            _logInService = new LogInService();

            if (string.IsNullOrEmpty(_logIn.Username) || string.IsNullOrEmpty(_logIn.Password))
            {
                throw new ArgumentException(" either the username or password is empty ");
            }

            bool result = _logInService.IsRegistered(_logIn.Username, _logIn.Password);
            return result;
        }
    }
}
