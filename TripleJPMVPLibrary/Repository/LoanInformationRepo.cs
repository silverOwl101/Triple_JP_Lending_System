using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.DataSource;
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
                    cmd.Parameters.AddWithValue("@customerId", customer.Id);
                    cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@customerName", customer.Name);
                    cmd.Parameters["@customerName"].Direction = ParameterDirection.Input;
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getLoanInformation = new GetCustomerLoanInformation
                            {
                                Id = reader["LoanID"].ToString(),
                                CustomerID = reader["CustomerID"].ToString(),
                                Name = reader["CustomerName"].ToString(),
                                PaymentTerm = reader["PaymentTerm"].ToString(),
                                Duration = Convert.ToInt32(reader["Duration"].ToString()),
                                EffectiveDate = Convert.ToDateTime(reader["EffectiveDate"]).ToString("MM-dd-yyyy"),
                                Interest = Convert.ToDecimal(reader["Interest"].ToString()),
                                PrincipalLoan = Convert.ToDecimal(reader["PrincipalLoan"].ToString()),
                                Penalty = Convert.ToDecimal(reader["Penalty"].ToString()),
                                Status = reader["Status"].ToString(),
                                Returned = reader["Returned"].ToString()
                            };                         

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
                    cmd.Parameters.AddWithValue("@loaninformationUid", loan.Uid);
                    cmd.Parameters["@loaninformationUid"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@loaninformationId", loan.Id);
                    cmd.Parameters["@loaninformationId"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@customerUid", loan.CustomerUid);
                    cmd.Parameters["@customerUid"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@PaymentTerm", loan.PaymentTerm);
                    cmd.Parameters["@PaymentTerm"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@Duration", loan.Duration);
                    cmd.Parameters["@Duration"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@EffectiveDate", loan.EffectiveDate);
                    cmd.Parameters["@EffectiveDate"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@Interest", loan.Interest);
                    cmd.Parameters["@Interest"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@PrincipalLoan", loan.PrincipalLoan);
                    cmd.Parameters["@PrincipalLoan"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@Penalty", loan.Penalty);
                    cmd.Parameters["@Penalty"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@loanstatus", loan.LoanStatus);
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
