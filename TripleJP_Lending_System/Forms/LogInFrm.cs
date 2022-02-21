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
using TripleJP_Lending_System.Helper.Presenter;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;

namespace TripleJP_Lending_System
{
    public partial class LogInFrm : Form, ILogIn
    {
        private MainApplicationFrmComponent _mainApplicationFrmComponent;
        private MainApplicationFrmConcreteMediator _mainApplicationFrmConcreteMediator;
        private LogInFrmPresenter _logInFrmPresenter;        
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
            if (string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                const string MessageContent = "Input your username and password";
                const string MessageCaption = "Enter your credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (!string.IsNullOrEmpty(textBox1.Text) && string.IsNullOrEmpty(textBox2.Text))
            {
                const string MessageContent = "Enter your password";
                const string MessageCaption = "Invalid credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                const string MessageContent = "Enter your username";
                const string MessageCaption = "Invalid credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                UserName = textBox1.Text;
                PassWord = textBox2.Text;
                _logInFrmPresenter = new LogInFrmPresenter(this);
                bool result = _logInFrmPresenter.LogInConfirmation();

                if(result is true)
                {
                    ProceedLogIn(result);
                } 
                else
                {
                    ErrorLogIn();
                }
            }
        }
        private void ProceedLogIn(bool result)
        {
            Hide();
            _mainApplicationFrmComponent = new MainApplicationFrmComponent();
            _mainApplicationFrmConcreteMediator =
                new MainApplicationFrmConcreteMediator(_mainApplicationFrmComponent);
            _mainApplicationFrmComponent.OpenForm(result);
            Close();
        }
        private void ErrorLogIn()
        {
            //logInFrmHelper = new LogInFrmHelper();
            //logInFrmHelper.Confirmation(result);

            const string MessageContent = "Check your username and password or contact your I.T officer for further information.";
            const string MessageCaption = "Invalid credentials";
            MessageBox.Show(MessageContent, MessageCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
