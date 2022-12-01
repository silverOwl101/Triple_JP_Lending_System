using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System
{
    public partial class LogInFrm : Form, ILogIn
    {
        #region Fields

        private LogInFrmPresenter _logInFrmPresenter;
        private MainApplicationFrmComponent _mainApplicationFrmComponent;
        private ClassComponentConcreteMediator _concreteMediator;

        #endregion

        public LogInFrm()
        {
            InitializeComponent();            
        }

        #region User Input
        public string Username
        {
            get { return usernameTxt.Text; }
            set { }
        }
        public string Password
        {
            get { return passwordTxt.Text; }
            set { }
        }
        #endregion

        #region Custom Methods

        #region Events

        private void IsEnterPressed(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                LogInVerification();
            }
        }

        #endregion

        private void LogInVerification()
        {
            try
            {
                Username = usernameTxt.Text;
                Password = passwordTxt.Text;

                _logInFrmPresenter = new LogInFrmPresenter(this);
                bool result = _logInFrmPresenter.LogInConfirmation();

                if (result is true)
                {
                        ProceedLogIn(result);
                }
                else
                {
                    const string MessageContent = "Invalid username and password.";
                    const string MessageCaption = "Invalid Credentials";
                    MessageBox.Show(MessageContent, MessageCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (ArgumentNullException ex) when (ex.ParamName is "Username" || ex.ParamName is "Password")
            {
                const string MessageContent = "Please type your username and password.";
                const string MessageCaption = "Enter Credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
                const string MessageCaption = "System Access Denied";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ProceedLogIn(bool result)
        {
            Hide();
            _concreteMediator = new ClassComponentConcreteMediator();
            _mainApplicationFrmComponent = new MainApplicationFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_mainApplicationFrmComponent, result);
            Close();
        }

        #endregion

        #region Form Events

        #region TextBox

        private void UsernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnterPressed(e);
        }

        private void PasswordTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnterPressed(e);
        }

        #endregion

        #region Buttons

        private void LogInButton_Click(object sender, EventArgs e)
        {
            LogInVerification();
        }

        #endregion

        #endregion

        private void LogInFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
