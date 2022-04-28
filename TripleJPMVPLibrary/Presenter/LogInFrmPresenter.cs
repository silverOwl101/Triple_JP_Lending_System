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

            if (string.IsNullOrEmpty(_logIn.Username) && !string.IsNullOrEmpty(_logIn.Password))
            {
                throw new ArgumentNullException(nameof(_logIn.Username), " Username is Null ");
            }

            if(string.IsNullOrEmpty(_logIn.Password))
            {
                throw new ArgumentNullException(nameof(_logIn.Password), " Username is Null ");
            }

            bool result = _logInService.IsRegistered(_logIn.Username, _logIn.Password);
            return result;
        }
    }
}
