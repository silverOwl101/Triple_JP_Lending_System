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
        public DataTable OnCallGetLoanInformationReport(Loan loan)
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnCallGetLoanInformationReport(loan).Tables["LoanInformationReport"];
            return tb;
        }
        public DataTable OnCallGetCollectionReport(Loan loan)
        {
            reportService = new ReportService();
            DataTable tb1 = new DataTable();
            DataTable tb2 = new DataTable();
            tb1 = reportService.OnCallGetCollectionReport(loan).Tables["CollectionDetailReport"];
            tb2 = reportService.OnCallGetPenaltyReport(loan).Tables["PenaltyDetailReport"];

            foreach (DataRow row in tb2.Rows)
            {
                DataRow newRow = tb1.NewRow();
                newRow["ID"] = row["ID"];
                newRow["Date"] = row["Date"];
                newRow["Penalty"] = row["Penalty"];

                tb1.Rows.Add(newRow);
            }

            DataView dataView = tb1.AsDataView();
            dataView.Sort = "Date ASC";
            tb1 = dataView.ToTable();
            return tb1;
        }
    }
}
