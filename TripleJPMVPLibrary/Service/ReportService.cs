using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.Repository;

namespace TripleJPMVPLibrary.Service
{
    internal class ReportService
    {
        private ReportRepo reportRepo;
        internal DataSet OnCallGetCustomerListReport()
        {
            try
            {
                reportRepo = new ReportRepo();
                return reportRepo.GetCollectionSummaryReport();
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }
        internal DataSet OnCallGetLoanInformationReport(Loan loan)
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
        internal DataSet OnCallGetCollectionReport(Loan loan)
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
        internal DataSet OnCallGetPenaltyReport(Loan loan)
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
        internal DataSet OnCallGetDailyCollection(DateTime dateFrom, DateTime dateTo)
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
        internal DataSet OnCallGetSalary(DateTime date)
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
        internal DataSet OnCallGetSavings(DateTime date)
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
    }    
}
