using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
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
                cmd.Parameters.AddWithValue("@customerId", customer.Id);
                cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;                
                cmd.ExecuteNonQuery();
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        getCustomerList = new GetPostingInfo
                        {
                            Due = Convert.ToDateTime(reader["Due"].ToString()),
                            LoanId = reader["Loan No"].ToString(),
                            CustomerName = reader["Name"].ToString(),
                            PostingReturn = Convert.ToInt32(reader["Return"]),
                            Interest = Convert.ToInt32(reader["Interest"]),
                            TotalAmount = Convert.ToInt32(reader["Total Amount"])
                        };
                        customerList.Add(getCustomerList);
                    }
                }
            }
            return customerList;
        }
    }
}
