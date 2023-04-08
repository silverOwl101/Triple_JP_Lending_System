using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                return reportRepo.GetCustomerListReport();
            }
            catch (MySqlException ex)
            {
                throw new InvalidOperationException(" Task Invalid ", ex);
            }
        }
    }
}
