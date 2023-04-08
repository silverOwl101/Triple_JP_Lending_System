using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class ReportViewerFrm : Form
    {
        ReportFrmPresenter report;
        public ReportViewerFrm()
        {
            InitializeComponent();
            rep();
        }
        private void rep()
        {
            ReportDataSource rds = new ReportDataSource();
            report = new ReportFrmPresenter();
            rds.Name = "CollectionSummaryRpt";
            rds.Value = report.OnCallCustomerReportList();

            const string REPORT_SOURCE 
                                    = @"C:\Exxxcube files\Triple_JP_Lending_System-main\TripleJPMVPLibrary\ReportDefinitions\CollectionSummaryReport.rdlc";
            reportViewer1.LocalReport.ReportPath = REPORT_SOURCE;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            
        }
    }
}
