using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.ReportDataSets;
using TripleJPMVPLibrary.Repository;

namespace TripleJPMVPLibrary.Service
{
    internal class ReportService
    {
        private ReportRepo reportRepo;
        private SalaryRepo salaryRepo;
        private SavingsRepo savingsRepo;        
        internal DataSet OnSetGetCustomerListReport()
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetCollectionSummaryReportUnpaid();
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }
        internal DataSet OnSetGetCollectionSummaryReportPaid()
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetCollectionSummaryReportPaid();
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }        
        internal DataSet OnSetGetLoanInformationReport(Loan loan)
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetLoanInformationReport(loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }
        internal DataSet OnSetGetCollectionReport(Loan loan)
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetCollectionReport(loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
                        
        }
        internal DataSet OnSetGetPenaltyReport(Loan loan)
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetPenaltyReport(loan);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }

        }
        internal DataSet OnSetGetDailyCollection(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetDailyCollection(dateFrom,dateTo);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }

        }
        internal DataSet OnSetGetSalary(DateTime date)
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetSalary(date);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }

        }
        internal DataSet OnSetGetSavings(DateTime date)
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetSavings(date);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }

        }
        internal DataSet OnSetGetSavingsSalaryExpensesSummary(DateTime dateFrom, DateTime dateTo)
        {            
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetSavingsSalaryExpensesSummary(dateFrom, dateTo);
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }
        internal DataTable OnSetGetTotalSavingsGetTotalSalaryAndGetOverAllCollection()
        {
            CrystalReportDataSet data = new CrystalReportDataSet();
            salaryRepo = new SalaryRepo();
            savingsRepo = new SavingsRepo();
            reportRepo = new ReportRepo();
            DataTable tb1 = new DataTable();

            tb1 = data.Tables["SalarySavingsAndOverAllCollectionTotalAmount"];
            try
            {                
                decimal totalSalary = salaryRepo.GetTotalSalary();
                decimal totalSavings = savingsRepo.GetTotalSavings();
                decimal overAllCollection = reportRepo.GetOverAllCollection();

                DataRow dataRow = tb1.NewRow();
                dataRow["salary_total"] = totalSalary;
                dataRow["savings_total"] = totalSavings;
                dataRow["OverAllCollection"] = overAllCollection;
                tb1.Rows.Add(dataRow);

                return tb1;
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }        
    }    
}
