using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Service;

namespace TripleJPMVPLibrary.Presenter
{
    public class ReportFrmPresenter
    {
        ReportService reportService;
        public DataTable OnCallCustomerReportList()
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnCallGetCustomerListReport().Tables["CollectionSummaryReport"];
            return tb;
        }
    }
}
