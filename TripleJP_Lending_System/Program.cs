using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.Forms;
using TripleJPUtilityLibrary.ConfigFolder;
using Newtonsoft.Json;

namespace TripleJP_Lending_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if(!File.Exists(ApplicationConstants.APP_DATA_SYSTEM_FOLDER))
            {

                try
                {
                    Directory.CreateDirectory(ApplicationConstants.APP_DATA_SYSTEM_FOLDER);
                } 
                catch (Exception ex)
                {
                    string MessageContent = ex.Source;
                    const string MessageCaption = "Cannot Create App Data Directory";
                    MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if(!File.Exists(ApplicationConstants.CONFIG_PATH))
                {

                    // config.json default contents
                    var formatConfig = new
                    {
                        DATABASE_CONNECTION_STRING = "Server=localhost;Database=tjpdb;Uid=root;Pwd=12345;"
                    };

                    // format json
                    string jsonFormat = JsonConvert.SerializeObject(formatConfig, Formatting.Indented);

                    // create the config file
                    try
                    {

                        File.WriteAllText(ApplicationConstants.CONFIG_PATH, jsonFormat);

                    }
                    catch (Exception ex)
                    {
                        string MessageContent = ex.Source;
                        const string MessageCaption = "Cannot Create App Config File";
                        MessageBox.Show(MessageContent, MessageCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }

            //Application.Run(new ReportViewerFrm());
            Application.Run(new LogInFrm());
        }
    }
}
