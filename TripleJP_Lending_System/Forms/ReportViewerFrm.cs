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
using TripleJP_Lending_System.FormMediator;
using TripleJP_Lending_System.FormMediator.ConcreteMediator;
using TripleJP_Lending_System.FormMediator.Mediator;
using TripleJPMVPLibrary.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class ReportViewerFrm : Form
    {
        ReportFrmPresenter reportPresenter;
        IFormsMediator _concreteMediator;
        ReportFrmData _reportFrmData;
        public ReportViewerFrm()
        {
            InitializeComponent();            
            InitReport();
        }
        private void InitReport()
        {            
            _concreteMediator = new ClassComponentConcreteMediator();
            _reportFrmData = new ReportFrmData(_concreteMediator);
            string temp = _reportFrmData.GetData()[0];

            if (temp.Equals("SummaryReport"))
            {
                InitSummaryReport();
            }
            if (temp.Equals("DetailReport"))
            {
                InitDetailReport();
            }
        }
        private void InitSummaryReport()
        {
            ReportDataSource rds = new ReportDataSource();
            reportPresenter = new ReportFrmPresenter();

            rds.Name = "CollectionSummaryRpt";
            rds.Value = reportPresenter.OnCallCustomerReportList();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            const string REPORT_SOURCE 
                        = @"C:\Exxxcube files\Triple_JP_Lending_System-main\"+
                          @"TripleJPMVPLibrary\ReportDefinitions\CollectionSummaryReport.rdlc";

            reportViewer1.LocalReport.ReportPath = REPORT_SOURCE;
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
        private void InitDetailReport()
        {
            ReportDataSource rds = new ReportDataSource();
            reportPresenter = new ReportFrmPresenter();

            //rds.Name = "CollectionSummaryRpt";
            //rds.Value = reportPresenter.OnCallCustomerReportList();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;

            const string REPORT_SOURCE
                        = @"C:\Exxxcube files\Triple_JP_Lending_System-main"+
                          @"\TripleJPMVPLibrary\ReportDefinitions\CollectionDetailReport.rdlc";

            reportViewer1.LocalReport.ReportPath = REPORT_SOURCE;
            //reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
