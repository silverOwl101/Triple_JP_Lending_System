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
        internal void InsertData(Customer customer, CustomerBusinessInformation customerBusinessInformation)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string storedProcedure = "sp_insertCustomer";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(storedProcedure, con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                #region Parameters

                #region Customer Information

                cmd.Parameters.AddWithValue("@customerUid", customer.Uid);
                cmd.Parameters["@customerUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@customerId", customer.Id);
                cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@customerName", customer.Name);
                cmd.Parameters["@customerName"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                cmd.Parameters["@ContactNumber"].Direction = ParameterDirection.Input;

                #endregion

                #region Customer Business Information

                cmd.Parameters.AddWithValue("@businessUid", customerBusinessInformation.Uid);
                cmd.Parameters["@businessUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@businessId", customerBusinessInformation.Id);
                cmd.Parameters["@businessId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@BusinessName", customerBusinessInformation.BusinessName);
                cmd.Parameters["@BusinessName"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@BusinessNature", customerBusinessInformation.BusinessNature);
                cmd.Parameters["@BusinessNature"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@BusinessAddress", customerBusinessInformation.BusinessAddress);
                cmd.Parameters["@BusinessAddress"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@GrossBusinessCapital", customerBusinessInformation.GrossBusinessCapital);
                cmd.Parameters["@GrossBusinessCapital"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@AverageDailyGrossSales", customerBusinessInformation.AverageDailyGrossSales);
                cmd.Parameters["@AverageDailyGrossSales"].Direction = ParameterDirection.Input;

                #endregion

                #endregion

                cmd.ExecuteNonQuery();
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

            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string Query = "sp_getCustomerList";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

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
                        getCustomerList = new GetCustomerInfo
                        {
                            Id = reader["Id"].ToString(),
                            Name = reader["Name"].ToString(),
                            Address =
                            reader["Address"].ToString(),
                            ContactNumber =
                            reader["contactnumber"].ToString(),
                            BusinessName =
                            reader["BusinessName"].ToString(),
                            BusinessNature =
                            reader["BusinessNature"].ToString(),
                            BusinessAddress =
                            reader["BusinessAddress"].ToString(),
                            GrossBusinessCapital =
                            Convert.ToDecimal(reader["GrossBusinessCapital"]),
                            AverageDailyGrossSales =
                            Convert.ToDecimal(reader["AverageDailyGrossSales"])
                        };

                        customerList.Add(getCustomerList);
                    }
                }
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

        internal void UpdateData(Customer customer, CustomerBusinessInformation customerBusinessInfo)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string storedProcedure = "sp_updateCustomer";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(storedProcedure, con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                #region Parameters

                #region Customer Information
                
                cmd.Parameters.AddWithValue("@customerId", customer.Id);
                cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@customerName", customer.Name);
                cmd.Parameters["@customerName"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters["@Address"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@ContactNumber", customer.ContactNumber);
                cmd.Parameters["@ContactNumber"].Direction = ParameterDirection.Input;

                #endregion

                #region Customer Business Information 
                
                cmd.Parameters.AddWithValue("@BusinessName", customerBusinessInfo.BusinessName);
                cmd.Parameters["@BusinessName"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@BusinessNature", customerBusinessInfo.BusinessNature);
                cmd.Parameters["@BusinessNature"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@BusinessAddress", customerBusinessInfo.BusinessAddress);
                cmd.Parameters["@BusinessAddress"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@GrossBusinessCapital", customerBusinessInfo.GrossBusinessCapital);
                cmd.Parameters["@GrossBusinessCapital"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@AverageDailyGrossSales", customerBusinessInfo.AverageDailyGrossSales);
                cmd.Parameters["@AverageDailyGrossSales"].Direction = ParameterDirection.Input;

                #endregion

                #endregion

                cmd.ExecuteNonQuery();
            }
        }

        internal string GetGuid(Customer customer)
        {
            string guid = null;

            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string Query = "sp_getCustomerGuid";

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
                        guid = reader["Uid"].ToString();
                    }
                }
            }

            return guid;

        }
    }
}
