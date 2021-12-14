using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class CustomerListLoanFrm : Form, ISearch
    {
        internal static string[] customerLoanInformation = new string[2];
        public CustomerListLoanFrm()
        {
            InitializeComponent();
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
            //ClearText();
        }

        private void SearchBoxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                onSearch();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            onDoubleClickData();
            AddLoanFrm addLoan = new AddLoanFrm();
            addLoan.ShowDialog();
        }

        private void onDoubleClickData()
        {
            customerLoanInformation[0] = dataGridView1.Rows[0].Cells[1].Value.ToString();
            customerLoanInformation[1] = dataGridView1.Rows[0].Cells[2].Value.ToString();
        }
    }
}
