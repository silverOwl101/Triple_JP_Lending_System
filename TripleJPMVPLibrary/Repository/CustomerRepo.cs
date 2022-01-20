using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.DataSource;

namespace TripleJPMVPLibrary.Repository
{
    internal class CustomerRepo
    {
        internal void InsertData(Customer customer,
                               CustomerBusinessInformation customerBusinessInfo)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
                {
                    const string customerInfoQuery = "sp_insertCustomer";
                    MySqlCommand cmd_1 = new MySqlCommand(customerInfoQuery, con);

                    con.Open();
                    cmd_1.CommandType = System.Data.CommandType.StoredProcedure;
                    #region Customer information parameters
                    cmd_1.Parameters.AddWithValue("@customerUid", customer.Uid);
                    cmd_1.Parameters["@customerUid"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@customerId", customer.Id);
                    cmd_1.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@customerName", customer.Name);
                    cmd_1.Parameters["@customerName"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@Address", customer.Address);
                    cmd_1.Parameters["@Address"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                    cmd_1.Parameters["@ContactNumber"].Direction = ParameterDirection.Input;
                    #endregion
                    #region Customer business information parameters
                    cmd_1.Parameters.AddWithValue("@businessUid", customerBusinessInfo.Uid);
                    cmd_1.Parameters["@businessUid"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@businessId", customerBusinessInfo.Id);
                    cmd_1.Parameters["@businessId"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@BusinessName", customerBusinessInfo.BusinessName);
                    cmd_1.Parameters["@BusinessName"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@BusinessNature", customerBusinessInfo.BusinessNature);
                    cmd_1.Parameters["@BusinessNature"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@BusinessAddress", customerBusinessInfo.BusinessAddress);
                    cmd_1.Parameters["@BusinessAddress"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@GrossBusinessCapital", customerBusinessInfo.GrossBusinessCapital);
                    cmd_1.Parameters["@GrossBusinessCapital"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@AverageDailyGrossSales", customerBusinessInfo.AverageDailyGrossSales);
                    cmd_1.Parameters["@AverageDailyGrossSales"].Direction = ParameterDirection.Input;
                    #endregion
                    cmd_1.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        internal bool IsDuplicateUid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                con.Open();
                const string SqlQuery = "select Uid from customer_account where Uid = @uId";
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
        internal bool IsDuplicateId(string id)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                con.Open();
                const string SqlQuery = "select Id from customer_account where Id = @Id";
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
        internal bool IsDuplicateName(string name)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                con.Open();
                const string SqlQuery = "select Name from customer_account where Name = @Name";
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
        internal bool IsDuplicateBusinessId(string id)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                con.Open();
                const string SqlQuery = "select Id from customer_business_info where Id = @Id";
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
        internal bool IsDuplicateBusinessGuid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                con.Open();
                const string SqlQuery = "select Uid from customer_business_info where Uid = @Uid";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@Uid", uid);
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
        internal List<GetCustomerInfo> GetList(Customer customer)
        {
            GetCustomerInfo getCustomerList;
            List<GetCustomerInfo> customerList = new List<GetCustomerInfo>();
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(SqlConnection.ConnectionString))
                {
                    const string Query = "sp_getCustomerList";
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
                            getCustomerList = new GetCustomerInfo();
                            getCustomerList.Id = reader["Id"].ToString();
                            getCustomerList.Name = reader["Name"].ToString();
                            getCustomerList.Address = 
                                reader["Address"].ToString();
                            getCustomerList.ContactNumber = 
                                reader["contactnumber"].ToString();
                            getCustomerList.BusinessName = 
                                reader["BusinessName"].ToString();
                            getCustomerList.BusinessNature = 
                                reader["BusinessNature"].ToString();
                            getCustomerList.BusinessAddress = 
                                reader["BusinessAddress"].ToString();
                            getCustomerList.GrossBusinessCapital = 
                                Convert.ToDecimal(reader["GrossBusinessCapital"]);
                            getCustomerList.AverageDailyGrossSales = 
                                Convert.ToDecimal(reader["AverageDailyGrossSales"]);
                            customerList.Add(getCustomerList);
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return customerList;
        }
        internal GetCustomerInfo GetCustomer(Customer customer)
        {
            GetCustomerInfo getCustomer = null;            
            try
            {
                using (MySqlConnection con = 
                    new MySqlConnection(SqlConnection.ConnectionString))
                {
                    const string Query = "sp_getCustomer";
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@customerId", customer.Id);
                    cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;                    
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getCustomer = new GetCustomerInfo();
                            getCustomer.Id = reader["Id"].ToString();
                            getCustomer.Name = reader["Name"].ToString();
                            getCustomer.Address =
                                reader["Address"].ToString();
                            getCustomer.ContactNumber =
                                reader["contactnumber"].ToString();
                            getCustomer.BusinessName =
                                reader["BusinessName"].ToString();
                            getCustomer.BusinessNature =
                                reader["BusinessNature"].ToString();
                            getCustomer.BusinessAddress =
                                reader["BusinessAddress"].ToString();
                            getCustomer.GrossBusinessCapital =
                                Convert.ToDecimal(reader["GrossBusinessCapital"]);
                            getCustomer.AverageDailyGrossSales =
                                Convert.ToDecimal(reader["AverageDailyGrossSales"]);                            
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return getCustomer;
        }
        internal void UpdateData(Customer customer,
                              CustomerBusinessInformation customerBusinessInfo)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
                {
                    const string customerInfoQuery = "sp_updateCustomer";
                    MySqlCommand cmd_1 = new MySqlCommand(customerInfoQuery, con);

                    con.Open();
                    cmd_1.CommandType = System.Data.CommandType.StoredProcedure;
                    #region Customer information parameters                    
                    cmd_1.Parameters.AddWithValue("@customerId", customer.Id);
                    cmd_1.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@customerName", customer.Name);
                    cmd_1.Parameters["@customerName"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@Address", customer.Address);
                    cmd_1.Parameters["@Address"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                    cmd_1.Parameters["@ContactNumber"].Direction = ParameterDirection.Input;
                    #endregion
                    #region Customer business information parameters                                        
                    cmd_1.Parameters.AddWithValue("@BusinessName", customerBusinessInfo.BusinessName);
                    cmd_1.Parameters["@BusinessName"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@BusinessNature", customerBusinessInfo.BusinessNature);
                    cmd_1.Parameters["@BusinessNature"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@BusinessAddress", customerBusinessInfo.BusinessAddress);
                    cmd_1.Parameters["@BusinessAddress"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@GrossBusinessCapital", customerBusinessInfo.GrossBusinessCapital);
                    cmd_1.Parameters["@GrossBusinessCapital"].Direction = ParameterDirection.Input;
                    cmd_1.Parameters.AddWithValue("@AverageDailyGrossSales", customerBusinessInfo.AverageDailyGrossSales);
                    cmd_1.Parameters["@AverageDailyGrossSales"].Direction = ParameterDirection.Input;
                    #endregion
                    cmd_1.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        internal string GetGuid(Customer customer)
        {
            string guid = null;
            try
            {
                using (MySqlConnection con =
                    new MySqlConnection(SqlConnection.ConnectionString))
                {
                    const string Query = "sp_getCustomerGuid";
                    MySqlCommand cmd = new MySqlCommand(Query, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@customerId", customer.Id);
                    cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guid = reader["Uid"].ToString();                            
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return guid;
        }
    }
}
