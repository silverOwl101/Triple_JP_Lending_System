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
        #region Fields

        private LogInFrmPresenter _logInFrmPresenter;
        private MainApplicationFrmComponent _mainApplicationFrmComponent;
        private IFormsMediator _concreteMediator;

        #endregion

        public LogInFrm()
        {
            InitializeComponent();            
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
                    const string MessageContent = "Login Successful.";
                    const string MessageCaption = "Successful";

                    if (MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
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
            catch (ArgumentException)
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnterPressed(e);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnterPressed(e);
        }

        #endregion

        #region Buttons

        private void button1_Click(object sender, EventArgs e)
        {
            LogInVerification();
        }

        #endregion

        #endregion

    }
}
