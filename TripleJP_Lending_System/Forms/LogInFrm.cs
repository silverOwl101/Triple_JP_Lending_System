﻿using System;
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


namespace TripleJP_Lending_System
{
    public partial class LogInFrm : Form, ILogIn
    {
        public LogInFrm()
        {
            InitializeComponent();
        }

        //Press Enter keyboard function
        private void IsEnterPressed(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                LoginConfirmation(); //Call LoginConfirmation() method if Enter key is pressed
            }
        }

        #region User Input
        public string UserName
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string PassWord
        {
            get { return textBox2.Text; }
            set { textBox1.Text = value; }
        }

        public Form Form
        {
            get { return this; }
        }

        
        #endregion

        #region Load MainApplicationFrm if user is registered
        private void LoginConfirmation()
        {
            LogInFrmPresenter logInFrmPresenter = new LogInFrmPresenter(this); // Creating instance of the presenter                                                            
                                                                               // method for User log in confirmation   
            LogInFrmHelper logInFrmHelper = new LogInFrmHelper(); // call helper
            bool result= logInFrmPresenter.LogInVerification(); // LogInVerification returns bool and assign it to variable
            logInFrmHelper.Conformation(result); // call helper class to trigger its log in conformation logic
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
            LoginConfirmation();
        }
    }
}
