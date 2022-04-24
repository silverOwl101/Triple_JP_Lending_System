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
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;

namespace TripleJP_Lending_System.Forms
{
    public partial class CustomerAccountFrm : Form, ISearch, IAddCustomer, IEditCustomer
    {
        #region Fields

        private ClassComponentConcreteMediator _concreteMediator;
        private AddCustomerFrmComponent _addCustomerFrmComponent;
        private EditCustomerFrmComponent _editCustomerFrmComponent;
        private CustomerAccountFrmPassData _customerAccountFrmData;
        private GetCustomerListPresenter _getListCustomerAccountPresenter;

        #endregion

        public CustomerAccountFrm()
        {
            InitializeComponent();
            ClearText();
            DisableEditButton();
        }

        #region User Inputs  
        public string ID 
        {
            get { return customerIdLabel.Text; }
            set { customerIdLabel.Text = value; }
        }
        public string CustomerName
        {
            get { return customerNameLabel.Text; }
            set { customerNameLabel.Text = value; }
        }
        public string CustomerAddress
        {
            get { return customerAddressLabel.Text; }
            set { customerAddressLabel.Text = value; }
        }
        public string ContactNumber
        {
            get { return contactNumberLabel.Text; }
            set { contactNumberLabel.Text = value; }
        }
        public string BusinessName
        {
            get { return businessNameLabel.Text; }
            set { businessNameLabel.Text = value; }
        }
        public string BusinessNature
        {
            get { return businessNatureLabel.Text; }
            set { businessNatureLabel.Text = value; }
        }
        public string BusinessAddress
        {
            get { return businessAddressLabel.Text; }
            set { businessAddressLabel.Text = value; }
        }
        public decimal GrossBusinessCapital
        {
            get { return Convert.ToDecimal(grossBusinessCapitalLabel.Text); }
            set { grossBusinessCapitalLabel.Text = value.ToString(); }
        }
        public decimal AverageDailyGrossSales
        {
            get { return Convert.ToDecimal(averageDailyGrossSalesLabel.Text); }
            set { averageDailyGrossSalesLabel.Text = value.ToString(); }
        }
        public string UserSearch
        {
            get { return SearchBoxtxt.Text; }
            set { SearchBoxtxt.Text = value; }
        }

        #endregion

        #region Custom Methods

        private void OpenAddCustomerFrm()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _addCustomerFrmComponent = new AddCustomerFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_addCustomerFrmComponent, true);
        }
        private void ToSearch()
        {
            try
            {
                _getListCustomerAccountPresenter = new GetCustomerListPresenter(this);
                _getListCustomerAccountPresenter.CallSearch();
                dataGridView1.DataSource = _getListCustomerAccountPresenter.GetCustomerListData();
            } 
            catch (ArgumentNullException)
            {
                const string MessageContent = "Please type the name or ID of the customer.";
                const string MessageCaption = "Enter Credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (ArgumentException)
            {
                const string MessageContent = "Record not found, please contact your I.T officer if you think there is a problem to the system.";
                const string MessageCaption = "Invalid Credentials";
                MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        private void DisplayTextInForm()
        {
            customerIdLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            customerNameLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            customerAddressLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            contactNumberLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            businessNameLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            businessNatureLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            businessAddressLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            grossBusinessCapitalLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            averageDailyGrossSalesLabel.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            editButton.Enabled = true;
        }
        public void ClearText()
        {
            customerIdLabel.Text = "";
            customerNameLabel.Text = "";
            customerAddressLabel.Text = "";
            contactNumberLabel.Text = "";
            businessNameLabel.Text = "";
            businessNatureLabel.Text = "";
            businessAddressLabel.Text = "";
            grossBusinessCapitalLabel.Text = "";
            averageDailyGrossSalesLabel.Text = "";
        }
        private void DisableEditButton()
        {
            if (customerIdLabel.Text == "" &&
                customerNameLabel.Text == "" &&
                customerAddressLabel.Text == "" &&
                contactNumberLabel.Text == "" &&
                businessNameLabel.Text == "" &&
                businessNatureLabel.Text == "" &&
                businessAddressLabel.Text == "" &&
                grossBusinessCapitalLabel.Text == "" &&
                averageDailyGrossSalesLabel.Text == ""
                )
            {
                editButton.Enabled = false;
            }
        }
        private void LoadInformation()
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _customerAccountFrmData = new CustomerAccountFrmPassData(_concreteMediator, this);
            _concreteMediator.PrepareData(_customerAccountFrmData);
        }

        #endregion

        #region Form Events

        #region Menu Strip

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddCustomerFrm();
        }

        #endregion

        #region TextBox

        private void SearchBoxTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                ToSearch();
                ClearText();
                DisableEditButton();
            }
        }

        #endregion

        #region DataGridView

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayTextInForm();
        }

        #endregion

        #region Button

        private void EditButton_Click(object sender, EventArgs e)
        {
            LoadInformation();
            ClearText();
            DisableEditButton();
            SearchBoxtxt.Text = "";
            dataGridView1.DataSource = null;

            _concreteMediator = new ClassComponentConcreteMediator();
            _editCustomerFrmComponent = new EditCustomerFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_editCustomerFrmComponent, true);
        }

        #endregion

        #endregion

    }
}
