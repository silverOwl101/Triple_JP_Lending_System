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
        }

        private void SearchBoxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                onSearch();                
            }
        }
    }
}
