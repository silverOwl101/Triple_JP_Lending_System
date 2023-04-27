using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPMVPLibrary.ReportDataSets;
using TripleJPUtilityLibrary.DataSource;

namespace TripleJPMVPLibrary.Repository
{
    internal class ReportRepo
    {        
        internal DataSet GetCollectionSummaryReport()
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string Query = "sp_getTotalCollectionPerLoanSummary";
                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                CrystalReportDataSet data = new CrystalReportDataSet();
                adapt.Fill(data, "CollectionSummaryReport");
                return data;
            }            
        }
        internal DataSet GetLoanInformationReport(Loan loan)
        {
            LoanInformationReport _loanInformation = null;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string Query = "sp_createLoanInformationReport";                

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loan_id", loan.Id);
                cmd.Parameters["@loan_id"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {                    
                    while (reader.Read())
                    {
                        _loanInformation = new LoanInformationReport()
                        {
                            CustomerID = reader["CustomerID"].ToString(),
                            NameOfOwner = reader["CustomerName"].ToString(),
                            PrincipalLoan = Convert.ToDecimal(reader["PrincipalLoan"]),
                            Interest = Convert.ToDecimal(reader["Interest"]),                            
                            Terms = reader["PaymentTerm"].ToString(),
                            TotalLoan = Convert.ToDecimal(reader["TotalLoan"]),
                            DailyPayment = Convert.ToDecimal(reader["DailyPayment"]),
                        };                        
                    }
                }
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                CrystalReportDataSet data = new CrystalReportDataSet();
                adapt.Fill(data, "LoanInformationReport");
                return data;
            }            
        }
        internal DataSet GetCollectionReport(Loan loan)
        {
            CollectionReport _collectionReport = null;
            CrystalReportDataSet data = new CrystalReportDataSet();
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string Query = "sp_getCollectionAndPenalty";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loanId", loan.Id);
                cmd.Parameters["@loanId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            _collectionReport = new CollectionReport()
                            {
                                CollectionID = reader["ID"].ToString(),
                                CollectionAmount = Convert.ToDecimal(reader["Collection"]),
                                DateCollected = Convert.ToDateTime(reader["Date"])
                            };
                        }                        
                    }
                }
                if (_collectionReport != null)
                {
                    MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                    adapt.Fill(data, "CollectionDetailReport");
                    return data;
                }                                
                return data;
            }
        }
    }
}
