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
        MainApplicationFrmComponent mainApplicationFrmComponent;
        MainApplicationFrmConcreteMediator mainApplicationFrmConcreteMediator;
        LogInFrmPresenter logInFrmPresenter;
        LogInFrmHelper logInFrmHelper;
        public LogInFrm()
        {
            InitializeComponent();
        }
        //Press Enter keyboard function
        private void IsEnterPressed(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                //onLoadLoanInformationData
                //Login() method if Enter key is pressed
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
                logInFrmPresenter = new LogInFrmPresenter(this);
                bool result = logInFrmPresenter.LogInConfirmation();
                switch (result)
                {
                    case true:
                        ProceedLogIn(result);
                        break;
                    case false:
                        ErrorLogIn(result);
                        break;
                }
            }
        }
        private void ProceedLogIn(bool result)
        {
            Hide();
            mainApplicationFrmComponent = new MainApplicationFrmComponent();
            mainApplicationFrmConcreteMediator =
                new MainApplicationFrmConcreteMediator(mainApplicationFrmComponent);
            mainApplicationFrmComponent.OpenForm(result);
            Close();
        }
        private void ErrorLogIn(bool result)
        {
            logInFrmHelper = new LogInFrmHelper();
            logInFrmHelper.Confirmation(result);
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
