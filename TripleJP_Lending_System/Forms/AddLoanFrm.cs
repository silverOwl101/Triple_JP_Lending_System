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
    public partial class AddLoanFrm : Form
    {
        public AddLoanFrm()
        {
            InitializeComponent();
            onLoadData();
        }
        private void onLoadData()
        {
            label2.Text = CustomerListLoanFrm.customerLoanInformation[0];
            label3.Text = CustomerListLoanFrm.customerLoanInformation[1];
        }
    }
}
