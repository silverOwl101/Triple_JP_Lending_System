using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleJP_Lending_System.Forms
{
    public partial class CustomerAccountFrm : Form
    {
        public CustomerAccountFrm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddCustomerFrm();
        }

        private void OpenAddCustomerFrm()
        {
            AddCustomerFrm addCustomer = new AddCustomerFrm();
            addCustomer.ShowDialog();
        }
    }
}
