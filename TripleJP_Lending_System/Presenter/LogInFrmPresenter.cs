using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJP_Lending_System.View;
using System.Windows.Forms;
using TripleJp.Service;
using TripleJP_Lending_System.Forms;
using System.Threading;

namespace TripleJP_Lending_System.Presenter
{
    class LogInFrmPresenter
    {
        ILogIn logIn;
        Thread th;
        public LogInFrmPresenter(ILogIn logIn)
        {
            // butanga ug this para wala kay warnings
            this.logIn = logIn;
        }
        internal void LogInVerification()
        {
            if (string.IsNullOrEmpty(logIn.UserName) && string.IsNullOrEmpty(logIn.PassWord))
            {
                const string MessageContent = "Input your username and password";
                const string MessageCaption = "Enter your credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!string.IsNullOrEmpty(logIn.UserName) && string.IsNullOrEmpty(logIn.PassWord))
            {
                const string MessageContent = "Enter your password";
                const string MessageCaption = "Invalid credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (string.IsNullOrEmpty(logIn.UserName) && !string.IsNullOrEmpty(logIn.PassWord))
            {
                const string MessageContent = "Enter your username";
                const string MessageCaption = "Invalid credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            {
                LogInConfirmation(logIn.UserName, logIn.PassWord);
            }
        }

        internal void LogInConfirmation(string userName, string passWord)
        {
            AdministratorService administratorService = new AdministratorService();
            bool.TryParse(administratorService.IsRegistered(userName, passWord), out bool result);
            if (result == true)
            {
                th = new Thread(MainApplicationFrmLoad);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                Form logInFrm = Application.OpenForms["LogInFrm"]; // assign LogInFrm to variable logInFrm
                if (logInFrm != null) // Check if LogInFrm is open
                {
                    logInFrm.Close(); // Close LogInFrm                    
                }
            }
            else 
            {
                const string MessageContent = "Check your username and password or contact your I.T officer for further information.";
                const string MessageCaption = "Invalid credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MainApplicationFrmLoad() // Used this delegate to load the MainApplicationFrm
        {
            Application.Run(new MainApplicationFrm());
        }
    }
}
