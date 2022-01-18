using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Presenter;
using TripleJPUtilityLibrary.Accounting;

namespace TripleJP_Lending_System.Forms
{
    public partial class LoanInformationFrm : Form,ISearch
    {
        public LoanInformationFrm()
        {
            InitializeComponent();
            ClearText();            
        }
        public string userSearch 
        {
            get { return SearchBoxtxt.Text; }
            set { SearchBoxtxt.Text = value; }
        }
        private void onSearch()
        {
            LoanInformationPresenter loanInformationPresenter
                = new LoanInformationPresenter(this);
            dataGridView1.DataSource = loanInformationPresenter.GetLoanInformationList();
            ClearText();
        }
        private void SearchBoxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                onSearch();                
            }
        }
        private void DisplayTextInForm()
        {
            label1.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            label2.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            label3.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            label4.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            label5.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            label6.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            label7.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            label8.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            label9.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            label10.Text = 
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
            label12.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
        }
        private void ClearText()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayTextInForm();
            maturityInterestDisplay();
            maturityValueDisplay();
            perRemittanceDisplay();
            maturityDate();
            totalAmountRemittance();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListLoanFrm customerListLoan = new CustomerListLoanFrm();
            customerListLoan.ShowDialog();
        }
        private void maturityInterestDisplay()
        {
            decimal loan = Convert.ToDecimal(label8.Text);
            Computation comp = new Computation();
            label20.Text = String.Format("{0:N}", comp.MaturityInterest(loan));                
        }
        private void maturityValueDisplay()
        {
            decimal loan = Convert.ToDecimal(label8.Text);
            Computation comp = new Computation();
            decimal interest = Convert.ToDecimal(label20.Text);
            label18.Text = String.Format("{0:N}",comp.MaturityValue(interest, loan));
        }
        private void perRemittanceDisplay()
        {
            Computation comp = new Computation();
            decimal _value = Convert.ToDecimal(label18.Text);
            int duration = Convert.ToInt32(label5.Text);
            label17.Text = comp.PerRemittance(_value, duration).ToString();
        }
        private void maturityDate()
        {
            Computation comp = new Computation();
            DateTime effectiveDate = Convert.ToDateTime(label6.Text);
            int duration = Convert.ToInt32(label5.Text);
            label19.Text = comp.MaturityDate(effectiveDate,duration).ToString("MM-dd-yyyy");
        }
        private void totalAmountRemittance()
        {
            decimal result = Convert.ToDecimal(label18.Text) - Convert.ToDecimal(label12.Text);
            label11.Text = result.ToString();
        }
    }
}
