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
using TripleJP_Lending_System.FormMediator.Mediator;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System
{
    public partial class LogInFrm : Form, ILogIn
    {        
        private LogInFrmPresenter _logInFrmPresenter;
        private MainApplicationFrmComponent _mainApplicationFrmComponent;
        private IFormsMediator _concreteMediator;
        public LogInFrm()
        {
            InitializeComponent();            
        }
        //Press Enter keyboard function
        private void IsEnterPressed(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {                
                LogInVerification();
            }
        }

        #region User Input
        public string UserName
        {
            get { return textBox1.Text; }
            set { }
        }
        public string PassWord
        {
            get { return textBox2.Text; }
            set { }
        }        
        #endregion
        #region Load MainApplicationFrm if user is registered        
        public void LogInVerification()
        {
            try
            {
                UserName = textBox1.Text;
                PassWord = textBox2.Text;
                _logInFrmPresenter = new LogInFrmPresenter(this);
                bool result = _logInFrmPresenter.LogInConfirmation();

                if (result is true)
                {
                    ProceedLogIn(result);
                }
                else
                {
                    const string MessageContent = "Account does not exist please " +
                                                  "check username and password" +
                                                  " and try again.";
                    const string MessageCaption = "Invalid Account";
                    MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch (ArgumentException)
            {
                const string MessageContent = "Invalid username and password.";
                const string MessageCaption = "Invalid Credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                const string MessageContent = "There is a problem to the system" +
                                              "please contact your I.T officer " +
                                              "for further information.";
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
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnterPressed(e);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnterPressed(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LogInVerification();
        }
    }
}
