using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Presenter;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.Accounting;
using TripleJP_Lending_System.FormMediator.Component;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

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
        private ReportFrmComponent _reportFrmComponent;
        private string[] _filterDataVariables = new string[3];

        #endregion

        public LoanInformationFrm()
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

        #endregion

        #region Form Events

        #region TextBox

        private void SearchBoxTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                OnSearch();
                unPaidCheckBox.Checked = false;
                fullyPaidCheckBox.Checked = false;
                badDebtCheckBox.Checked = false;
            }
        }

        #endregion

        #region Menu Strip

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _concreteMediator = new ClassComponentConcreteMediator();
            _customerListLoanFrmComponent = new CustomerListLoanFrmComponent(_concreteMediator);
            _concreteMediator.OpenForms(_customerListLoanFrmComponent, true);
            loanDataGridView.DataSource = null;
            searchTextBox.Text = "";
            ClearText();
            //check if ledgerButton, dataGridView1 and searchFilterGroupBox is enabled
            if (loanDataGridView.Enabled && searchFilterGroupBox.Enabled)
            {
                DisabledControls();
            }
        }

        #endregion

        #region Data Grid View

        private void DataGridView1_Enter(object sender, EventArgs e)
        {
            //ledgerButton.Enabled = true;
            generateAccountStatementButton.Enabled = true;
        }
        private void DataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ToDisplayInForm();
        }
        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ToDisplayInForm();
        }
        private void loanDataGridView_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            foreach (DataGridViewRow row in loanDataGridView.Rows)
            {
                string cellvalue = row.Cells[8].Value.ToString();

                if (cellvalue == "Unpaid")
                {
                    loanDataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Gray;
                }
                if (cellvalue == "Fully Paid")
                {
                    loanDataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.White;
                }
                if (cellvalue == "Bad Debt")
                {
                    loanDataGridView.Rows[row.Index].DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

        #endregion

        #region Buttons

        private void LedgerButton_Click(object sender, EventArgs e)
        {
            _getLoanID = loanIdLabel.Text;
            _concreteMediator = new ClassComponentConcreteMediator();
            _loanInformationFrmPassData = new LoanInformationFrmPassData(_concreteMediator, _getLoanID,string.Empty);
            _ledgerFormComponent = new LedgerFormComponent(_concreteMediator);
            _concreteMediator.PrepareData(_loanInformationFrmPassData);
            _concreteMediator.OpenForms(_ledgerFormComponent, true);
        }
        private void generateAccountStatementButton_Click(object sender, EventArgs e)
        {
            const string detailReportParameter = "DetailReport";
            _getLoanID = loanIdLabel.Text;
            _concreteMediator = new ClassComponentConcreteMediator();
            _loanInformationFrmPassData = new LoanInformationFrmPassData(_concreteMediator, _getLoanID, detailReportParameter);
            _reportFrmComponent = new ReportFrmComponent(_concreteMediator);
            _concreteMediator.PrepareData(_loanInformationFrmPassData);
            _concreteMediator.OpenForms(_reportFrmComponent, true);
        }

        #endregion

        #region Check Boxes

        private void UnpaidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (unPaidCheckBox.Checked)
            {
                _filterDataVariables[0] = AssignEnumFilter(Filter.Unpaid);
                FilterData(_filterDataVariables);
            }
            else
            {
                _filterDataVariables[0] = AssignEnumFilter(Filter.None);
                FilterData(_filterDataVariables);
            }
            IsSearchFilterCheckBoxChecked();
        }
        private void FullyPaidCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (fullyPaidCheckBox.Checked)
            {
                _filterDataVariables[1] = AssignEnumFilter(Filter.FullyPaid);
                FilterData(_filterDataVariables);
            }
            else
            {
                _filterDataVariables[1] = AssignEnumFilter(Filter.None);
                FilterData(_filterDataVariables);
            }
            IsSearchFilterCheckBoxChecked();
        }
        private void BadDebtCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (badDebtCheckBox.Checked)
            {
                _filterDataVariables[2] = AssignEnumFilter(Filter.BadDebt);
                FilterData(_filterDataVariables);
            }
            else
            {
                _filterDataVariables[2] = AssignEnumFilter(Filter.None);
                FilterData(_filterDataVariables);
            }
            IsSearchFilterCheckBoxChecked();
        }

        #endregion

        #endregion

        #region Custom Methods

        #region Form Tool Control Methods

        private void DefaultPropertyComponents()
        {
            ClearText();
            DisabledControls();
            _filterDataVariables[0] = "";
            _filterDataVariables[1] = "";
            _filterDataVariables[2] = "";
        }

        private void ClearText()
        {
            loanIdLabel.Text = "";
            customerIdLabel.Text = "";
            customerNameLabel.Text = "";
            paymentTermLabel.Text = "";
            durationLabel.Text = "";
            effectiveDateLabel.Text = "";
            interestLabel.Text = "";
            principalLoanLabel.Text = "";
            penaltyLabel.Text = "";
            statusLabel.Text = "";
            maturityInterestLabel.Text = "";
            maturityValueLabel.Text = "";
            maturityDateLabel.Text = "";
            perRemittanceLabel.Text = "";
            totalAmountRemittanceLabel.Text = "";
            totalBalanceLabel.Text = "";
            totalLoanPenaltyLabel.Text = "";
        }

        private void DisabledControls()
        {
            //ledgerButton.Enabled = false;
            loanDataGridView.Enabled = false;
            searchFilterGroupBox.Enabled = false;
            generateAccountStatementButton.Enabled = false;
        }

        #endregion

        private void OnSearch()
        {
            try
            {
                _loanInformationPresenter = new LoanInformationPresenter(this);

                ListNullChecker(_loanInformationPresenter.GetLoanInformationList());

                if (_loanInformationPresenter.GetLoanInformationList().Count == 0)
                {
                    const string MessageContent = "Record not found, please contact your I.T officer if you think there is a problem to the system.";
                    const string MessageCaption = "Invalid Credentials";
                    MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    if (loanDataGridView.Enabled && searchFilterGroupBox.Enabled)
                    {
                        ClearText();
                        loanDataGridView.DataSource = null;
                        DisabledControls();
                    }

                }
                else
                {
                    // view all data

                    loanDataGridView.DataSource = _loanInformationPresenter.GetLoanInformationList();
                    ColumnHeaderNames();
                    loanDataGridView.Enabled = true;
                    searchFilterGroupBox.Enabled = true;
                    loanDataGridView.Focus();
                }

            }
            catch (ArgumentNullException ex) when (ex.ParamName is "UserSearch")
            {
                const string MessageContent = "Please type the name or ID of the customer.";
                const string MessageCaption = "Enter Credentials";
                MessageBox.Show(MessageContent, MessageCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (InvalidOperationException ex) when (ex.InnerException is MySqlException)
            {
                const string MessageContent = "There is a problem to the system please contact your I.T officer for further information.";
                const string MessageCaption = "System Access Denied";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (TypeInitializationException ex) when (ex.InnerException is FileNotFoundException)
            {
                const string MessageContent = "Configuration file is missing, please create a config file first.";
                const string MessageCaption = "Configuration lost";
                MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ListNullChecker(List<GetCustomerLoanInformation> list)
        {
            foreach (var item in list)
            {
                if (string.IsNullOrEmpty(item.Status))
                {
                    throw new ArgumentNullException(nameof(list), "list is Null");
                }
            }
        }

        #region Form Data Display Methods

        private void ColumnHeaderNames()
        {
            loanDataGridView.Columns[0].HeaderText = "Loan ID";
            loanDataGridView.Columns[1].HeaderText = "Customer ID";
            loanDataGridView.Columns[2].HeaderText = "Customer Name";
            loanDataGridView.Columns[3].HeaderText = "Payment Term";
            loanDataGridView.Columns[5].HeaderText = "Effective Date";
            loanDataGridView.Columns[6].HeaderText = "Interest Rate";
            loanDataGridView.Columns[7].HeaderText = "Principal Loan";
        }

        private void ToDisplayInForm()
        {
            DisplayDataInForm();
            MaturityInterestDisplay();
            MaturityValueDisplay();
            PerRemittanceDisplay();
            MaturityDateDisplay();
            TotalAmountRemittanceDisplay();
        }

        private void DisplayDataInForm()
        {
            decimal rate;
            loanIdLabel.Text = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[0].Value.ToString();
            customerIdLabel.Text = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[1].Value.ToString();
            customerNameLabel.Text = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[2].Value.ToString();
            paymentTermLabel.Text = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[3].Value.ToString();
            durationLabel.Text = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[4].Value.ToString();
            effectiveDateLabel.Text = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[5].Value.ToString();
            rate = Convert.ToDecimal(loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[6].Value)/100;
            interestLabel.Text = String.Format("{0:0%}", rate);
            principalLoanLabel.Text = String.Format("{0:N}", loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[7].Value);            
            statusLabel.Text = loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[8].Value.ToString();
            totalAmountRemittanceLabel.Text = String.Format("{0:N}", loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[9].Value);
            penaltyLabel.Text = String.Format("{0:N}", loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[10].Value);
        }

        private void MaturityInterestDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanLabel.Text);
            Computation comp = new Computation();
            decimal interestRate = Convert.ToDecimal(loanDataGridView.Rows[loanDataGridView.CurrentRow.Index].Cells[6].Value);
            maturityInterestLabel.Text = String.Format("{0:N}", comp.MaturityInterest(loan, interestRate));
        }
        private void MaturityValueDisplay()
        {
            decimal loan = Convert.ToDecimal(principalLoanLabel.Text);
            Computation comp = new Computation();
            decimal interest = Convert.ToDecimal(maturityInterestLabel.Text);
            maturityValueLabel.Text = String.Format("{0:N}", comp.MaturityValue(interest, loan));
        }
        private void PerRemittanceDisplay()
        {
            Computation comp = new Computation();
            decimal _value = Convert.ToDecimal(maturityValueLabel.Text);
            int duration = Convert.ToInt32(durationLabel.Text);
            perRemittanceLabel.Text = comp.PerRemittance(_value, duration).ToString();
        }
        private void MaturityDateDisplay()
        {
            Computation comp = new Computation();
            DateTime effectiveDate = DateTime.ParseExact(effectiveDateLabel.Text, "MM-dd-yyyy", null);
            int duration = Convert.ToInt32(durationLabel.Text);
            maturityDateLabel.Text = comp.MaturityDate(effectiveDate, duration).ToString("MM-dd-yyyy");
        }
        private void TotalAmountRemittanceDisplay()
        {
            if (string.IsNullOrEmpty(maturityValueLabel.Text))
            {
                maturityValueLabel.Text = "0";
            }
            if (string.IsNullOrEmpty(totalAmountRemittanceLabel.Text))
            {
                totalAmountRemittanceLabel.Text = "0";
            }
            
            decimal remaining_balance = 0;
            decimal totalBalanceResult = 0;
            decimal totalLoanPenaltyResult = 0;

            totalLoanPenaltyResult = Convert.ToDecimal(penaltyLabel.Text) +
                                     Convert.ToDecimal(maturityValueLabel.Text);
            totalLoanPenaltyLabel.Text = String.Format("{0:N}", totalLoanPenaltyResult);

            remaining_balance = Convert.ToDecimal(totalAmountRemittanceLabel.Text) - Convert.ToDecimal(maturityValueLabel.Text);
            totalBalanceResult = Convert.ToDecimal(totalLoanPenaltyLabel.Text) - Convert.ToDecimal(totalAmountRemittanceLabel.Text);
            totalBalanceLabel.Text = String.Format("{0:N}", totalBalanceResult);
        }

        #endregion

        #region Form Data Filter Methods

        private void FilterData(string[] array)
        {
            _loanInformationPresenter = new LoanInformationPresenter(this);
            List<GetCustomerLoanInformation> loanInformationList = new List<GetCustomerLoanInformation>();
            loanInformationList = _loanInformationPresenter.GetLoanInformationList();
            List<GetCustomerLoanInformation> result = new List<GetCustomerLoanInformation>();

            var filteredInformationList = from list in loanInformationList
                                          where list.Status == array[0] ||
                                          list.Status == array[1] ||
                                          list.Status == array[2]
                                          select list;

            foreach (var loan in filteredInformationList)
            {
                if (!string.IsNullOrEmpty(loan.Status))
                {
                    result.Add(loan);
                }
            }
            loanDataGridView.DataSource = result;
            loanDataGridView.Focus();
        }

        private void IsSearchFilterCheckBoxChecked()
        {
            if (!unPaidCheckBox.Checked && !fullyPaidCheckBox.Checked && !badDebtCheckBox.Checked)
            {
                loanDataGridView.DataSource = _loanInformationPresenter.GetLoanInformationList();
                ColumnHeaderNames();
                loanDataGridView.Focus();
            }
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
                    throw new ArgumentNullException(nameof(filter) ,"filter is Null");
            }
        }

        #endregion

        #endregion        
    }
}
