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
using TripleJPMVPLibrary.Model;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Component;

namespace TripleJP_Lending_System.Forms
{
    public partial class PostingFrm : Form, IPosting, ICollectionInformation
    {
        private PostingPresenter _postingPresenter;
        private List<GetPostingInfo> getPostingInfo;
        private IFormsMediator _concreteMediator;
        private CollectionFrmComponent _collectionFrmComponent;
        private PostingFrmPassData _postingFrmPassData;        
        
        public PostingFrm()
        {
            InitializeComponent();            
        }

        public string CustomerId
        {
            get { return PostingSearchTxt.Text; }
            set { PostingSearchTxt.Text = value; }
        }

        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string LoanTotalAmount { get; set; }
        public string CollectionTotalAmount { get; set; }

        private void PostingSubmitButton_Click(object sender, EventArgs e)
        {
            ViewData();
        }

        private void ViewData()
        {
            if (string.IsNullOrEmpty(PostingSearchTxt.Text))
            {
                dataGridView1.Columns.Clear();
                const string MessageContent = "Please type the name or ID of the customer.";
                const string MessageCaption = "Enter Credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                                
            }
            else
            {
                _postingPresenter = new PostingPresenter(this);
                getPostingInfo = new List<GetPostingInfo>();
                getPostingInfo = _postingPresenter.GetPostingList();                
                if (getPostingInfo.Count == 0)
                {
                    dataGridView1.Columns.Clear();
                    const string MessageContent = "No loan records found";
                    const string MessageCaption = "Loan Record Error";
                    MessageBox.Show(MessageContent, MessageCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
                else
                {
                    dataGridView1.DataSource = getPostingInfo;
                    ColumnHeaderNames();
                }                
            }            
        }

        private void ColumnHeaderNames()
        {
            dataGridView1.Columns[0].HeaderText = "Due";
            dataGridView1.Columns[1].HeaderText = "Loan No";
            dataGridView1.Columns[2].HeaderText = "Name";
            dataGridView1.Columns[3].HeaderText = "Return";
            dataGridView1.Columns[4].HeaderText = "Interest";
            dataGridView1.Columns[5].HeaderText = "Total Loan Amount";
            dataGridView1.Columns[7].HeaderText = "Total Amount Collected";
        }
        private void PostingFrm_Shown(object sender, EventArgs e)
        {
            PostingSearchTxt.Focus();            
        }
        private void PostingSearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                ViewData();
            }
        }        
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            CustomerName = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString(); // customer name
            Id = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString(); // loan number/loan id
            CollectionTotalAmount = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString(); // Total CollectedAmount Collected
            LoanTotalAmount = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString(); // Total Loan CollectedAmount

            _concreteMediator = new ClassComponentConcreteMediator();
            _postingFrmPassData = new PostingFrmPassData(_concreteMediator, this);
            _collectionFrmComponent = new CollectionFrmComponent(_concreteMediator);
            _concreteMediator.PrepareData(_postingFrmPassData);
            _concreteMediator.OpenForms(_collectionFrmComponent,true);
            ClearDataGridContent();
        }
        private void ClearDataGridContent()
        {
            PostingSearchTxt.Clear();
            dataGridView1.DataSource = null;
            PostingSearchTxt.Focus();
        }
    }
}
