using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJPUtilityLibrary.ConfigFolder;

namespace TripleJPUtilityLibrary.DataSource
{
    public static class SqlConnection
    {
        
        private static string CONFIG_PATH = Path.Combine(Environment.CurrentDirectory, "..", "..", "..", "TripleJPUtilityLibrary", "ConfigFolder", "config.json");

        private static string rawAppConfig = File.ReadAllText(CONFIG_PATH);

        private static AppConfig appConfig = JsonConvert.DeserializeObject<AppConfig>(rawAppConfig);

        public static string DATABASE_CONNECTION_STRING = appConfig.DATABASE_CONNECTION_STRING;
       
    }
}
