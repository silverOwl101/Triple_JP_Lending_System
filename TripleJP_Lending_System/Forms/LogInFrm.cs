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
using TripleJP_Lending_System.Forms;
using TripleJP_Lending_System.Presenter;
using TripleJP_Lending_System.View;


namespace TripleJP_Lending_System
{
    public partial class LogInFrm : Form, ILogIn
    {
        Thread th;
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
        #endregion

        #region Load MainApplicationFrm if user is registered
        private void LoginConfirmation()
        {
            // and instance name e same pd sa ngalan sa class
            LogInFrmPresenter logInFrmPresenter = new LogInFrmPresenter(this); // Creating instance of the presenter                                                            
                                                                   // method for User log in confirmation   

            bool.TryParse(logInFrmPresenter.LogInData(), out bool result); // Try to convert the string to boolean
            if (result == true)
            {
                th = new Thread(MainApplicationFrmLoad);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else
            {
                // If the result is false print the error message
                MessageBox.Show(logInFrmPresenter.LogInData());
            }
        }
        private void MainApplicationFrmLoad() // Used this delegate to load the MainApplicationFrm
        {
            Application.Run(new MainApplicationFrm());
        }

        // Kini it should be PascalCase pero consider nalang nato ni if function sa toolbox since naka default naman sa IDE
        // Nalibog sad ko kay mo warning man siya gd maskin sila ga default ani nga dili PascalCase HAHA
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
