using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TripleJP_Lending_System.Forms;
using TripleJPUtilityLibrary.ConfigFolder;
using Newtonsoft.Json;
using System.Threading;
using System.Diagnostics;


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
            const string mutexName = "TripleJP_Application_Mutex";
            bool createdNew;
            Mutex mutex = new Mutex(true, mutexName, out createdNew);

            if (createdNew)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                CreateDatabaseConnection();
                Application.Run(new LogInFrm());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("The application is already running..", "TripleJP Lending System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BringRunningInstanceToFront(mutexName);
            }
        }
        private static void BringRunningInstanceToFront(string mutexName)
        {
            // Find the running process by the mutex name
            Process currentProcess = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != currentProcess.Id)
                {
                    IntPtr hWnd = process.MainWindowHandle;
                    if (hWnd != IntPtr.Zero)
                    {
                        // Bring the window to the foreground
                        NativeMethods.ShowWindow(hWnd, NativeMethods.SW_RESTORE);
                        //NativeMethods.SetForegroundWindow(hWnd);
                        break;
                    }
                }
            }
        }
        public static class NativeMethods
        {
            public const int SW_RESTORE = 9;

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool IsIconic(IntPtr hWnd);

            [System.Runtime.InteropServices.DllImport("user32.dll")]
            public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        }
        private static void CreateDatabaseConnection()
        {
            if (!File.Exists(ApplicationConstants.APP_DATA_SYSTEM_FOLDER))
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

                if (!File.Exists(ApplicationConstants.CONFIG_PATH))
                {

                    // config.json default contents
                    var formatConfig = new
                    {
                        DATABASE_CONNECTION_STRING = "Server=localhost;Database=tjpdb;Uid=root;Pwd=@dmin_1223;"
                    };

                    // savingsFormat json
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
        }
    }
}
