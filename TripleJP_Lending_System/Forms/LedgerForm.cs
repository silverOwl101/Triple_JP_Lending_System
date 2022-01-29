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
    public partial class LedgerForm : Form
    {
        decimal principalLoan;
        public LedgerForm()
        {
            InitializeComponent();            
        }
        private void LedgerForm_Load(object sender, EventArgs e)
        {
            LoadInformation();
        }
        private void LoadInformation()
        {
            decimal collection = 0;
            const int term = 30;
            //Do not modify
            this.principalLoan = LoanInformationFrm.principalLoan;
            List<decimal> principalLoanByDay = new List<decimal>();            
            dataGridView1.Columns.Add("Example","Return");
            collection = this.principalLoan / term;
            for (int i = term; i > 0; i--) // terms of 30 days
            {
                principalLoanByDay.Add(collection);
            }
            foreach (var item in principalLoanByDay)
            {
                dataGridView1.Rows.Add(item);
            }
            //End
        }
    }
}
