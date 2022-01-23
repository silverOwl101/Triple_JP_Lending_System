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
        public bool LogInVerification() // this function returns boolean
        {
            // avoid using else if if necessary
            if (string.IsNullOrEmpty(_logIn.UserName) && string.IsNullOrEmpty(_logIn.PassWord))
            {
                const string MessageContent = "Input your username and password";
                const string MessageCaption = "Enter your credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (!string.IsNullOrEmpty(_logIn.UserName) && string.IsNullOrEmpty(_logIn.PassWord))
            {
                const string MessageContent = "Enter your password";
                const string MessageCaption = "Invalid credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (string.IsNullOrEmpty(_logIn.UserName) && !string.IsNullOrEmpty(_logIn.PassWord))
            {
                const string MessageContent = "Enter your username";
                const string MessageCaption = "Invalid credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return LogInConfirmation(_logIn.UserName, _logIn.PassWord);
            
        }

        public bool LogInConfirmation(string userName, string passWord) // also this function returns boolean
        {
            AdministratorService administratorService = new AdministratorService();
            bool result = administratorService.IsRegistered(userName, passWord);
            return result;
        }
    }
}
