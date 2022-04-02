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
        internal bool CheckRecord(string username, string password) // camelCase nako kay parameters ni sila then walay underscore
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {               
                con.Open();
                // kini kay constant mani siya so PascalCase gamiton instead nga camelCase
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
