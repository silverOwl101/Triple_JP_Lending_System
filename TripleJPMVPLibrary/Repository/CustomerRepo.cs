﻿using System;
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
        internal bool IsDuplicateUid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
        internal bool IsDuplicateId(string id)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
        internal bool IsDuplicateName(string name)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
        internal bool IsDuplicateBusinessId(string id)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
        internal bool IsDuplicateBusinessGuid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
                    cmd.Parameters.AddWithValue("@customerId", customer.id);
                    cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@customerName", customer.name);
                    cmd.Parameters["@customerName"].Direction = ParameterDirection.Input;
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getCustomerList = new GetCustomerInfo();
                            getCustomerList.id = reader["id"].ToString();
                            getCustomerList.name = reader["name"].ToString();
                            getCustomerList.address = 
                                reader["address"].ToString();
                            getCustomerList.contactNumber = 
                                reader["contactnumber"].ToString();
                            getCustomerList.businessName = 
                                reader["BusinessName"].ToString();
                            getCustomerList.businessNature = 
                                reader["BusinessNature"].ToString();
                            getCustomerList.businessAddress = 
                                reader["BusinessAddress"].ToString();
                            getCustomerList.grossBusinessCapital = 
                                Convert.ToDecimal(reader["grossBusinessCapital"]);
                            getCustomerList.averageDailyGrossSales = 
                                Convert.ToDecimal(reader["averageDailyGrossSales"]);
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
                    cmd.Parameters.AddWithValue("@customerId", customer.id);
                    cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;                    
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            getCustomer = new GetCustomerInfo();
                            getCustomer.id = reader["id"].ToString();
                            getCustomer.name = reader["name"].ToString();
                            getCustomer.address =
                                reader["address"].ToString();
                            getCustomer.contactNumber =
                                reader["contactnumber"].ToString();
                            getCustomer.businessName =
                                reader["BusinessName"].ToString();
                            getCustomer.businessNature =
                                reader["BusinessNature"].ToString();
                            getCustomer.businessAddress =
                                reader["BusinessAddress"].ToString();
                            getCustomer.grossBusinessCapital =
                                Convert.ToDecimal(reader["grossBusinessCapital"]);
                            getCustomer.averageDailyGrossSales =
                                Convert.ToDecimal(reader["averageDailyGrossSales"]);                            
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
                    cmd.Parameters.AddWithValue("@customerId", customer.id);
                    cmd.Parameters["@customerId"].Direction = ParameterDirection.Input;
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            guid = reader["uid"].ToString();                            
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
