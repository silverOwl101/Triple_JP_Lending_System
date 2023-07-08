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
    internal class SalaryRepo
    {
        internal void InsertSalary(Salary salary)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string storedProcedure = "sp_insertSalary";
                con.Open();

                MySqlCommand cmd = new MySqlCommand(storedProcedure, con)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                #region Parameters

                cmd.Parameters.AddWithValue("@salaryUid", salary.Uid);
                cmd.Parameters["@salaryUid"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@salaryId", salary.Id);
                cmd.Parameters["@salaryId"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@salaryAmount", salary.SalaryAmount);
                cmd.Parameters["@salaryAmount"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@collection_date_salary", salary.CollectionDate);
                cmd.Parameters["@collection_date_salary"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@date_remitted_salary", salary.DateRemmited);
                cmd.Parameters["@date_remitted_salary"].Direction = ParameterDirection.Input;

                #endregion

                cmd.ExecuteNonQuery();
            }
        }
        internal bool IsDuplicateUid(Guid uid)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                con.Open();
                const string SqlQuery = "select uid from savings where uid = @uId";
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
                const string SqlQuery = "select id from savings where id = @Id";
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
        internal decimal GetTotalSalary(DateTime date)
        {
            decimal total = 0;
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_TotalSalary";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();
                cmd.Parameters.AddWithValue("@salaryRemittedDate", date);
                cmd.Parameters["@salaryRemittedDate"].Direction = ParameterDirection.Input;
                cmd.ExecuteNonQuery();

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        total = Convert.ToDecimal(reader["Total Salary Remitted"].ToString());
                    }
                }
            }
            return total;
        }
    }
}
