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
            label1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            label4.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            label5.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            label6.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            label7.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            label8.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            label9.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
            label10.Text = dataGridView1.Rows[0].Cells[9].Value.ToString();
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
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayTextInForm();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerListLoanFrm customerListLoan = new CustomerListLoanFrm();
            customerListLoan.ShowDialog();
        }
    }
}
