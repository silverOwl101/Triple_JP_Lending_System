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
    public partial class CustomerAccountFrm : Form, ISearch
    {
        public CustomerAccountFrm()
        {
            InitializeComponent();
        }

        public string userSearch 
        {
            get { return SearchBoxtxt.Text; }
            set { SearchBoxtxt.Text = value; }
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

        private void SearchBoxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                ToSearch();
            }            
        }

        private void ToSearch()
        {
            GetListCustomerAccountPresenter getListCustomerAccountPresenter =
                new GetListCustomerAccountPresenter(this);
            getListCustomerAccountPresenter.CallSearch();            
            dataGridView1.DataSource = getListCustomerAccountPresenter.GetList();
        }
    }
}
