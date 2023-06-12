using System;
using System.Collections.Generic;
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

        #region Fields

        private PostingPresenter _postingPresenter;
        private List<GetPostingInfo> getPostingInfo;
        private IFormsMediator _concreteMediator;
        private CollectionFrmComponent _collectionFrmComponent;
        private PostingFrmPassData _postingFrmPassData;

        #endregion

        public PostingFrm()
        {
            InitializeComponent();            
        }

        #region User Inputs

        public string CustomerId
        {
            get { return searchTextBox.Text; }
            set { searchTextBox.Text = value; }
        }

        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string LoanTotalAmount { get; set; }
        public string CollectionTotalAmount { get; set; }

        #endregion

        #region Form Events

        #region Posting Form

        private void PostingFrm_Shown(object sender, EventArgs e)
        {
            searchTextBox.Focus();
        }

        #endregion

        #region TextBox

        private void PostingSearchTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                ViewData();
            }
        }

        #endregion

        #region DataGrid

        private void LoanDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerName = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[2].Value.ToString(); // customer name
            Id = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[1].Value.ToString(); // loan number/loan id
            CollectionTotalAmount = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[7].Value.ToString(); // Total CollectedAmount Collected
            LoanTotalAmount = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[5].Value.ToString(); // Total Loan CollectedAmount

            _concreteMediator = new ClassComponentConcreteMediator();
            _postingFrmPassData = new PostingFrmPassData(_concreteMediator, this);
            _collectionFrmComponent = new CollectionFrmComponent(_concreteMediator);
            _concreteMediator.PrepareData(_postingFrmPassData);
            _concreteMediator.OpenForms(_collectionFrmComponent, true);
            ClearDataGridContent();
        }

        #endregion

        #region Button

        private void PostingSubmitButton_Click(object sender, EventArgs e)
        {
            ViewData();
        }

        #endregion

        #endregion

        #region Custom Methods

        private void ViewData()
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                loanDataGridView.Columns.Clear();
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
                    loanDataGridView.Columns.Clear();
                    const string MessageContent = "No loan records found";
                    const string MessageCaption = "Loan Record Error";
                    MessageBox.Show(MessageContent, MessageCaption,
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                    
                }
                else
                {
                    loanDataGridView.DataSource = getPostingInfo;
                    ColumnHeaderNames();
                }                
            }            
        }

        private void ColumnHeaderNames()
        {
            loanDataGridView.Columns[0].HeaderText = "Due";
            loanDataGridView.Columns[1].HeaderText = "Loan No";
            loanDataGridView.Columns[2].HeaderText = "Name";
            loanDataGridView.Columns[3].HeaderText = "Return";
            loanDataGridView.Columns[4].HeaderText = "Interest";
            loanDataGridView.Columns[5].HeaderText = "Total Loan Amount";
            loanDataGridView.Columns[7].HeaderText = "Total Amount Collected";
        }
      
        private void ClearDataGridContent()
        {
            searchTextBox.Clear();
            loanDataGridView.DataSource = null;
            searchTextBox.Focus();
        }

        #endregion

    }
}
