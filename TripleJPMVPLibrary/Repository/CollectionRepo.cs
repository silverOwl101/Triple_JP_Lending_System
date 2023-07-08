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
    internal class CollectionRepo
    {        
        internal void InsertCollection(Collection collection, Customer customer, Loan loan)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string storedProcedure = "sp_insertCollection";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(storedProcedure, con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                #region Parameters
                
                cmd.Parameters.AddWithValue("@collectionUid", collection.Uid);
                cmd.Parameters["@collectionUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@collectionId", collection.Id);
                cmd.Parameters["@collectionId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@customerUid", customer.Uid);
                cmd.Parameters["@customerUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@loanInformationUid", loan.Uid);
                cmd.Parameters["@loanInformationUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@collectionAmount", collection.Amount);
                cmd.Parameters["@collectionAmount"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@collectionDate", collection.Date);
                cmd.Parameters["@collectionDate"].Direction = ParameterDirection.Input;

                #endregion

                cmd.ExecuteNonQuery();
            }
        }
        internal void InsertPenalty (Penalty penalty, Customer customer, Loan loan)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string storedProcedure = "sp_insertPenalty";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(storedProcedure, con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                #region Parameters

                cmd.Parameters.AddWithValue("@penalty_Uid", penalty.Uid);
                cmd.Parameters["@penalty_Uid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@penalty_Id", penalty.Id);
                cmd.Parameters["@penalty_Id"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@customer_Uid", customer.Uid);
                cmd.Parameters["@customer_Uid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@loanInformation_Uid", loan.Uid);
                cmd.Parameters["@loanInformation_Uid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@penalty_Amnt", penalty.Amount);
                cmd.Parameters["@penalty_Amnt"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@penalty_Date", penalty.Date);
                cmd.Parameters["@penalty_Date"].Direction = ParameterDirection.Input;

                #endregion

                cmd.ExecuteNonQuery();
            }
        }
        internal void LoanFullyPaidUpdate(Loan loan)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_updateLoanStatus";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loanId", loan.Id);
                cmd.Parameters["@loanId"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();
            }
        }
        internal bool IsDuplicateUid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                con.Open();
                const string SqlQuery = "select Uid from collection where Uid = @uId";
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
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                con.Open();
                const string SqlQuery = "select Id from collection where Id = @Id";
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
        internal decimal GetTotalCollection(Loan loan)
        {
            decimal total = 0;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getTotalCollection";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loanUID", loan.Uid);
                cmd.Parameters["@loanUID"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToDecimal(reader["Total Collection"].ToString());
                    }
                }
            }
            return total;
        }
        internal decimal GetTotalPenalty(Loan loan)
        {
            decimal total = 0;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getPenaltyTotal";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@loanUID", loan.Uid);
                cmd.Parameters["@loanUID"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            total = Convert.ToDecimal(reader["Total Penalty"].ToString());
                        }                        
                    }
                }
            }
            return total;
        }
        internal decimal GetDailyTotalCollectionByDate(DateTime date)
        {
            decimal total = 0;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getDailyTotalCollection";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@dailyTotalCollection", date);
                cmd.Parameters["@dailyTotalCollection"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToDecimal(reader["Daily Total Collection"].ToString());
                    }
                }
            }
            return total;
        }
        internal bool CheckDateValidity(DateTime date)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getCollectionDate";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@collectionDate", date);
                cmd.Parameters["@collectionDate"].Direction = ParameterDirection.Input;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count <= 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
}
    