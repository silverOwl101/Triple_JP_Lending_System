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
        public DataTable OnLoadCustomerReportList()
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnSetGetCustomerListReport().Tables["CollectionSummaryReport"];
            return tb;
        }
        public DataTable OnLoadGetCollectionSummaryReportPaid()
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnSetGetCollectionSummaryReportPaid().Tables["CollectionSummaryReport_Paid"];
            return tb;
        }        
        public DataTable OnLoadGetLoanInformationReport(Loan loan)
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnSetGetLoanInformationReport(loan).Tables["LoanInformationReport"];
            return tb;
        }
        public DataTable OnLoadGetCollectionReport(Loan loan)
        {
            reportService = new ReportService();
            DataTable tb1 = new DataTable();
            DataTable tb2 = new DataTable();
            tb1 = reportService.OnSetGetCollectionReport(loan).Tables["CollectionDetailReport"];
            tb2 = reportService.OnSetGetPenaltyReport(loan).Tables["PenaltyDetailReport"];

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
        public DataTable OnLoadGetDailyCollection()
        {            
            reportService = new ReportService();
            //CrystalReportDataSet dataset = new CrystalReportDataSet();

            DataTable tb1 = reportService.OnSetGetDailyCollection(_addDate.DateFrom,_addDate.DateTo).Tables["DailyCollectionReport"];
           
            return tb1;
        }
        public DataTable OnLoadGetSavingsSalaryExpensesSummary()
        {
            reportService = new ReportService();            

            DataTable tb1 = reportService.OnSetGetSavingsSalaryExpensesSummary
                            (_addDate.DateFrom, _addDate.DateTo).
                            Tables["SavingsSalaryExpensesSummaryReport"];
            return tb1;
        }
        public DataTable OnLoadGetSalary(DateTime date)
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnSetGetSalary(date).Tables["SalaryReport"];
            return tb;
        }
        public DataTable OnLoadGetSavings(DateTime date)
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnSetGetSavings(date).Tables["SavingsReport"];
            return tb;
        }
        public DataTable OnLoadGetTotalSavingsGetTotalSalaryAndGetOverAllCollection()
        {
            reportService = new ReportService();
            DataTable tb = reportService.OnSetGetTotalSavingsGetTotalSalaryAndGetOverAllCollection();
            return tb;
        }                
    }
}
