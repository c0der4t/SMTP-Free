
namespace SMTP_Free_frontend
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpbxSMTPSettings = new System.Windows.Forms.GroupBox();
            this.btnTestEmail = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblMailServer = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.chckbxUseSSL = new System.Windows.Forms.CheckBox();
            this.edtPassword = new System.Windows.Forms.MaskedTextBox();
            this.edtPort = new System.Windows.Forms.TextBox();
            this.edtMailserver = new System.Windows.Forms.TextBox();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.grpbxOtherSettings = new System.Windows.Forms.GroupBox();
            this.btnBrowseEmailQueue = new System.Windows.Forms.Button();
            this.edtEmailQueueLoc = new System.Windows.Forms.TextBox();
            this.lblEmailQueueLocation = new System.Windows.Forms.Label();
            this.btnBrowseLogFileDir = new System.Windows.Forms.Button();
            this.edtLogFileLocation = new System.Windows.Forms.TextBox();
            this.lblLogFileDir = new System.Windows.Forms.Label();
            this.dlgFolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExportSettings = new System.Windows.Forms.Button();
            this.btnReloadSettigns = new System.Windows.Forms.Button();
            this.lblCurrentDir = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnImportSettings = new System.Windows.Forms.Button();
            this.grpbxSMTPSettings.SuspendLayout();
            this.grpbxOtherSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxSMTPSettings
            // 
            this.grpbxSMTPSettings.Controls.Add(this.btnTestEmail);
            this.grpbxSMTPSettings.Controls.Add(this.lblPassword);
            this.grpbxSMTPSettings.Controls.Add(this.lblMailServer);
            this.grpbxSMTPSettings.Controls.Add(this.lblPort);
            this.grpbxSMTPSettings.Controls.Add(this.lblEmail);
            this.grpbxSMTPSettings.Controls.Add(this.chckbxUseSSL);
            this.grpbxSMTPSettings.Controls.Add(this.edtPassword);
            this.grpbxSMTPSettings.Controls.Add(this.edtPort);
            this.grpbxSMTPSettings.Controls.Add(this.edtMailserver);
            this.grpbxSMTPSettings.Controls.Add(this.edtEmail);
            this.grpbxSMTPSettings.Location = new System.Drawing.Point(12, 27);
            this.grpbxSMTPSettings.Name = "grpbxSMTPSettings";
            this.grpbxSMTPSettings.Size = new System.Drawing.Size(304, 304);
            this.grpbxSMTPSettings.TabIndex = 0;
            this.grpbxSMTPSettings.TabStop = false;
            this.grpbxSMTPSettings.Text = "SMTP settings";
            // 
            // btnTestEmail
            // 
            this.btnTestEmail.Location = new System.Drawing.Point(32, 258);
            this.btnTestEmail.Name = "btnTestEmail";
            this.btnTestEmail.Size = new System.Drawing.Size(233, 23);
            this.btnTestEmail.TabIndex = 9;
            this.btnTestEmail.Text = "Test Mail Settings";
            this.btnTestEmail.UseVisualStyleBackColor = true;
            this.btnTestEmail.Click += new System.EventHandler(this.btnTestEmail_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(32, 70);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(57, 15);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // lblMailServer
            // 
            this.lblMailServer.AutoSize = true;
            this.lblMailServer.Location = new System.Drawing.Point(32, 128);
            this.lblMailServer.Name = "lblMailServer";
            this.lblMailServer.Size = new System.Drawing.Size(65, 15);
            this.lblMailServer.TabIndex = 7;
            this.lblMailServer.Text = "Mail Server";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(32, 185);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 15);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(32, 21);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // chckbxUseSSL
            // 
            this.chckbxUseSSL.AutoSize = true;
            this.chckbxUseSSL.Location = new System.Drawing.Point(164, 205);
            this.chckbxUseSSL.Name = "chckbxUseSSL";
            this.chckbxUseSSL.Size = new System.Drawing.Size(66, 19);
            this.chckbxUseSSL.TabIndex = 4;
            this.chckbxUseSSL.Text = "Use SSL";
            this.chckbxUseSSL.UseVisualStyleBackColor = true;
            // 
            // edtPassword
            // 
            this.edtPassword.Location = new System.Drawing.Point(32, 88);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Size = new System.Drawing.Size(233, 23);
            this.edtPassword.TabIndex = 3;
            // 
            // edtPort
            // 
            this.edtPort.Location = new System.Drawing.Point(32, 203);
            this.edtPort.Name = "edtPort";
            this.edtPort.Size = new System.Drawing.Size(82, 23);
            this.edtPort.TabIndex = 2;
            // 
            // edtMailserver
            // 
            this.edtMailserver.Location = new System.Drawing.Point(32, 146);
            this.edtMailserver.Name = "edtMailserver";
            this.edtMailserver.Size = new System.Drawing.Size(233, 23);
            this.edtMailserver.TabIndex = 1;
            // 
            // edtEmail
            // 
            this.edtEmail.Location = new System.Drawing.Point(32, 39);
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(233, 23);
            this.edtEmail.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(690, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // grpbxOtherSettings
            // 
            this.grpbxOtherSettings.Controls.Add(this.btnBrowseEmailQueue);
            this.grpbxOtherSettings.Controls.Add(this.edtEmailQueueLoc);
            this.grpbxOtherSettings.Controls.Add(this.lblEmailQueueLocation);
            this.grpbxOtherSettings.Controls.Add(this.btnBrowseLogFileDir);
            this.grpbxOtherSettings.Controls.Add(this.edtLogFileLocation);
            this.grpbxOtherSettings.Controls.Add(this.lblLogFileDir);
            this.grpbxOtherSettings.Location = new System.Drawing.Point(322, 27);
            this.grpbxOtherSettings.Name = "grpbxOtherSettings";
            this.grpbxOtherSettings.Size = new System.Drawing.Size(443, 304);
            this.grpbxOtherSettings.TabIndex = 2;
            this.grpbxOtherSettings.TabStop = false;
            this.grpbxOtherSettings.Text = "Other Settings";
            // 
            // btnBrowseEmailQueue
            // 
            this.btnBrowseEmailQueue.Location = new System.Drawing.Point(407, 88);
            this.btnBrowseEmailQueue.Name = "btnBrowseEmailQueue";
            this.btnBrowseEmailQueue.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseEmailQueue.TabIndex = 6;
            this.btnBrowseEmailQueue.Text = "...";
            this.btnBrowseEmailQueue.UseVisualStyleBackColor = true;
            this.btnBrowseEmailQueue.Click += new System.EventHandler(this.btnBrowseEmailQueue_Click);
            // 
            // edtEmailQueueLoc
            // 
            this.edtEmailQueueLoc.Location = new System.Drawing.Point(23, 88);
            this.edtEmailQueueLoc.Name = "edtEmailQueueLoc";
            this.edtEmailQueueLoc.Size = new System.Drawing.Size(385, 23);
            this.edtEmailQueueLoc.TabIndex = 5;
            // 
            // lblEmailQueueLocation
            // 
            this.lblEmailQueueLocation.AutoSize = true;
            this.lblEmailQueueLocation.Location = new System.Drawing.Point(23, 70);
            this.lblEmailQueueLocation.Name = "lblEmailQueueLocation";
            this.lblEmailQueueLocation.Size = new System.Drawing.Size(123, 15);
            this.lblEmailQueueLocation.TabIndex = 4;
            this.lblEmailQueueLocation.Text = "Email Queue Location";
            // 
            // btnBrowseLogFileDir
            // 
            this.btnBrowseLogFileDir.Location = new System.Drawing.Point(407, 39);
            this.btnBrowseLogFileDir.Name = "btnBrowseLogFileDir";
            this.btnBrowseLogFileDir.Size = new System.Drawing.Size(30, 23);
            this.btnBrowseLogFileDir.TabIndex = 3;
            this.btnBrowseLogFileDir.Text = "...";
            this.btnBrowseLogFileDir.UseVisualStyleBackColor = true;
            this.btnBrowseLogFileDir.Click += new System.EventHandler(this.btnBrowseLogFileDir_Click);
            // 
            // edtLogFileLocation
            // 
            this.edtLogFileLocation.Location = new System.Drawing.Point(23, 39);
            this.edtLogFileLocation.Name = "edtLogFileLocation";
            this.edtLogFileLocation.Size = new System.Drawing.Size(385, 23);
            this.edtLogFileLocation.TabIndex = 1;
            // 
            // lblLogFileDir
            // 
            this.lblLogFileDir.AutoSize = true;
            this.lblLogFileDir.Location = new System.Drawing.Point(23, 21);
            this.lblLogFileDir.Name = "lblLogFileDir";
            this.lblLogFileDir.Size = new System.Drawing.Size(97, 15);
            this.lblLogFileDir.TabIndex = 0;
            this.lblLogFileDir.Text = "Log File Location";
            // 
            // dlgFolderBrowse
            // 
            this.dlgFolderBrowse.RootFolder = System.Environment.SpecialFolder.UserProfile;
            this.dlgFolderBrowse.UseDescriptionForTitle = true;
            // 
            // btnExportSettings
            // 
            this.btnExportSettings.Location = new System.Drawing.Point(12, 333);
            this.btnExportSettings.Name = "btnExportSettings";
            this.btnExportSettings.Size = new System.Drawing.Size(96, 23);
            this.btnExportSettings.TabIndex = 3;
            this.btnExportSettings.Text = "Export Settings";
            this.btnExportSettings.UseVisualStyleBackColor = true;
            this.btnExportSettings.Click += new System.EventHandler(this.btnExportSettings_Click);
            // 
            // btnReloadSettigns
            // 
            this.btnReloadSettigns.Location = new System.Drawing.Point(218, 333);
            this.btnReloadSettigns.Name = "btnReloadSettigns";
            this.btnReloadSettigns.Size = new System.Drawing.Size(98, 23);
            this.btnReloadSettigns.TabIndex = 4;
            this.btnReloadSettigns.Text = "Reload Settings";
            this.btnReloadSettigns.UseVisualStyleBackColor = true;
            this.btnReloadSettigns.Click += new System.EventHandler(this.btnReloadSettigns_Click);
            // 
            // lblCurrentDir
            // 
            this.lblCurrentDir.AutoSize = true;
            this.lblCurrentDir.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentDir.Name = "lblCurrentDir";
            this.lblCurrentDir.Size = new System.Drawing.Size(101, 15);
            this.lblCurrentDir.TabIndex = 10;
            this.lblCurrentDir.Text = "Current Directory:";
            // 
            // btnImportSettings
            // 
            this.btnImportSettings.Location = new System.Drawing.Point(114, 333);
            this.btnImportSettings.Name = "btnImportSettings";
            this.btnImportSettings.Size = new System.Drawing.Size(96, 23);
            this.btnImportSettings.TabIndex = 11;
            this.btnImportSettings.Text = "Import Settings";
            this.btnImportSettings.UseVisualStyleBackColor = true;
            this.btnImportSettings.Click += new System.EventHandler(this.btnImportSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 371);
            this.Controls.Add(this.btnImportSettings);
            this.Controls.Add(this.lblCurrentDir);
            this.Controls.Add(this.btnReloadSettigns);
            this.Controls.Add(this.btnExportSettings);
            this.Controls.Add(this.grpbxOtherSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpbxSMTPSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMTP Free - Settings";
            this.grpbxSMTPSettings.ResumeLayout(false);
            this.grpbxSMTPSettings.PerformLayout();
            this.grpbxOtherSettings.ResumeLayout(false);
            this.grpbxOtherSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxSMTPSettings;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblMailServer;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chckbxUseSSL;
        private System.Windows.Forms.MaskedTextBox edtPassword;
        private System.Windows.Forms.TextBox edtPort;
        private System.Windows.Forms.TextBox edtMailserver;
        private System.Windows.Forms.TextBox edtEmail;
        private System.Windows.Forms.Button btnTestEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox grpbxOtherSettings;
        private System.Windows.Forms.Label lblLogFileDir;
        private System.Windows.Forms.Button btnBrowseLogFileDir;
        private System.Windows.Forms.TextBox edtLogFileLocation;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowse;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.Button btnBrowseEmailQueue;
        private System.Windows.Forms.TextBox edtEmailQueueLoc;
        private System.Windows.Forms.Label lblEmailQueueLocation;
        private System.Windows.Forms.Button btnReloadSettigns;
        private System.Windows.Forms.Label lblCurrentDir;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnImportSettings;
    }
}

