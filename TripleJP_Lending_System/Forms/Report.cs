using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleJP_Lending_System.Forms
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            rep();
        }
        private void rep()
        {
            reportViewer1.LocalReport.ReportEmbeddedResource
                            = "TripleJP_Lending_System.ReportDefinitions.Report1.rdlc";
            reportViewer1.RefreshReport();
        }
        private void Report_Load(object sender, EventArgs e)
        {
            
        }
    }
}
