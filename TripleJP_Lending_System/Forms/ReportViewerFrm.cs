using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.IO;
using System.Windows.Forms;
using TripleJP_Lending_System.FormMediator;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class ReportViewerFrm : Form
    {

        #region Fields

        private ReportFrmPresenter reportPresenter;
        private IFormsMediator _concreteMediator;
        private ReportFrmData _reportFrmData;
        private Loan loan;

        #endregion

        public ReportViewerFrm()
        {
            InitializeComponent();            
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                InitReport();
            }
            catch (InvalidOperationException ex) when (ex.InnerException is FormatException)
            {
                const string MessageContent = "No records of collection yet";
                const string MessageCaption = "Report not found";
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

        private void InitReport()
        {            
            _concreteMediator = new ClassComponentConcreteMediator();
            _reportFrmData = new ReportFrmData(_concreteMediator);
            string temp = _reportFrmData.GetData()[1];
            string loanId = _reportFrmData.GetData()[0];

            if (temp.Equals("SummaryReport"))
            {
                InitSummaryReport();
            }
            if (temp.Equals("DetailReport"))
            {
                InitDetailReport(loanId);
            }
        }

        private void InitSummaryReport()
        {
            ReportDataSource rds = new ReportDataSource();
            reportPresenter = new ReportFrmPresenter();

            rds.Name = "CollectionSummaryRpt";
            rds.Value = reportPresenter.OnCallCustomerReportList();
            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            string REPORT_SOURCE = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "TripleJPMVPLibrary", "ReportDefinitions", "CollectionSummaryReport.rdlc");

            reportViewer.LocalReport.ReportPath = REPORT_SOURCE;
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.RefreshReport();
        }

        private void InitDetailReport(string loanId)
        {           
            loan = new Loan();
            loan.Id = loanId;
            ReportDataSource rdsLoanInformationRpt = new ReportDataSource();
            ReportDataSource rdsCollectionRpt = new ReportDataSource();
            reportPresenter = new ReportFrmPresenter();

            if (!IsRowsEmpty())
            {
                rdsLoanInformationRpt.Name = "LoanInformationDataset";
                rdsLoanInformationRpt.Value = reportPresenter.OnCallGetLoanInformationReport(loan);
                rdsCollectionRpt.Name = "CollectionDetailDataset";
                rdsCollectionRpt.Value = reportPresenter.OnCallGetCollectionReport(loan);

                reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                reportViewer.ZoomMode = ZoomMode.PageWidth;
                string REPORT_SOURCE = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "TripleJPMVPLibrary", "ReportDefinitions", "CollectionDetailReport.rdlc");

                reportViewer.LocalReport.ReportPath = REPORT_SOURCE;
                reportViewer.LocalReport.DataSources.Add(rdsLoanInformationRpt);
                reportViewer.LocalReport.DataSources.Add(rdsCollectionRpt);
                reportViewer.RefreshReport();
            }
            else
                NoRecordsErrorMessage();
        }

        internal bool IsRowsEmpty()
        {
            reportPresenter = new ReportFrmPresenter();
            if (reportPresenter.OnCallGetCollectionReport(loan).Rows.Count != 0)
            {
                return false;
            }
            return true;
        }

        private void NoRecordsErrorMessage()
        {
            const string MessageContent = "No records of collection yet";
            const string MessageCaption = "Collection not found";
            MessageBox.Show(MessageContent, MessageCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
}
