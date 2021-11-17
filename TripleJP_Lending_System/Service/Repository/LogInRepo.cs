using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TripleJP_Lending_System.Service.Repository
{
    class LogInRepo
    {
        internal string CheckRecord(string _UserName, string _PassWord)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.connectionString))
            {               
                con.Open();
                const string sqlQuery = "Select username,password from administrator where username = @UserName and password = @Password";
                var sqlCommand = new MySqlCommand(sqlQuery, con);
                sqlCommand.Parameters.AddWithValue("@UserName", _UserName);
                sqlCommand.Parameters.AddWithValue("@Password", _PassWord);
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
