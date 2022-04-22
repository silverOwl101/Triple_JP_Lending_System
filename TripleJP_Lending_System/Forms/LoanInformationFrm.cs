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
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.Accounting;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;

namespace TripleJP_Lending_System.Forms
{
    enum Filter
    {
        None,
        Unpaid,
        FullyPaid,
        BadDebt
    }
    public partial class LoanInformationFrm : Form, ISearch
    {
        #region Private fields
        private string _getLoanID;
        private IFormsMediator _concreteMediator;
        private CustomerListLoanFrmComponent _customerListLoanFrmComponent;
        private LedgerFormComponent _ledgerFormComponent;
        private LoanInformationPresenter loanInformationPresenter;
        private LoanInformationFrmPassData _loanInformationFrmPassData;
        private string[] filterDataVariables = new string[3];
        #endregion
        public LoanInformationFrm()
        {
            InitializeComponent();
            DefaultPropertyComponents();
        }
        private void DefaultPropertyComponents()
        {
            ClearText();
            DisabledControls();
            filterDataVariables[0] = "";
            filterDataVariables[1] = "";
            filterDataVariables[2] = "";
        }
        public string UserSearch
        {
            get { return SearchBoxtxt.Text; }
            set { SearchBoxtxt.Text = value; }
        }
        private void DisabledControls()
        {
            ledgerButton.Enabled = false;
            dataGridView1.Enabled = false;
            groupBox15.Enabled = false;
        }
        private void OnSearch()
        {
            loanInformationPresenter = new LoanInformationPresenter(this);
            if (loanInformationPresenter.GetLoanInformationList().Count == 0)
            {
                const string MessageContent = "Double check the entry" +
                                              " or contact your I.T personnel" +
                                              " for futher details";
                string MessageCaption = "Record not found";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (ledgerButton.Enabled && dataGridView1.Enabled && groupBox15.Enabled)
                {
                    ClearText();
                    dataGridView1.DataSource = null;
                    DisabledControls();
                }
                else
                {
                    ;
                }
            }
            else
            {
                ViewAllData();
            }
        }
        private void ColumnHeaderNames()
        {
            dataGridView1.Columns[0].HeaderText = "Loan ID";
            dataGridView1.Columns[1].HeaderText = "Customer ID";
            dataGridView1.Columns[2].HeaderText = "Customer Name";
            dataGridView1.Columns[3].HeaderText = "Payment Term";
            dataGridView1.Columns[5].HeaderText = "Effective Date";
            dataGridView1.Columns[7].HeaderText = "Principal Loan";
        }
        private void SearchBoxtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                OnSearch();
            }
        }
        private void DisplayDataInForm()
        {
            label1.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            label2.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            label3.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            label4.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            label5.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            label6.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            label7.Text = String.Format("{0:P}",
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value);
            label8.Text = String.Format("{0:N}",
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value);
            label9.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            label10.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
            label12.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
        }
        private void ClearText()
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
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            label20.Text = "";
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ToDisplayInForm();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _customerListLoanFrmComponent = new CustomerListLoanFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_customerListLoanFrmComponent, true);
            dataGridView1.DataSource = null;
            SearchBoxtxt.Text = "";
            ClearText();
            //check if ledgerButton, dataGridView1 and groupBox15 is enabled
            if (ledgerButton.Enabled && dataGridView1.Enabled && groupBox15.Enabled)
            {
                DisabledControls();
            }            
        }
        private void maturityInterestDisplay()
        {
            decimal loan = Convert.ToDecimal(label8.Text);
            Computation comp = new Computation();
            label20.Text = String.Format("{0:N}", comp.MaturityInterest(loan));
        }
        private void maturityValueDisplay()
        {
            decimal loan = Convert.ToDecimal(label8.Text);
            Computation comp = new Computation();
            decimal interest = Convert.ToDecimal(label20.Text);
            label18.Text = String.Format("{0:N}", comp.MaturityValue(interest, loan));
        }
        private void perRemittanceDisplay()
        {
            Computation comp = new Computation();
            decimal _value = Convert.ToDecimal(label18.Text);
            int duration = Convert.ToInt32(label5.Text);
            label17.Text = comp.PerRemittance(_value, duration).ToString();
        }
        private void maturityDate()
        {
            Computation comp = new Computation();
            DateTime effectiveDate = Convert.ToDateTime(label6.Text);
            int duration = Convert.ToInt32(label5.Text);
            label19.Text = comp.MaturityDate(effectiveDate, duration).ToString("MM-dd-yyyy");
        }
        private void totalAmountRemittance()
        {
            decimal result;
            if (string.IsNullOrEmpty(label12.Text))
            {
                label12.Text = "0";
            }
            if (string.IsNullOrEmpty(label11.Text))
            {
                label11.Text = "0";
            }
            else
            {
                result = Convert.ToDecimal(label18.Text) - Convert.ToDecimal(label12.Text);
                label11.Text = String.Format("{0:N}", result);
            }

        }
        private void ledgerButton_Click(object sender, EventArgs e)
        {
            _getLoanID = label1.Text;
            _concreteMediator = new ClassComponentConcreteMediator();
            _loanInformationFrmPassData =
                        new LoanInformationFrmPassData(_concreteMediator, _getLoanID);
            _ledgerFormComponent = new LedgerFormComponent(_concreteMediator);
            _concreteMediator.PrepareData(_loanInformationFrmPassData);
            _concreteMediator.OpenForms(_ledgerFormComponent, true);
        }
        private void ToDisplayInForm()
        {
            DisplayDataInForm();
            maturityInterestDisplay();
            maturityValueDisplay();
            perRemittanceDisplay();
            maturityDate();
            totalAmountRemittance();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ToDisplayInForm();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                filterDataVariables[0] = AssignEnumFilter(Filter.Unpaid);
                FilterData(filterDataVariables);                
            }
            else
            {
                filterDataVariables[0] = AssignEnumFilter(Filter.None);
                FilterData(filterDataVariables);                
            }
            isSearchFilterCheckBoxChecked();
        }        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                filterDataVariables[1] = AssignEnumFilter(Filter.FullyPaid);
                FilterData(filterDataVariables);                
            }
            else
            {
                filterDataVariables[1] = AssignEnumFilter(Filter.None);
                FilterData(filterDataVariables);                
            }
            isSearchFilterCheckBoxChecked();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                filterDataVariables[2] = AssignEnumFilter(Filter.BadDebt);
                FilterData(filterDataVariables);                
            }
            else
            {
                filterDataVariables[2] = AssignEnumFilter(Filter.None);
                FilterData(filterDataVariables);                
            }
            isSearchFilterCheckBoxChecked();
        }
        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            ledgerButton.Enabled = true;
        }
        private void FilterData(string[] array)
        {
            loanInformationPresenter = new LoanInformationPresenter(this);
            List<GetCustomerLoanInformation> unPaidList =
                                        new List<GetCustomerLoanInformation>();
            unPaidList = loanInformationPresenter.GetLoanInformationList();
            List<GetCustomerLoanInformation> result = new List<GetCustomerLoanInformation>();
            var query = from list in unPaidList
                        where list.Status == array[0] ||
                              list.Status == array[1] ||
                              list.Status == array[2]
                        select list;
            foreach (var item in query)
            {
                result.Add(item);
            }
            dataGridView1.DataSource = result;
            dataGridView1.Focus();
        }
        private void isSearchFilterCheckBoxChecked()
        {
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                CheckBoxNotAllCheckedViewAllData();
            }            
        }
        private void ViewAllData()
        {
            dataGridView1.DataSource = loanInformationPresenter.GetLoanInformationList();
            ColumnHeaderNames();
            ClearText();
            dataGridView1.Enabled = true;
            groupBox15.Enabled = true;
            dataGridView1.Focus();
        }
        private void CheckBoxNotAllCheckedViewAllData()
        {
            dataGridView1.DataSource = loanInformationPresenter.GetLoanInformationList();
            ColumnHeaderNames();            
            dataGridView1.Focus();
        }
        private string AssignEnumFilter(Filter filter)
        {            
            switch (filter)
            {
                case Filter.Unpaid:
                    return "Unpaid";                
                case Filter.FullyPaid:
                    return "Fully Paid";
                case Filter.BadDebt:
                    return "Bad Debt";
                case Filter.None:
                    return string.Empty;
                default:
                    throw new ArgumentNullException("You must fill the filter parameter" +
                                                    "Please contact your I.T officer for " +
                                                    "further assistance.");
            }
        }
    }
}
