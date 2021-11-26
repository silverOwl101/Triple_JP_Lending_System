using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TripleJP.Model;

namespace TripleJP.Service.Repository
{
    public class CustomerRepo
    {
        public void InsertData(Customer customer,
                               CustomerBusinessInformation customerBusinessInfo)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
                {
                    const string customerInfoQuery = "sp_insertCustomer";
                    MySqlCommand cmd_1 = new MySqlCommand(customerInfoQuery, con);
                    //const string customerBusinessInfoQuery = "sp_insertCustomerBusinessInfo";
                    //MySqlCommand cmd_2 = new MySqlCommand(customerBusinessInfoQuery, con);

                    con.Open();
                    cmd_1.CommandType = System.Data.CommandType.StoredProcedure;
                    //cmd_2.CommandType = System.Data.CommandType.StoredProcedure;
                    #region Customer information parameters
                    cmd_1.Parameters.AddWithValue("@customerUid", customer.uid);
                    cmd_1.Parameters["@customerUid"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@customerId", customer.id);
                    cmd_1.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@customerName", customer.name);
                    cmd_1.Parameters["@customerName"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@address", customer.address);
                    cmd_1.Parameters["@address"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@contactNumber", customer.contactNumber);
                    cmd_1.Parameters["@contactNumber"].Direction = ParameterDirection.Input;
                    #endregion
                    #region Customer business information parameters
                    cmd_1.Parameters.AddWithValue("@businessUid", customerBusinessInfo.uid);
                    cmd_1.Parameters["@businessUid"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@businessId", customerBusinessInfo.id);
                    cmd_1.Parameters["@businessId"].Direction = ParameterDirection.Input;                    
                    cmd_1.Parameters.AddWithValue("@businessName", customerBusinessInfo.businessName);
                    cmd_1.Parameters["@businessName"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@businessNature", customerBusinessInfo.businessNature);
                    cmd_1.Parameters["@businessNature"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@businessAddress", customerBusinessInfo.businessAddress);
                    cmd_1.Parameters["@businessAddress"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@grossBusinessCapital", customerBusinessInfo.grossBusinessCapital);
                    cmd_1.Parameters["@grossBusinessCapital"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@averageDailyGrossSales", customerBusinessInfo.averageDailyGrossSales);
                    cmd_1.Parameters["@averageDailyGrossSales"].Direction = ParameterDirection.Input;
                    #endregion
                    cmd_1.ExecuteNonQuery();                    
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public bool IsDuplicateUid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
            {
                con.Open();                                
                const string SqlQuery = "select uid from customer_account where uid = @uId";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@uId", uid);                
                sqlCommand.ExecuteNonQuery();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read() == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }            
        }
        public bool IsDuplicateId(string id)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
            {
                con.Open();                
                const string SqlQuery = "select id from customer_account where id = @Id";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@Id", id);
                sqlCommand.ExecuteNonQuery();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read() == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool IsDuplicateName(string name)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
            {
                con.Open();                
                const string SqlQuery = "select name from customer_account where name = @Name";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@Name", name);
                sqlCommand.ExecuteNonQuery();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read() == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool IsDuplicateBusinessId(string id)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
            {
                con.Open();
                const string SqlQuery = "select id from customer_business_info where id = @id";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@id", id);
                sqlCommand.ExecuteNonQuery();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read() == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool IsDuplicateBusinessGuid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
            {
                con.Open();
                const string SqlQuery = "select uid from customer_business_info where uid = @uid";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@uid", uid);
                sqlCommand.ExecuteNonQuery();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read() == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
