using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.Model;
using MySql.Data.MySqlClient;
using TripleJPUtilityLibrary.DataSource;

namespace TripleJPMVPLibrary.Repository
{
    internal class SavingsRepo
    {
        internal void InsertSavings(Savings savings)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string storedProcedure = "sp_insertSavings";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(storedProcedure, con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                #region Parameters

                cmd.Parameters.AddWithValue("@savingsUid", savings.Uid);
                cmd.Parameters["@savingsUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@savingsId", savings.Id);
                cmd.Parameters["@savingsId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@savingsAmount", savings.SavingsAmount);
                cmd.Parameters["@savingsAmount"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@collection_date_savings", savings.CollectionDate);
                cmd.Parameters["@collection_date_savings"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@date_remitted_savings", savings.DateRemmited);
                cmd.Parameters["@date_remitted_savings"].Direction = ParameterDirection.Input;
                
                #endregion

                cmd.ExecuteNonQuery();
            }
        }
        internal bool IsDuplicateUid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                con.Open();
                const string SqlQuery = "select Uid from savings where Uid = @uId";
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
                const string SqlQuery = "select Id from savings where Id = @Id";
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
        internal decimal GetTotalSavingsInDate(DateTime date)
        {
            decimal total = 0;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_GetTotalSavingsWithDate";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@savingsRemittedDate", date);
                cmd.Parameters["@savingsRemittedDate"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToDecimal(reader["Total Savings Remitted"].ToString());
                    }
                }
            }
            return total;
        }
        internal decimal GetTotalSavings()
        {
            decimal total = 0;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_getTotalSavings";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();                
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToDecimal(reader["TotalSavingsAmount"].ToString());
                    }
                }
            }
            return total;
        }
    }
}
