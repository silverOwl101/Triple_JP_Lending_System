using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using TripleJP_Lending_System.Model;

namespace TripleJP_Lending_System.Service.Repository
{
    public class CustomerRepo
    {
        public void InsertData(Customer customer)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(SqlConnectionRepo.ConnectionString))
                {
                    const string query = "sp_insertCustomer";
                    MySqlCommand cmd = new MySqlCommand(query, con);

                    con.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    #region Parameters
                    cmd.Parameters.AddWithValue("@uid", customer.uid);
                    cmd.Parameters["@uid"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@id", customer.id);
                    cmd.Parameters["@id"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@name", customer.name);
                    cmd.Parameters["@name"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@address", customer.address);
                    cmd.Parameters["@address"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@contact_number", customer.contactNumber);
                    cmd.Parameters["@contact_number"].Direction = ParameterDirection.Input;
                    #endregion
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
