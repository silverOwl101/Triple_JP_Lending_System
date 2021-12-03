using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using TripleJP_Lending_System.Forms;

namespace TripleJP_Lending_System.Helper.Presenter
{
    // this is the helper class for presenter LoginFrmPresenter
    class LogInFrmHelper
    {
        Thread th;
        internal void Confirmation(bool result)
        {
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
