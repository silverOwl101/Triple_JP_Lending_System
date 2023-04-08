using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TripleJPMVPLibrary.ReportDataSets;
using TripleJPUtilityLibrary.DataSource;

namespace TripleJPMVPLibrary.Repository
{
    internal class ReportRepo
    {
        internal DataSet GetCustomerListReport()
        {
            using (MySqlConnection con = new MySqlConnection(SqlConnection.ConnectionString))
            {
                const string Query = "sp_getTotalCollectionPerLoanSummary";
                MySqlCommand cmd = new MySqlCommand(Query, con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                con.Open();
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapt = new MySqlDataAdapter(cmd);
                CollectionSummary data = new CollectionSummary();
                adapt.Fill(data, "CollectionSummaryReport");
                return data;
            }            
        }
    }
}
