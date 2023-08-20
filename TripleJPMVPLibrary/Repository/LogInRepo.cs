using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TripleJPMVPLibrary.Model;
using TripleJPUtilityLibrary.DataSource;

namespace TripleJPMVPLibrary.Repository
{
    internal class LogInRepo
    {        
        internal bool CheckRecord(string username, string password)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.DATABASE_CONNECTION_STRING))
            {
                const string Query = "sp_isRegistered";

                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                con.Open();                
                cmd.Parameters.AddWithValue("@userAccount", username);
                cmd.Parameters["@userAccount"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@userEntryCode", password);
                cmd.Parameters["@userEntryCode"].Direction = ParameterDirection.Input;
                
                if (cmd.ExecuteScalar() != null)
                    return true;
                else
                    return false;
            }
        }
    }
}
