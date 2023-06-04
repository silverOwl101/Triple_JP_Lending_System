using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.DataSource;

namespace TripleJPMVPLibrary.Repository
{
    class PostingRepo
    {        
        internal List<GetPostingInfo> GetPostingList(Customer customer)
        {
            GetPostingInfo getCustomerList;
            List<GetPostingInfo> customerList = new List<GetPostingInfo>();

            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string Query = "sp_getPostingList";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@customerIdOrName", customer.Id);
                cmd.Parameters["@customerIdOrName"].Direction = ParameterDirection.Input;                
                cmd.ExecuteNonQuery();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.IsDBNull(reader.GetOrdinal("Due")))
                        {
                            return customerList;
                        }
                        else
                        {
                            getCustomerList = new GetPostingInfo
                            {
                                Due = Convert.ToDateTime(reader["Due"]),
                                LoanId = reader["Loan No"].ToString(),
                                CustomerName = reader["Name"].ToString(),
                                PostingReturn = Convert.ToDecimal(reader["Return"]),
                                Interest = Convert.ToDecimal(reader["Interest"]),
                                TotalAmount = Convert.ToDecimal(reader["Total Loan Amount"]),
                                Status = reader["Status"].ToString(),
                                Collect = Convert.ToDecimal(reader["Total Amount Collected"]),
                                Penalty = Convert.ToDecimal(reader["Total Penalty"])
                            };
                        }                        
                        customerList.Add(getCustomerList);
                    }                  
                }
            }
            return customerList;
        }        
    }
}
