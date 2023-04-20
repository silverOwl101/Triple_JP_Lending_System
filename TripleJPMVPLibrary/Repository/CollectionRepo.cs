﻿using MySql.Data.MySqlClient;
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
    internal class CollectionRepo
    {
        internal void InsertCollection(Collection collection, Customer customer, Loan loan)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
        internal void LoanFullyPaidUpdate(Loan loan)
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
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
    }
}
    