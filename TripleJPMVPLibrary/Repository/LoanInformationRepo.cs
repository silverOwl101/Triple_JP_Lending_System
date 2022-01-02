using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPLibraryCore;
using MySql.Data.MySqlClient;


namespace TripleJPMVPLibrary.Repository
{
    class LoanInformationRepo
    {
        public List<GetCustomerLoanInformation> GetLoanInformation(Customer customer)
        {
            GetCustomerLoanInformation getLoanInformation = null;
            List<GetCustomerLoanInformation> loanList = new List<GetCustomerLoanInformation>();
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(SqlConnection.ConnectionString))
                {
                    const string Query = "sp_getLoanInformation";
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@customerId", customer.id);
                    cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@customerName", customer.name);
                    cmd.Parameters["@customerName"].Direction = ParameterDirection.Input;
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getLoanInformation = new GetCustomerLoanInformation();                            
                            getLoanInformation.id = reader["LoanID"].ToString();
                            getLoanInformation.customerID = reader["CustomerID"].ToString();
                            getLoanInformation.name = reader["CustomerName"].ToString();
                            getLoanInformation.paymentTerm = reader["PaymentTerm"].ToString();
                            getLoanInformation.duration = 
                                Convert.ToInt32(reader["Duration"].ToString());
                            getLoanInformation.effectiveDate = Convert.ToDateTime(reader["EffectiveDate"]).ToString("MM-dd-yyyy");
                            getLoanInformation.interest = 
                                Convert.ToDecimal(reader["Interest"].ToString());
                            getLoanInformation.principalLoan =
                                Convert.ToDecimal(reader["PrincipalLoan"].ToString());
                            getLoanInformation.penalty = 
                                Convert.ToDecimal(reader["Penalty"].ToString());
                            getLoanInformation.status = reader["Status"].ToString();
                            loanList.Add(getLoanInformation);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return loanList;
        }

        public void InsertData(Loan loan)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
                {
                    const string customerInfoQuery = "sp_insertLoan";
                    MySqlCommand cmd = new MySqlCommand(customerInfoQuery, con);

                    con.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    #region Customer information parameters
                    cmd.Parameters.AddWithValue("@loaninformationUid", loan.uid);
                    cmd.Parameters["@loaninformationUid"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@loaninformationId", loan.id);
                    cmd.Parameters["@loaninformationId"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@customerUid", loan.customeUid);
                    cmd.Parameters["@customerUid"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@paymentTerm", loan.paymentTerm);
                    cmd.Parameters["@paymentTerm"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@duration", loan.duration);
                    cmd.Parameters["@duration"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@effectiveDate", loan.effectiveDate);
                    cmd.Parameters["@effectiveDate"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@interest", loan.interest);
                    cmd.Parameters["@interest"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@principalLoan", loan.principalLoan);
                    cmd.Parameters["@principalLoan"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@penalty", loan.penalty);
                    cmd.Parameters["@penalty"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@loanstatus", loan.loanStatus);
                    cmd.Parameters["@loanstatus"].Direction = ParameterDirection.Input;

                    #endregion
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
