using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Presenter;
using System.Windows.Forms;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class PostingFrm : Form, IPosting
    {

        private PostingPresenter _postingPresenter;
        public PostingFrm()
        {
            InitializeComponent();
        }

        public string CustomerId    
        {
            get { return PostingSearchTxt.Text; }
            set { PostingSearchTxt.Text = value; }
        }

        private void PostingSubmitButton_Click(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            _postingPresenter = new PostingPresenter(this);           
            dataGridView1.DataSource = _postingPresenter.GetPostingList();
            ColumnHeaderNames();
        }

        private void ColumnHeaderNames()
        {
            dataGridView1.Columns[0].HeaderText = "Due";
            dataGridView1.Columns[1].HeaderText = "Loan No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Return";
            dataGridView1.Columns[4].HeaderText = "Interest";
            dataGridView1.Columns[5].HeaderText = "Total Amount";
        }
    }
}
