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
        #region Fields

        private string _getLoanID;
        private ClassComponentConcreteMediator _concreteMediator;
        private CustomerListLoanFrmComponent _customerListLoanFrmComponent;
        private LedgerFormComponent _ledgerFormComponent;
        private LoanInformationPresenter _loanInformationPresenter;
        private LoanInformationFrmPassData _loanInformationFrmPassData;
        private string[] _filterDataVariables = new string[3];

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
            _filterDataVariables[0] = "";
            _filterDataVariables[1] = "";
            _filterDataVariables[2] = "";
        }

        #region User Inputs

        public string UserSearch
        {
            get { return SearchBoxTxt.Text; }
            set { SearchBoxTxt.Text = value; }
        }

        #endregion

        private void DisabledControls()
        {
            ledgerButton.Enabled = false;
            dataGridView1.Enabled = false;
            groupBox15.Enabled = false;
        }

        private void OnSearch()
        {
            try
            {
                _loanInformationPresenter = new LoanInformationPresenter(this);

                listNullChecker(_loanInformationPresenter.GetLoanInformationList());

                if (_loanInformationPresenter.GetLoanInformationList().Count == 0)
                {
                    const string MessageContent = "Record not found, please contact your I.T officer if you think there is a problem to the system.";
                    const string MessageCaption = "Invalid Credentials";
                    MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (ledgerButton.Enabled && dataGridView1.Enabled && groupBox15.Enabled)
                    {
                        ClearText();
                        dataGridView1.DataSource = null;
                        DisabledControls();
                    }

                }
                else
                {
                    ViewAllData();
                }

            }
            catch (ArgumentNullException ex) when (ex.ParamName is "UserSearch")
            {
                const string MessageContent = "Please type the name or ID of the customer.";
                const string MessageCaption = "Enter Credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        private void SearchBoxTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                OnSearch();
            }
        }
        private void DisplayDataInForm()
        {
            loanIdTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            customerIdTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            customerNameTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            paymentTermTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            durationTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            effectiveDateTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            interestTxt.Text = String.Format("{0:P}",
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value);
            principalLoanTxt.Text = String.Format("{0:N}",
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[7].Value);
            penaltyTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[8].Value.ToString();
            statusTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[9].Value.ToString();
            totalAmountRemittanceTxt.Text =
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[10].Value.ToString();
        }
        private void ClearText()
        {
            loanIdTxt.Text = "";
            customerIdTxt.Text = "";
            customerNameTxt.Text = "";
            paymentTermTxt.Text = "";
            durationTxt.Text = "";
            effectiveDateTxt.Text = "";
            interestTxt.Text = "";
            principalLoanTxt.Text = "";
            penaltyTxt.Text = "";
            statusTxt.Text = "";
            maturityInterestTxt.Text = "";
            maturityValueTxt.Text = "";
            maturityDateTxt.Text = "";
            perRemittanceTxt.Text = "";
            totalAmountRemittanceTxt.Text = "";
            totalBalanceTxt.Text = "";
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
            SearchBoxTxt.Text = "";
            ClearText();
            //check if ledgerButton, dataGridView1 and groupBox15 is enabled
            if (ledgerButton.Enabled && dataGridView1.Enabled && groupBox15.Enabled)
            {
                DisabledControls();
            }            
        }
        private void maturityInterestDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanTxt.Text);
            Computation comp = new Computation();
            maturityInterestTxt.Text = String.Format("{0:N}", comp.MaturityInterest(loan));
        }
        private void maturityValueDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanTxt.Text);
            Computation comp = new Computation();
            decimal interest = Convert.ToDecimal(maturityInterestTxt.Text);
            maturityValueTxt.Text = String.Format("{0:N}", comp.MaturityValue(interest, loan));
        }
        private void perRemittanceDisplay()
        {
            Computation comp = new Computation();
            decimal _value = Convert.ToDecimal(maturityValueTxt.Text);
            int duration = Convert.ToInt32(durationTxt.Text);
            perRemittanceTxt.Text = comp.PerRemittance(_value, duration).ToString();
        }
        private void maturityDate()
        {
            Computation comp = new Computation();
            DateTime effectiveDate = DateTime.ParseExact(effectiveDateTxt.Text, "MM-dd-yyyy", null);
            int duration = Convert.ToInt32(durationTxt.Text);
            maturityDateTxt.Text = comp.MaturityDate(effectiveDate, duration).ToString("MM-dd-yyyy");
        }
        private void totalAmountRemittance()
        {
            decimal result;
            if (string.IsNullOrEmpty(totalAmountRemittanceTxt.Text))
            {
                totalAmountRemittanceTxt.Text = "0";
            }
            if (string.IsNullOrEmpty(totalBalanceTxt.Text))
            {
                totalBalanceTxt.Text = "0";
            }
            else
            {
                result = Convert.ToDecimal(maturityValueTxt.Text) - Convert.ToDecimal(totalAmountRemittanceTxt.Text);
                totalBalanceTxt.Text = String.Format("{0:N}", result);
            }

        }
        private void ledgerButton_Click(object sender, EventArgs e)
        {
            _getLoanID = loanIdTxt.Text;
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
                _filterDataVariables[0] = AssignEnumFilter(Filter.Unpaid);
                FilterData(_filterDataVariables);                
            }
            else
            {
                _filterDataVariables[0] = AssignEnumFilter(Filter.None);
                FilterData(_filterDataVariables);                
            }
            isSearchFilterCheckBoxChecked();
        }        
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                _filterDataVariables[1] = AssignEnumFilter(Filter.FullyPaid);
                FilterData(_filterDataVariables);                
            }
            else
            {
                _filterDataVariables[1] = AssignEnumFilter(Filter.None);
                FilterData(_filterDataVariables);                
            }
            isSearchFilterCheckBoxChecked();
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                _filterDataVariables[2] = AssignEnumFilter(Filter.BadDebt);
                FilterData(_filterDataVariables);                
            }
            else
            {
                _filterDataVariables[2] = AssignEnumFilter(Filter.None);
                FilterData(_filterDataVariables);                
            }
            isSearchFilterCheckBoxChecked();
        }
        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            ledgerButton.Enabled = true;
        }
        private void FilterData(string[] array)
        {
            _loanInformationPresenter = new LoanInformationPresenter(this);
            List<GetCustomerLoanInformation> unPaidList =
                                        new List<GetCustomerLoanInformation>();
            unPaidList = _loanInformationPresenter.GetLoanInformationList();
            List<GetCustomerLoanInformation> result = new List<GetCustomerLoanInformation>();
            var query = from list in unPaidList
                        where list.Status == array[0] ||
                              list.Status == array[1] ||
                              list.Status == array[2]
                        select list;
            foreach (var item in query)
            {
                if (!string.IsNullOrEmpty(item.Status))
                {
                    result.Add(item);
                }
                else
                {
                    throw new ArgumentNullException("Fatal Error, contact your I.T officer" +
                                                    " immediately");
                }                
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
            dataGridView1.DataSource = _loanInformationPresenter.GetLoanInformationList();            
            ColumnHeaderNames();            
            dataGridView1.Enabled = true;
            groupBox15.Enabled = true;
            dataGridView1.Focus();
        }
        private void CheckBoxNotAllCheckedViewAllData()
        {
            dataGridView1.DataSource = _loanInformationPresenter.GetLoanInformationList();
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

        //wako ka gets lage ani?
        private void listNullChecker(List<GetCustomerLoanInformation> list)
        {
            foreach (var item in list)
            {
                if (string.IsNullOrEmpty(item.Status))
                {
                    throw new ArgumentNullException("Fatal Error, contact your I.T officer" +
                                                    " immediately");
                }
            }
        }
    }
}
