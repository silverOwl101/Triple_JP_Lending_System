using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class ReportViewerSummaryFrm : Form
    {
        private ReportFrmPresenter reportPresenter;
        public ReportViewerSummaryFrm()
        {
            InitializeComponent();
        }
        private void InitUnpaidAndBadDebtReport()
        {
            ReportDataSource rdsCollectionSummary = new ReportDataSource();
            ReportDataSource rdsTotalSavingsAndSalary = new ReportDataSource();
            ReportDataSource rdsOverAllCollection = new ReportDataSource();
            reportPresenter = new ReportFrmPresenter();

            rdsCollectionSummary.Name = "CollectionSummaryRpt";
            rdsCollectionSummary.Value = reportPresenter.OnLoadCustomerReportList();
            rdsTotalSavingsAndSalary.Name = "TotalSavingsAndSalaryRpt";
            rdsTotalSavingsAndSalary.Value = reportPresenter.OnLoadGetTotalSavingsGetTotalSalaryAndGetOverAllCollection();
            rdsOverAllCollection.Name = "OverAllCollectionRpt";
            rdsOverAllCollection.Value =
            reportPresenter.OnLoadGetTotalSavingsGetTotalSalaryAndGetOverAllCollection();

            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            string REPORT_SOURCE = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "TripleJPMVPLibrary", "ReportDefinitions", "CollectionSummaryReport.rdlc"); // DailyCollectionReport, CollectionSummaryReport

            reportViewer.LocalReport.ReportPath = REPORT_SOURCE;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rdsCollectionSummary);
            reportViewer.LocalReport.DataSources.Add(rdsTotalSavingsAndSalary);
            reportViewer.LocalReport.DataSources.Add(rdsOverAllCollection);
            reportViewer.RefreshReport();
        }
        private void InitFullyPaidReport()
        {
            ReportDataSource rdsCollectionSummary = new ReportDataSource();
            ReportDataSource rdsTotalSavingsAndSalary = new ReportDataSource();
            ReportDataSource rdsOverAllCollection = new ReportDataSource();
            reportPresenter = new ReportFrmPresenter();

            rdsCollectionSummary.Name = "CollectionSummaryRpt";
            rdsCollectionSummary.Value = reportPresenter.OnLoadGetCollectionSummaryReportPaid();
            rdsTotalSavingsAndSalary.Name = "TotalSavingsAndSalaryRpt";
            rdsTotalSavingsAndSalary.Value = reportPresenter.OnLoadGetTotalSavingsGetTotalSalaryAndGetOverAllCollection();
            rdsOverAllCollection.Name = "OverAllCollectionRpt";
            rdsOverAllCollection.Value =
            reportPresenter.OnLoadGetTotalSavingsGetTotalSalaryAndGetOverAllCollection();

            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            string REPORT_SOURCE = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "TripleJPMVPLibrary", "ReportDefinitions", "CollectionSummaryReport_Paid.rdlc");

            reportViewer.LocalReport.ReportPath = REPORT_SOURCE;
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rdsCollectionSummary);
            reportViewer.LocalReport.DataSources.Add(rdsTotalSavingsAndSalary);
            reportViewer.LocalReport.DataSources.Add(rdsOverAllCollection);

            reportViewer.RefreshReport();
        }
        private void generateReportButton_Click(object sender, EventArgs e)
        {         
            if (comboBoxStatus.Text == "Fully Paid")
            {
                InitFullyPaidReport();
            }
            if (comboBoxStatus.Text == "Unpaid and Bad debt")
            {
                InitUnpaidAndBadDebtReport();
            }
        }

        private void ReportViewerSummaryFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
