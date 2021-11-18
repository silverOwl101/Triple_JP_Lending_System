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

namespace TripleJP_Lending_System.Forms
{
    public partial class MainApplicationFrm : Form
    {
        Thread th;
        public MainApplicationFrm()
        {
            InitializeComponent();
        }

        #region Log out code
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadLogInFrm();
        }

        private void LoadLogInFrm()
        {
            th = new Thread(LogInFrmLoad);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }

        private void LogInFrmLoad()
        {
            Application.Run(new LogInFrm());
        }
        #endregion

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCustomerAccountFrm();
        }

        private void OpenCustomerAccountFrm()
        {
            CustomerAccountFrm customerAccount = new CustomerAccountFrm();
            customerAccount.ShowDialog();
        }
    }
}
