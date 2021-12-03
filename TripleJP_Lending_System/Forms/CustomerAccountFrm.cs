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
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class CustomerAccountFrm : Form, ISearch
    {        
        public CustomerAccountFrm()
        {
            InitializeComponent();
            ClearText();
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
                ClearText();
            }            
        }
        private void ToSearch()
        {
            GetCustomerListPresenter getListCustomerAccountPresenter =
                new GetCustomerListPresenter(this);
            getListCustomerAccountPresenter.CallSearch();            
            dataGridView1.DataSource = getListCustomerAccountPresenter.GetList();
        }

        private void DisplayTextInForm()
        {
            label20.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            label10.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            label1.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            label11.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            label2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            label3.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            label4.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
            label5.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
            label7.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
            // label12.Text is to be prepared for another system update
            //label12.Text = dataGridView1.Rows[0].Cells[9].Value.ToString(); 
        }

        private void ClearText()
        {
            label20.Text = "";
            label10.Text = "";
            label1.Text = "";
            label11.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label7.Text = "";
            label12.Text = "Not Available";
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayTextInForm();
        }
    }
}
