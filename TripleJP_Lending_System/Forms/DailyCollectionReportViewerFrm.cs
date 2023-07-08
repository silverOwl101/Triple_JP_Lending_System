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
using TripleJPMVPLibrary.View;
using TripleJPMVPLibrary.Presenter;

namespace TripleJP_Lending_System.Forms
{
    public partial class DailyCollectionReportViewerFrm : Form, IDateFromDateTo
    {
        ReportFrmPresenter reportPresenter;

        public DateTime DateFrom 
        {
            get { return dateTimePickerFrom.Value.Date; }
            set { dateTimePickerFrom.Text = value.ToString(); }
        }
        public DateTime DateTo
        {
            get { return dateTimePickerTo.Value.Date; }
            set { dateTimePickerTo.Text = value.ToString(); }
        }

        public DailyCollectionReportViewerFrm()
        {
            InitializeComponent();            
        }
        private void InitSampleReport()
        {
            
            ReportDataSource collectionDs = new ReportDataSource();
            ReportDataSource salaryDs = new ReportDataSource();
            ReportDataSource savingsDs = new ReportDataSource();

            reportPresenter = new ReportFrmPresenter(this);

            collectionDs.Name = "FinalDailyCollectionReport";
            collectionDs.Value = reportPresenter.OnCallGetDailyCollection();           

            reportViewer.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer.ZoomMode = ZoomMode.PageWidth;

            string REPORT_SOURCE = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "TripleJPMVPLibrary", "ReportDefinitions", "DailyCollectionReport.rdlc");

            reportViewer.LocalReport.ReportPath = REPORT_SOURCE;

            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(collectionDs);            

            reportViewer.RefreshReport();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {            
            InitSampleReport();
        }
    }
}
