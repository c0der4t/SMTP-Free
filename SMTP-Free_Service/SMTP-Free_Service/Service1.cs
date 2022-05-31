using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace SMTP_Free_Service
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Load Settings
        }

        protected override void OnStop()
        {
        }

        private void LoadSettings()
        {
            string sSettingsPath = Path.Combine(, "settings.ini");
            string sUUID = "";

            if (File.Exists(sSettingsPath))
            {
                //Read through the settings file and populate the settings class
                using (StreamReader config = new StreamReader(sSettingsPath))
                {
                    string sLine = "";
                    while ((sLine = config.ReadLine()) != null)
                    {

                        //If the first char is a #, we assume it to be a comment and ignore it
                        if ((sLine != string.Empty) && (sLine[0] != '#'))
                        {
                            sLine = sLine.ToLower();

                            edtEmail.Text = sLine.Contains("email") ? ParseSettingValue(sLine) : edtEmail.Text;
                            edtMailserver.Text = sLine.Contains("mailserver") ? ParseSettingValue(sLine) : edtMailserver.Text;
                            edtPort.Text = sLine.Contains("port") ? ParseSettingValue(sLine) : edtPort.Text;
                            chckbxUseSSL.Checked = (sLine.Contains("ssl") ? (ParseSettingValue(sLine) == "true" ? true : false) : chckbxUseSSL.Checked);


                            //Other / Global settings
                            edtLogFileLocation.Text = sLine.Contains("logpath") ? ParseSettingValue(sLine) : edtLogFileLocation.Text;
                            edtEmailQueueLoc.Text = sLine.Contains("queuepath") ? ParseSettingValue(sLine) : edtEmailQueueLoc.Text;


                        }
                    }
                }
            }

            //Load Key file
            edtPassword.Text = File.Exists(Path.Combine(Application.StartupPath, "smtp.txt")) ? _encryption.DecryptByteArray(File.ReadAllBytes(Path.Combine(Application.StartupPath, "smtp.txt")), sUUID) : "";


        }
    }
}
