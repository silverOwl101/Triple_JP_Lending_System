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
            //LoadInformation();
            //LoadExample();
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
        private void LoadExample()
        {
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Balance", "Balance");
            dataGridView1.Columns.Add("Collection", "Collection");
            dataGridView1.Columns.Add("Penalty", "Penalty");
            dataGridView1.Rows.Add(1,1);
            int i = Convert.ToInt32(dataGridView1.Rows[0].Cells[0].Value);
            int j = Convert.ToInt32(dataGridView1.Rows[0].Cells[1].Value);
            int result = i - j;
            dataGridView1.Rows.Add(result, null);

        }
    }
}
