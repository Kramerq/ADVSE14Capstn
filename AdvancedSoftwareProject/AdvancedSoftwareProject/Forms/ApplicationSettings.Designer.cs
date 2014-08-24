namespace AdvancedSoftwareProject.Forms
{
    partial class ApplicationSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.twitterGB = new System.Windows.Forms.GroupBox();
            this.wCodeTB = new System.Windows.Forms.TextBox();
            this.widgetCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.twitterRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.twitterAuthBTN = new System.Windows.Forms.Button();
            this.twitterAuthoLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.facebookGB = new System.Windows.Forms.GroupBox();
            this.groupIDReset = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.FBgroupID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FBAuthBTN = new System.Windows.Forms.Button();
            this.facebookRefreshRate = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.FBStatusLBL = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailGB = new System.Windows.Forms.GroupBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portTB = new System.Windows.Forms.TextBox();
            this.serverTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.okBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.sendingOptionsGB = new System.Windows.Forms.GroupBox();
            this.yahooRB = new System.Windows.Forms.RadioButton();
            this.gmailRB = new System.Windows.Forms.RadioButton();
            this.officeRB = new System.Windows.Forms.RadioButton();
            this.emailCB = new System.Windows.Forms.CheckBox();
            this.twitterCB = new System.Windows.Forms.CheckBox();
            this.fbCB = new System.Windows.Forms.CheckBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.profileLBL = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.changeBTN = new System.Windows.Forms.Button();
            this.twitterGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twitterRefreshRate)).BeginInit();
            this.facebookGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookRefreshRate)).BeginInit();
            this.emailGB.SuspendLayout();
            this.sendingOptionsGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // twitterGB
            // 
            this.twitterGB.Controls.Add(this.wCodeTB);
            this.twitterGB.Controls.Add(this.widgetCode);
            this.twitterGB.Controls.Add(this.label6);
            this.twitterGB.Controls.Add(this.twitterRefreshRate);
            this.twitterGB.Controls.Add(this.label5);
            this.twitterGB.Controls.Add(this.twitterAuthBTN);
            this.twitterGB.Controls.Add(this.twitterAuthoLabel);
            this.twitterGB.Controls.Add(this.label4);
            this.twitterGB.Location = new System.Drawing.Point(16, 59);
            this.twitterGB.Name = "twitterGB";
            this.twitterGB.Size = new System.Drawing.Size(352, 258);
            this.twitterGB.TabIndex = 0;
            this.twitterGB.TabStop = false;
            this.twitterGB.Text = "Twitter Settings";
            // 
            // wCodeTB
            // 
            this.wCodeTB.Location = new System.Drawing.Point(16, 148);
            this.wCodeTB.Multiline = true;
            this.wCodeTB.Name = "wCodeTB";
            this.wCodeTB.Size = new System.Drawing.Size(319, 98);
            this.wCodeTB.TabIndex = 8;
            // 
            // widgetCode
            // 
            this.widgetCode.AutoSize = true;
            this.widgetCode.Location = new System.Drawing.Point(13, 129);
            this.widgetCode.Name = "widgetCode";
            this.widgetCode.Size = new System.Drawing.Size(69, 13);
            this.widgetCode.TabIndex = 7;
            this.widgetCode.Text = "Widget Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "seconds";
            // 
            // twitterRefreshRate
            // 
            this.twitterRefreshRate.Location = new System.Drawing.Point(86, 87);
            this.twitterRefreshRate.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.twitterRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.twitterRefreshRate.Name = "twitterRefreshRate";
            this.twitterRefreshRate.Size = new System.Drawing.Size(64, 20);
            this.twitterRefreshRate.TabIndex = 5;
            this.twitterRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Refresh Rate:";
            // 
            // twitterAuthBTN
            // 
            this.twitterAuthBTN.Location = new System.Drawing.Point(10, 50);
            this.twitterAuthBTN.Name = "twitterAuthBTN";
            this.twitterAuthBTN.Size = new System.Drawing.Size(140, 23);
            this.twitterAuthBTN.TabIndex = 3;
            this.twitterAuthBTN.Text = "Authorize";
            this.twitterAuthBTN.UseVisualStyleBackColor = true;
            this.twitterAuthBTN.Click += new System.EventHandler(this.twitterAuthBTN_Click);
            // 
            // twitterAuthoLabel
            // 
            this.twitterAuthoLabel.AutoSize = true;
            this.twitterAuthoLabel.ForeColor = System.Drawing.Color.Red;
            this.twitterAuthoLabel.Location = new System.Drawing.Point(53, 22);
            this.twitterAuthoLabel.Name = "twitterAuthoLabel";
            this.twitterAuthoLabel.Size = new System.Drawing.Size(77, 13);
            this.twitterAuthoLabel.TabIndex = 2;
            this.twitterAuthoLabel.Text = "Not Authorized";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Status:";
            // 
            // facebookGB
            // 
            this.facebookGB.Controls.Add(this.groupIDReset);
            this.facebookGB.Controls.Add(this.label12);
            this.facebookGB.Controls.Add(this.FBgroupID);
            this.facebookGB.Controls.Add(this.label8);
            this.facebookGB.Controls.Add(this.FBAuthBTN);
            this.facebookGB.Controls.Add(this.facebookRefreshRate);
            this.facebookGB.Controls.Add(this.label9);
            this.facebookGB.Controls.Add(this.FBStatusLBL);
            this.facebookGB.Controls.Add(this.label7);
            this.facebookGB.Location = new System.Drawing.Point(374, 59);
            this.facebookGB.Name = "facebookGB";
            this.facebookGB.Size = new System.Drawing.Size(396, 258);
            this.facebookGB.TabIndex = 1;
            this.facebookGB.TabStop = false;
            this.facebookGB.Text = "Facebook Settings";
            // 
            // groupIDReset
            // 
            this.groupIDReset.Location = new System.Drawing.Point(261, 77);
            this.groupIDReset.Name = "groupIDReset";
            this.groupIDReset.Size = new System.Drawing.Size(119, 23);
            this.groupIDReset.TabIndex = 10;
            this.groupIDReset.Text = "Reset FB Group ID";
            this.groupIDReset.UseVisualStyleBackColor = true;
            this.groupIDReset.Click += new System.EventHandler(this.groupIDReset_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "FB Group ID:";
            // 
            // FBgroupID
            // 
            this.FBgroupID.Location = new System.Drawing.Point(180, 50);
            this.FBgroupID.Name = "FBgroupID";
            this.FBgroupID.Size = new System.Drawing.Size(195, 20);
            this.FBgroupID.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(152, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "seconds";
            // 
            // FBAuthBTN
            // 
            this.FBAuthBTN.Location = new System.Drawing.Point(6, 50);
            this.FBAuthBTN.Name = "FBAuthBTN";
            this.FBAuthBTN.Size = new System.Drawing.Size(140, 23);
            this.FBAuthBTN.TabIndex = 4;
            this.FBAuthBTN.Text = "Authorize";
            this.FBAuthBTN.UseVisualStyleBackColor = true;
            this.FBAuthBTN.Click += new System.EventHandler(this.FBAuthBTN_Click);
            // 
            // facebookRefreshRate
            // 
            this.facebookRefreshRate.Location = new System.Drawing.Point(82, 87);
            this.facebookRefreshRate.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.facebookRefreshRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.facebookRefreshRate.Name = "facebookRefreshRate";
            this.facebookRefreshRate.Size = new System.Drawing.Size(64, 20);
            this.facebookRefreshRate.TabIndex = 8;
            this.facebookRefreshRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Refresh Rate:";
            // 
            // FBStatusLBL
            // 
            this.FBStatusLBL.AutoSize = true;
            this.FBStatusLBL.ForeColor = System.Drawing.Color.Red;
            this.FBStatusLBL.Location = new System.Drawing.Point(54, 22);
            this.FBStatusLBL.Name = "FBStatusLBL";
            this.FBStatusLBL.Size = new System.Drawing.Size(77, 13);
            this.FBStatusLBL.TabIndex = 4;
            this.FBStatusLBL.Text = "Not Authorized";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status:";
            // 
            // emailGB
            // 
            this.emailGB.Controls.Add(this.passTB);
            this.emailGB.Controls.Add(this.label3);
            this.emailGB.Controls.Add(this.userTB);
            this.emailGB.Controls.Add(this.label2);
            this.emailGB.Controls.Add(this.portTB);
            this.emailGB.Controls.Add(this.serverTB);
            this.emailGB.Controls.Add(this.label1);
            this.emailGB.Location = new System.Drawing.Point(776, 59);
            this.emailGB.Name = "emailGB";
            this.emailGB.Size = new System.Drawing.Size(432, 123);
            this.emailGB.TabIndex = 2;
            this.emailGB.TabStop = false;
            this.emailGB.Text = "E-mail Settings";
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(81, 82);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(226, 20);
            this.passTB.TabIndex = 13;
            this.passTB.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // userTB
            // 
            this.userTB.Location = new System.Drawing.Point(81, 53);
            this.userTB.Name = "userTB";
            this.userTB.Size = new System.Drawing.Size(226, 20);
            this.userTB.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Email";
            // 
            // portTB
            // 
            this.portTB.Location = new System.Drawing.Point(313, 22);
            this.portTB.Name = "portTB";
            this.portTB.Size = new System.Drawing.Size(100, 20);
            this.portTB.TabIndex = 9;
            // 
            // serverTB
            // 
            this.serverTB.Location = new System.Drawing.Point(81, 22);
            this.serverTB.Name = "serverTB";
            this.serverTB.Size = new System.Drawing.Size(226, 20);
            this.serverTB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Server/Port";
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(16, 323);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(75, 23);
            this.okBTN.TabIndex = 3;
            this.okBTN.Text = "OK";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBTN.Location = new System.Drawing.Point(194, 323);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 4;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // sendingOptionsGB
            // 
            this.sendingOptionsGB.Controls.Add(this.yahooRB);
            this.sendingOptionsGB.Controls.Add(this.gmailRB);
            this.sendingOptionsGB.Controls.Add(this.officeRB);
            this.sendingOptionsGB.Controls.Add(this.emailCB);
            this.sendingOptionsGB.Controls.Add(this.twitterCB);
            this.sendingOptionsGB.Controls.Add(this.fbCB);
            this.sendingOptionsGB.Location = new System.Drawing.Point(776, 188);
            this.sendingOptionsGB.Name = "sendingOptionsGB";
            this.sendingOptionsGB.Size = new System.Drawing.Size(432, 129);
            this.sendingOptionsGB.TabIndex = 5;
            this.sendingOptionsGB.TabStop = false;
            this.sendingOptionsGB.Text = "Default Sending Options";
            // 
            // yahooRB
            // 
            this.yahooRB.AutoSize = true;
            this.yahooRB.Location = new System.Drawing.Point(146, 55);
            this.yahooRB.Name = "yahooRB";
            this.yahooRB.Size = new System.Drawing.Size(56, 17);
            this.yahooRB.TabIndex = 8;
            this.yahooRB.Text = "Yahoo";
            this.yahooRB.UseVisualStyleBackColor = true;
            // 
            // gmailRB
            // 
            this.gmailRB.AutoSize = true;
            this.gmailRB.Location = new System.Drawing.Point(86, 55);
            this.gmailRB.Name = "gmailRB";
            this.gmailRB.Size = new System.Drawing.Size(54, 17);
            this.gmailRB.TabIndex = 7;
            this.gmailRB.Text = "G-mail";
            this.gmailRB.UseVisualStyleBackColor = true;
            // 
            // officeRB
            // 
            this.officeRB.AutoSize = true;
            this.officeRB.Checked = true;
            this.officeRB.Location = new System.Drawing.Point(10, 55);
            this.officeRB.Name = "officeRB";
            this.officeRB.Size = new System.Drawing.Size(74, 17);
            this.officeRB.TabIndex = 6;
            this.officeRB.TabStop = true;
            this.officeRB.Text = "Office 365";
            this.officeRB.UseVisualStyleBackColor = true;
            // 
            // emailCB
            // 
            this.emailCB.AutoSize = true;
            this.emailCB.Location = new System.Drawing.Point(8, 19);
            this.emailCB.Name = "emailCB";
            this.emailCB.Size = new System.Drawing.Size(54, 17);
            this.emailCB.TabIndex = 5;
            this.emailCB.Text = "E-mail";
            this.emailCB.UseVisualStyleBackColor = true;
            // 
            // twitterCB
            // 
            this.twitterCB.AutoSize = true;
            this.twitterCB.Location = new System.Drawing.Point(162, 19);
            this.twitterCB.Name = "twitterCB";
            this.twitterCB.Size = new System.Drawing.Size(58, 17);
            this.twitterCB.TabIndex = 4;
            this.twitterCB.Text = "Twitter";
            this.twitterCB.UseVisualStyleBackColor = true;
            // 
            // fbCB
            // 
            this.fbCB.AutoSize = true;
            this.fbCB.Location = new System.Drawing.Point(75, 19);
            this.fbCB.Name = "fbCB";
            this.fbCB.Size = new System.Drawing.Size(74, 17);
            this.fbCB.TabIndex = 3;
            this.fbCB.Text = "Facebook";
            this.fbCB.UseVisualStyleBackColor = true;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(105, 323);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(75, 23);
            this.saveBTN.TabIndex = 7;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // profileLBL
            // 
            this.profileLBL.AutoSize = true;
            this.profileLBL.Location = new System.Drawing.Point(91, 9);
            this.profileLBL.Name = "profileLBL";
            this.profileLBL.Size = new System.Drawing.Size(33, 13);
            this.profileLBL.TabIndex = 9;
            this.profileLBL.Text = "None";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Active Profile:";
            // 
            // changeBTN
            // 
            this.changeBTN.Location = new System.Drawing.Point(16, 25);
            this.changeBTN.Name = "changeBTN";
            this.changeBTN.Size = new System.Drawing.Size(114, 23);
            this.changeBTN.TabIndex = 10;
            this.changeBTN.Text = "Change Profile";
            this.changeBTN.UseVisualStyleBackColor = true;
            this.changeBTN.Click += new System.EventHandler(this.changeBTN_Click);
            // 
            // ApplicationSettings
            // 
            this.AcceptButton = this.saveBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBTN;
            this.ClientSize = new System.Drawing.Size(1223, 358);
            this.Controls.Add(this.changeBTN);
            this.Controls.Add(this.profileLBL);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.sendingOptionsGB);
            this.Controls.Add(this.emailGB);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.facebookGB);
            this.Controls.Add(this.twitterGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ApplicationSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Application Settings";
            this.Load += new System.EventHandler(this.ApplicationSettings_Load);
            this.twitterGB.ResumeLayout(false);
            this.twitterGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.twitterRefreshRate)).EndInit();
            this.facebookGB.ResumeLayout(false);
            this.facebookGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebookRefreshRate)).EndInit();
            this.emailGB.ResumeLayout(false);
            this.emailGB.PerformLayout();
            this.sendingOptionsGB.ResumeLayout(false);
            this.sendingOptionsGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox twitterGB;
        private System.Windows.Forms.GroupBox facebookGB;
        private System.Windows.Forms.GroupBox emailGB;
        private System.Windows.Forms.Button okBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTB;
        private System.Windows.Forms.TextBox serverTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button twitterAuthBTN;
        private System.Windows.Forms.Label twitterAuthoLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FBAuthBTN;
        private System.Windows.Forms.Label FBStatusLBL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox sendingOptionsGB;
        private System.Windows.Forms.CheckBox emailCB;
        private System.Windows.Forms.CheckBox twitterCB;
        private System.Windows.Forms.CheckBox fbCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown twitterRefreshRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown facebookRefreshRate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox FBgroupID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button groupIDReset;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.RadioButton yahooRB;
        private System.Windows.Forms.RadioButton gmailRB;
        private System.Windows.Forms.RadioButton officeRB;
        private System.Windows.Forms.Label profileLBL;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button changeBTN;
        private System.Windows.Forms.TextBox wCodeTB;
        private System.Windows.Forms.Label widgetCode;
    }
}