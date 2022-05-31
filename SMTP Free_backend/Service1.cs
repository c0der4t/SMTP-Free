using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SMTP_Free_backend
{
    public partial class Service1 : ServiceBase
    {
        //Global variables
        string sLoggingDir = "C:\\temp";
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {
        }

        /// <summary>
        /// Writes the given message to the application log file. Can also add message to event viewer
        /// </summary>
        /// <param name="sLogMessage">The message to append to the log or event viewer</param>
        /// <param name="WritetoEventLog">Writes the given message to the event viewer under Applications.</param>
        private void WritetoLog(string sLogMessage, bool WritetoEventLog = false,string EventLogType = "Information")
        {
            //Ensure logging directory exists
            if (!Directory.Exists(sLoggingDir))
            {
                Directory.CreateDirectory(sLoggingDir);
            }

            //Generate the filename for today's log.
            string sLogFileName = "SMTP Free Log [" + DateTime.Now.Date.ToString().Substring(0,10).Replace("/","-") + "]";

            using (StreamWriter LogFile = new StreamWriter(Path.Combine(sLoggingDir,sLogFileName), append:true))
            {
                LogFile.Write(sLogMessage);
            }

            //Write message to the event log.
            
        }
    }
}
