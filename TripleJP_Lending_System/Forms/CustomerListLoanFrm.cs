using System;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class CustomerListLoanFrm : Form, ISearch, ICustomerNameAndID
    {

        #region Fields

        internal static string[] customerLoanInformation = new string[2];

        private IFormsMediator _concreteMediator;
        private ISearch _isearch;
        private ICustomerNameAndID _icustomerNameAndID;
        private AddLoanFrmComponent _addLoanFrmComponent;
        private CustomerListLoanFrmPassData _customerListLoanFrmPassData;

        #endregion

        public CustomerListLoanFrm()
        {
            InitializeComponent();
            DefaultPropertyComponents();
        }

        #region User Inputs

        public string UserSearch
        {
            get { return searchTextBox.Text; }
            set { searchTextBox.Text = value; }
        }
        public string Id
        {
            get { return customerLoanInformation[0]; }
            set { customerLoanInformation[0] = value; }
        }
        public string CustomerName
        {
            get { return customerLoanInformation[1]; }
            set { customerLoanInformation[1] = value; }
        }

        #endregion

        #region Form Events

        #region TextBox

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                OnSearch();
            }
        }

        #endregion

        #region DataGrid

        private void CustomerListDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1) // this line of code will prevent triggering CellDoubleClick
                                  // event if you double click the column header.
            {
                OnDoubleClickData(); // setting the data customer id and customer name
                _icustomerNameAndID = this;
                GetCustomerListPresenter customerList =
                                new GetCustomerListPresenter(_icustomerNameAndID);
                if (customerList.OnLoadData())
                {
                    const string MessageContent = "Customer has pending loan";
                    const string MessageCaption = "Access denied";
                    MessageBox.Show(MessageContent, MessageCaption,
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _concreteMediator = new ClassComponentConcreteMediator();
                    // adding the OnDoubleClickData() in CustomerListLoanFrmPassData component
                    _customerListLoanFrmPassData = new CustomerListLoanFrmPassData(_concreteMediator,
                                                              customerLoanInformation[1],
                                                              customerLoanInformation[0]);
                    _addLoanFrmComponent = new AddLoanFrmComponent(_concreteMediator);
                    _concreteMediator.PrepareData(_customerListLoanFrmPassData);
                    _concreteMediator.OpenForms(_addLoanFrmComponent, true);
                    customerListDataGridView.DataSource = null;
                    searchTextBox.Clear();
                    searchTextBox.Focus();
                }
            }
        }

        #endregion

        #endregion

        #region Custom Methods

        private void DefaultPropertyComponents()
        {
            customerListDataGridView.DataSource = null;
        }

        private void OnSearch()
        {
            _isearch = this;
            GetCustomerListPresenter customerList = new GetCustomerListPresenter(_isearch);
            customerList.CallSearch();
            if (customerList.GetCustomerListData().Count != 0)
            {
                customerListDataGridView.DataSource = customerList.GetCustomerListData();
                ColumnHeaderNames();
            }
            else
            {
                customerListDataGridView.DataSource = null;
            }
        }

        private void OnDoubleClickData()
        {
            //Customer id
            customerLoanInformation[0] = customerListDataGridView.Rows[customerListDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            //Customer name
            customerLoanInformation[1] = customerListDataGridView.Rows[customerListDataGridView.CurrentRow.Index].Cells[1].Value.ToString();
        }

        private void ColumnHeaderNames()
        {
            customerListDataGridView.Columns[0].HeaderText = "Customer ID";
            customerListDataGridView.Columns[1].HeaderText = "Name";
            customerListDataGridView.Columns[2].HeaderText = "Address";
            customerListDataGridView.Columns[3].HeaderText = "Contact number";
            customerListDataGridView.Columns[4].HeaderText = "Business name";
            customerListDataGridView.Columns[5].HeaderText = "Business nature";
            customerListDataGridView.Columns[6].HeaderText = "Business address";
            customerListDataGridView.Columns[7].HeaderText = "Gross business capital";
            customerListDataGridView.Columns[8].HeaderText = "Average daily gross sales";
        }

        #endregion

    }
}