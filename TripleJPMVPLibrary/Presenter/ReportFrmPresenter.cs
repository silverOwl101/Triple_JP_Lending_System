using Mysqlx.Resultset;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.ReportDataSets;
using TripleJPMVPLibrary.Service;
using TripleJPMVPLibrary.View;

namespace TripleJPMVPLibrary.Presenter
{
    public class ReportFrmPresenter
    {
        IDateFromDateTo _addDate;
        public ReportFrmPresenter()
        {
            
        }
        public ReportFrmPresenter(IDateFromDateTo addDate)
        {
            _addDate = addDate;
        }
        ReportService reportService;
        public DataTable OnCallCustomerReportList()
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnCallGetCustomerListReport().Tables["CollectionSummaryReport"];
            return tb;
        }
        public DataTable OnCallGetCollectionSummaryReportPaid()
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnCallGetCollectionSummaryReportPaid().Tables["CollectionSummaryReport_Paid"];
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
        public DataTable OnCallGetDailyCollection()
        {            
            reportService = new ReportService();
            //CrystalReportDataSet dataset = new CrystalReportDataSet();

            DataTable tb1 = reportService.OnCallGetDailyCollection(_addDate.DateFrom,_addDate.DateTo).Tables["DailyCollectionReport"];
           
            return tb1;
        }
        public DataTable OnCallGetSavingsSalaryExpensesSummary()
        {
            reportService = new ReportService();            

            DataTable tb1 = reportService.OnCallGetSavingsSalaryExpensesSummary
                            (_addDate.DateFrom, _addDate.DateTo).
                            Tables["SavingsSalaryExpensesSummaryReport"];
            return tb1;
        }
        public DataTable OnCallGetSalary(DateTime date)
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnCallGetSalary(date).Tables["SalaryReport"];
            return tb;
        }
        public DataTable OnCallGetSavings(DateTime date)
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnCallGetSavings(date).Tables["SavingsReport"];
            return tb;
        }
        public DataTable OnCallGetTotalSavingsGetTotalSalaryAndGetOverAllCollection()
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnCallGetTotalSavingsGetTotalSalaryAndGetOverAllCollection();
            return tb;
        }                
    }
}
