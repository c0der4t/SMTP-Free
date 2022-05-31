using System;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SMTP_Free_frontend
{
    public partial class frmMain : Form
    {



        string sSettingsPath = Path.Combine(Application.StartupPath, "settings.ini");
        string sUUID = "";

        public frmMain()
        {
            InitializeComponent();

            //Load Current Settings
            //Default location is in the settings.ini file in current directory
            GetUniqueID();
            LoadSettings();

        }

        private void GetUniqueID()
        {
            RegistryKey Reg = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
            sUUID = (string)Reg.GetValue("ProductId") != string.Empty ? (string)Reg.GetValue("ProductId") : "5896958412659156268741284";
        }

        private void btnBrowseLogFileDir_Click(object sender, EventArgs e)
        {
            dlgFolderBrowse.ShowDialog();
            if (dlgFolderBrowse.SelectedPath != string.Empty)
            {
                edtLogFileLocation.Text = dlgFolderBrowse.SelectedPath;
            }
        }

        private void btnBrowseEmailQueue_Click(object sender, EventArgs e)
        {
            dlgFolderBrowse.ShowDialog();
            if (dlgFolderBrowse.SelectedPath != string.Empty)
            {
                edtEmailQueueLoc.Text = dlgFolderBrowse.SelectedPath;
            }
        }

        private void btnTestEmail_Click(object sender, EventArgs e)
        {
            //Check if input is empty

            int iInputValid = 4;

            iInputValid = edtEmail.Text == string.Empty ? iInputValid -= 1 : iInputValid;
            iInputValid = edtPassword.Text == string.Empty ? iInputValid -= 1 : iInputValid;
            iInputValid = edtMailserver.Text == string.Empty ? iInputValid -= 1 : iInputValid;
            iInputValid = edtPort.Text == string.Empty ? iInputValid -= 1 : iInputValid;

            if (iInputValid < 4)
            {
                MessageBox.Show("Some email settings are missing. Please check the settings.");
            }
        }

        private void LoadSettings()
        {
            lblCurrentDir.Text = $"Config Location: {sSettingsPath}";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you'd like to overwrite the current configuration?", "Confirm Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string NewConfig = string.Empty;
                using (StreamReader oldconfig = new StreamReader(sSettingsPath))
                {
                    string sLine = "";

                    while ((sLine = oldconfig.ReadLine()) != null)
                    {
                        sLine = sLine.ToLower();

                        sLine = sLine.Contains("email") ? "email:" + edtEmail.Text : sLine;
                        sLine = sLine.Contains("mailserver") ? "mailserver:" + edtMailserver.Text : sLine;
                        sLine = sLine.Contains("port") ? "port:" + edtPort.Text : sLine;
                        sLine = sLine.Contains("ssl") ? "ssl:" + chckbxUseSSL.Checked.ToString() : sLine;

                        sLine = sLine.Contains("logpath") ? "logpath:" + edtLogFileLocation.Text : sLine;
                        sLine = sLine.Contains("queuepath") ? "queuepath:" + edtEmailQueueLoc.Text : sLine;

                        NewConfig += sLine + "\n";
                    }
                }

                using (StreamWriter NewConfigOut = new StreamWriter(sSettingsPath))
                {
                    NewConfigOut.Write(NewConfig);
                }

                //Write credential to key file
                File.WriteAllBytes(Path.Combine(Application.StartupPath, "smtp.txt"), _encryption.EncryptString(edtPassword.Text, sUUID));

                MessageBox.Show("Configuration saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReloadSettigns_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All unsaved changes will be lost", "Confirm Reload", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoadSettings();
            }
        }

        private string ParseSettingValue(string RawKeyValuePair)
        {
            return RawKeyValuePair.Substring(RawKeyValuePair.IndexOf(":") + 1);
        }

        private void btnExportSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please note:\nThe SMTP password is bound to this machine and cannot be exported to another system.\nThe password needs to be entered again on a new setup.",
                "Export Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SaveFileDialog savedlg = new SaveFileDialog();
            savedlg.DefaultExt = ".ini";
            savedlg.Filter = "INI File|*.ini";
            savedlg.ShowDialog();

            if (savedlg.FileName != string.Empty)
            {
                if (File.Exists(savedlg.FileName))
                {
                    File.Delete(savedlg.FileName);
                }
                File.Copy(sSettingsPath, savedlg.FileName);


                MessageBox.Show($"Settings exported to {savedlg.FileName}", "Export Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnImportSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please note:\nThe SMTP password is bound to this machine and cannot be imported from another system.\nThe password needs to be entered again on a new setup.",
                "Import Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            OpenFileDialog importfile = new OpenFileDialog();
            importfile.Filter = "INI File|*.ini";
            importfile.DefaultExt = ".ini";
            importfile.Title = "Select a config file to import";
            importfile.ShowDialog();

            if (importfile.FileName != string.Empty)
            {
                if (File.Exists(sSettingsPath))
                {
                    File.Delete(sSettingsPath);
                }

                File.Copy(importfile.FileName, sSettingsPath);
                MessageBox.Show($"Settings imported to {sSettingsPath}", "Import Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadSettings();
            }
        }
    }
}
