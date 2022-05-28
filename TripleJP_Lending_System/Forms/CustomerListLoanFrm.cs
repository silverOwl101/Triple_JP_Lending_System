using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.View;

namespace TripleJP_Lending_System.Forms
{
    public partial class CustomerListLoanFrm : Form, ISearch
    {
        internal static string[] customerLoanInformation = new string[2];

        private IFormsMediator _concreteMediator;
        private AddLoanFrmComponent _addLoanFrmComponent;

        public CustomerListLoanFrm()
        {
            InitializeComponent();
            DefaultPropertyComponents();
        }
        private void DefaultPropertyComponents()
        {
            dataGridView1.DataSource = null;            
        }
        public string UserSearch
        {
            get { return SearchBoxtxt.Text; }
            set { SearchBoxtxt.Text = value; }
        }
        private void onSearch()
        {
            GetCustomerListPresenter customerList = new GetCustomerListPresenter(this);
            customerList.CallSearch();
            if (customerList.GetCustomerListData().Count != 0)
            {
                dataGridView1.DataSource = customerList.GetCustomerListData();
                ColumnHeaderNames();
            }
            else
            {
                dataGridView1.DataSource = null;
            }            
        }
        private void SearchBoxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                onSearch();
            }
        }
        private void onDoubleClickData()
        {
            customerLoanInformation[0] = dataGridView1.Rows[0].Cells[0].Value.ToString();
            customerLoanInformation[1] = dataGridView1.Rows[0].Cells[1].Value.ToString();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex != -1) // this line of code will prevent triggering CellDoubleClick
                                  // event if you double click the column header.
            {
                onDoubleClickData();
                _concreteMediator = new ClassComponentConcreteMediator();
                _addLoanFrmComponent = new AddLoanFrmComponent(_concreteMediator);
                _concreteMediator.OpenForms(_addLoanFrmComponent, true);
            }                        
        }
        private void ColumnHeaderNames()
        {
            dataGridView1.Columns[0].HeaderText = "Customer ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Address";
            dataGridView1.Columns[3].HeaderText = "Contact number";
            dataGridView1.Columns[4].HeaderText = "Business name";
            dataGridView1.Columns[5].HeaderText = "Business nature";
            dataGridView1.Columns[6].HeaderText = "Business address";
            dataGridView1.Columns[7].HeaderText = "Gross business capital";
            dataGridView1.Columns[8].HeaderText = "Average daily gross sales";
        }
    }
}