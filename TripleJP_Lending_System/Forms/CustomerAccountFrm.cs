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
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;

namespace TripleJP_Lending_System.Forms
{
    public partial class CustomerAccountFrm : Form, ISearch, IAddCustomer, IEditCustomer
    {
        //internal static string[] customerInformation = new string[9];
        private IFormsMediator _concreteMediator;
        private AddCustomerFrmComponent _addCustomerFrmComponent;
        private EditCustomerFrmComponent _editCustomerFrmComponent;
        //private CustomerAccountFrmComponent _customerAccountFrmComponent;
        private CustomerAccountFrmPassData _customerAccountFrmData;

        public CustomerAccountFrm()
        {
            InitializeComponent();
            ClearText();
            DisableEditButton();
        }

        #region User Inputs  
        public string ID 
        {
            get { return label1.Text; }
            set { label1.Text = value; }
        }
        public string CustomerName
        {
            get { return label2.Text; }
            set { label2.Text = value; }
        }
        public string CustomerAddress
        {
            get { return label3.Text; }
            set { label3.Text = value; }
        }
        public string ContactNumber
        {
            get { return label4.Text; }
            set { label4.Text = value; }
        }
        public string BusinessName
        {
            get { return label5.Text; }
            set { label5.Text = value; }
        }
        public string BusinessNature
        {
            get { return label6.Text; }
            set { label6.Text = value; }
        }
        public string BusinessAddress
        {
            get { return label7.Text; }
            set { label7.Text = value; }
        }
        public decimal GrossBusinessCapital
        {
            get { return Convert.ToDecimal(label8.Text); }
            set { label8.Text = value.ToString(); }
        }
        public decimal AveDailyGrossSales
        {
            get { return Convert.ToDecimal(label9.Text); }
            set { label9.Text = value.ToString(); }
        }
        #endregion

        public string UserSearch 
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
            _concreteMediator = new ClassComponentConcreteMediator();
            _addCustomerFrmComponent = new AddCustomerFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_addCustomerFrmComponent, true);
            
            
            //AddCustomerFrm addCustomer = new AddCustomerFrm();
            //addCustomer.ShowDialog();
        }
        private void SearchBoxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {                
                ToSearch();
                ClearText();
                DisableEditButton();
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
            label1.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            label4.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            label5.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            label6.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            label7.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value.ToString();
            label8.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value.ToString();
            label9.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            button2.Enabled = true;
            //label12.Text = dataGridView1.Rows[0].Cells[9].Value.ToString(); 
        }
        public void ClearText()
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
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DisplayTextInForm();
        }
        private void DisableEditButton()
        {
            if (label1.Text == "" &&
                label2.Text == "" &&
                label3.Text == "" &&
                label4.Text == "" &&
                label5.Text == "" &&
                label6.Text == "" &&
                label7.Text == "" &&
                label8.Text == "" &&
                label9.Text == ""
                )
            {
                button2.Enabled = false;
            }            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            LoadInformation();
            _concreteMediator = new ClassComponentConcreteMediator();
            _editCustomerFrmComponent = new EditCustomerFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_editCustomerFrmComponent, true);
            //EditCustomerFrm openEditCustomerFrm = new EditCustomerFrm();
            //openEditCustomerFrm.ShowDialog();
            ClearText();
            DisableEditButton();
            SearchBoxtxt.Text = "";
            dataGridView1.DataSource = null;
        }
        private void LoadInformation()
        {
            //_customerAccountFrmComponent = new CustomerAccountFrmComponent(this);
            //

            _concreteMediator = new ClassComponentConcreteMediator();
            _customerAccountFrmData = new CustomerAccountFrmPassData(_concreteMediator, this);
            _concreteMediator.PrepareData(_customerAccountFrmData);

        }
    }
}
