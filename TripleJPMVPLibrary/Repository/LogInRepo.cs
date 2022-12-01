using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TripleJPUtilityLibrary.DataSource;

namespace TripleJPMVPLibrary.Repository
{
    internal class LogInRepo
    {
        internal bool CheckRecord(string username, string password)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {               
                con.Open();
                const string SqlQuery = "Select username, password from user_system_account where username = @Username and password = @Password";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@Username", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                sqlCommand.ExecuteNonQuery();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
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
