using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TripleJP.Service.Repository
{
    public class LogInRepo
    {
        public string CheckRecord(string username, string password) // camelCase nako kay parameters ni sila then walay underscore
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
            {               
                con.Open();
                // kini kay constant mani siya so PascalCase gamiton instead nga camelCase
                const string SqlQuery = "Select username,password from administrator where username = @UserName and password = @Password";
                var sqlCommand = new MySqlCommand(SqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@UserName", username);
                sqlCommand.Parameters.AddWithValue("@Password", password);
                sqlCommand.ExecuteNonQuery();
                using (var reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read() == true)
                    {
                        return true.ToString();
                    }
                    else
                    {
                        return false.ToString();
                    }
                }                                    
            }                        
        }
    }
}
