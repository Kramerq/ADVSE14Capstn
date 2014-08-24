namespace AdvancedSoftwareProject
{
    partial class mainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.classesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.marginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FB_Twitter_Splitter = new System.Windows.Forms.SplitContainer();
            this.FBFeed = new System.Windows.Forms.WebBrowser();
            this.twitterFeed = new System.Windows.Forms.WebBrowser();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.profileLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.composeBTN = new System.Windows.Forms.Button();
            this.emailBrowser = new System.Windows.Forms.WebBrowser();
            this.formSplitter = new System.Windows.Forms.SplitContainer();
            this.fbColorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FB_Twitter_Splitter)).BeginInit();
            this.FB_Twitter_Splitter.Panel1.SuspendLayout();
            this.FB_Twitter_Splitter.Panel2.SuspendLayout();
            this.FB_Twitter_Splitter.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formSplitter)).BeginInit();
            this.formSplitter.Panel1.SuspendLayout();
            this.formSplitter.Panel2.SuspendLayout();
            this.formSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.feedsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1189, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.classesToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.messageHistoryToolStripMenuItem,
            this.profileToolStripMenuItem1,
            this.marginsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem1
            // 
            this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
            this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.settingsToolStripMenuItem1.Text = "Settings";
            this.settingsToolStripMenuItem1.Click += new System.EventHandler(this.settingsToolStripMenuItem1_Click);
            // 
            // classesToolStripMenuItem
            // 
            this.classesToolStripMenuItem.Name = "classesToolStripMenuItem";
            this.classesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.classesToolStripMenuItem.Text = "Classes";
            this.classesToolStripMenuItem.Click += new System.EventHandler(this.classToolStripMenuItem1_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // messageHistoryToolStripMenuItem
            // 
            this.messageHistoryToolStripMenuItem.Name = "messageHistoryToolStripMenuItem";
            this.messageHistoryToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.messageHistoryToolStripMenuItem.Text = "Message History";
            this.messageHistoryToolStripMenuItem.Click += new System.EventHandler(this.messageHistoryToolStripMenuItem_Click);
            // 
            // profileToolStripMenuItem1
            // 
            this.profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
            this.profileToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.profileToolStripMenuItem1.Text = "&Profile";
            this.profileToolStripMenuItem1.Click += new System.EventHandler(this.profileToolStripMenuItem1_Click);
            // 
            // marginsToolStripMenuItem
            // 
            this.marginsToolStripMenuItem.Name = "marginsToolStripMenuItem";
            this.marginsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.marginsToolStripMenuItem.Text = "&Margins";
            this.marginsToolStripMenuItem.Click += new System.EventHandler(this.marginsToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem1,
            this.facebookToolStripMenuItem1,
            this.twitterToolStripMenuItem1});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // emailToolStripMenuItem1
            // 
            this.emailToolStripMenuItem1.Checked = true;
            this.emailToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.emailToolStripMenuItem1.Name = "emailToolStripMenuItem1";
            this.emailToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.emailToolStripMenuItem1.Text = "E-mail";
            this.emailToolStripMenuItem1.Click += new System.EventHandler(this.emailToolStripMenuItem1_Click);
            // 
            // facebookToolStripMenuItem1
            // 
            this.facebookToolStripMenuItem1.Checked = true;
            this.facebookToolStripMenuItem1.CheckOnClick = true;
            this.facebookToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.facebookToolStripMenuItem1.Name = "facebookToolStripMenuItem1";
            this.facebookToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.facebookToolStripMenuItem1.Text = "Facebook";
            this.facebookToolStripMenuItem1.Click += new System.EventHandler(this.facebookToolStripMenuItem1_Click);
            // 
            // twitterToolStripMenuItem1
            // 
            this.twitterToolStripMenuItem1.Checked = true;
            this.twitterToolStripMenuItem1.CheckOnClick = true;
            this.twitterToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.twitterToolStripMenuItem1.Name = "twitterToolStripMenuItem1";
            this.twitterToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.twitterToolStripMenuItem1.Text = "Twitter";
            this.twitterToolStripMenuItem1.Click += new System.EventHandler(this.twitterToolStripMenuItem1_Click);
            // 
            // feedsToolStripMenuItem
            // 
            this.feedsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshAllToolStripMenuItem});
            this.feedsToolStripMenuItem.Name = "feedsToolStripMenuItem";
            this.feedsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.feedsToolStripMenuItem.Text = "&Feed";
            // 
            // refreshAllToolStripMenuItem
            // 
            this.refreshAllToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.facebookToolStripMenuItem,
            this.twitterToolStripMenuItem,
            this.emailToolStripMenuItem});
            this.refreshAllToolStripMenuItem.Name = "refreshAllToolStripMenuItem";
            this.refreshAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshAllToolStripMenuItem.Text = "&Refresh";
            this.refreshAllToolStripMenuItem.Click += new System.EventHandler(this.refreshAllToolStripMenuItem_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allToolStripMenuItem.Text = "&All";
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.facebookToolStripMenuItem.Text = "&Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // twitterToolStripMenuItem
            // 
            this.twitterToolStripMenuItem.Name = "twitterToolStripMenuItem";
            this.twitterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.twitterToolStripMenuItem.Text = "&Twitter";
            this.twitterToolStripMenuItem.Click += new System.EventHandler(this.twitterToolStripMenuItem_Click_1);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailToolStripMenuItem.Text = "&E-mail";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsToolStripMenuItem,
            this.emailUsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // emailUsToolStripMenuItem
            // 
            this.emailUsToolStripMenuItem.Name = "emailUsToolStripMenuItem";
            this.emailUsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.emailUsToolStripMenuItem.Text = "Contact Us";
            // 
            // FB_Twitter_Splitter
            // 
            this.FB_Twitter_Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FB_Twitter_Splitter.Location = new System.Drawing.Point(0, 0);
            this.FB_Twitter_Splitter.Margin = new System.Windows.Forms.Padding(0);
            this.FB_Twitter_Splitter.Name = "FB_Twitter_Splitter";
            this.FB_Twitter_Splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // FB_Twitter_Splitter.Panel1
            // 
            this.FB_Twitter_Splitter.Panel1.Controls.Add(this.FBFeed);
            // 
            // FB_Twitter_Splitter.Panel2
            // 
            this.FB_Twitter_Splitter.Panel2.Controls.Add(this.twitterFeed);
            this.FB_Twitter_Splitter.Size = new System.Drawing.Size(448, 713);
            this.FB_Twitter_Splitter.SplitterDistance = 240;
            this.FB_Twitter_Splitter.TabIndex = 0;
            // 
            // FBFeed
            // 
            this.FBFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FBFeed.Location = new System.Drawing.Point(0, 0);
            this.FBFeed.Margin = new System.Windows.Forms.Padding(5);
            this.FBFeed.MinimumSize = new System.Drawing.Size(20, 20);
            this.FBFeed.Name = "FBFeed";
            this.FBFeed.Size = new System.Drawing.Size(448, 240);
            this.FBFeed.TabIndex = 0;
            // 
            // twitterFeed
            // 
            this.twitterFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.twitterFeed.Location = new System.Drawing.Point(0, 0);
            this.twitterFeed.Margin = new System.Windows.Forms.Padding(5);
            this.twitterFeed.MinimumSize = new System.Drawing.Size(20, 20);
            this.twitterFeed.Name = "twitterFeed";
            this.twitterFeed.Size = new System.Drawing.Size(448, 469);
            this.twitterFeed.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.50475F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.49525F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.emailBrowser, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.54913F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.45087F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(737, 713);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.profileLBL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.composeBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 69);
            this.panel1.TabIndex = 0;
            // 
            // profileLBL
            // 
            this.profileLBL.AutoSize = true;
            this.profileLBL.Location = new System.Drawing.Point(84, 0);
            this.profileLBL.Name = "profileLBL";
            this.profileLBL.Size = new System.Drawing.Size(33, 13);
            this.profileLBL.TabIndex = 4;
            this.profileLBL.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Active Profile:";
            // 
            // composeBTN
            // 
            this.composeBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.composeBTN.Location = new System.Drawing.Point(9, 29);
            this.composeBTN.Name = "composeBTN";
            this.composeBTN.Size = new System.Drawing.Size(719, 27);
            this.composeBTN.TabIndex = 2;
            this.composeBTN.Text = "Compose Message";
            this.composeBTN.UseVisualStyleBackColor = true;
            this.composeBTN.Click += new System.EventHandler(this.composeBTN_Click);
            // 
            // emailBrowser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.emailBrowser, 2);
            this.emailBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailBrowser.Location = new System.Drawing.Point(3, 78);
            this.emailBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.emailBrowser.Name = "emailBrowser";
            this.emailBrowser.Size = new System.Drawing.Size(731, 632);
            this.emailBrowser.TabIndex = 1;
            this.emailBrowser.Url = new System.Uri("http://mail.office365.com", System.UriKind.Absolute);
            // 
            // formSplitter
            // 
            this.formSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSplitter.Location = new System.Drawing.Point(0, 24);
            this.formSplitter.Name = "formSplitter";
            // 
            // formSplitter.Panel1
            // 
            this.formSplitter.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // formSplitter.Panel2
            // 
            this.formSplitter.Panel2.Controls.Add(this.FB_Twitter_Splitter);
            this.formSplitter.Size = new System.Drawing.Size(1189, 713);
            this.formSplitter.SplitterDistance = 737;
            this.formSplitter.TabIndex = 1;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1189, 737);
            this.Controls.Add(this.formSplitter);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "Advanced Software Project";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.FB_Twitter_Splitter.Panel1.ResumeLayout(false);
            this.FB_Twitter_Splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FB_Twitter_Splitter)).EndInit();
            this.FB_Twitter_Splitter.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.formSplitter.Panel1.ResumeLayout(false);
            this.formSplitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formSplitter)).EndInit();
            this.formSplitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem twitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer FB_Twitter_Splitter;
        private System.Windows.Forms.WebBrowser FBFeed;
        private System.Windows.Forms.WebBrowser twitterFeed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button composeBTN;
        private System.Windows.Forms.SplitContainer formSplitter;
        private System.Windows.Forms.ToolStripMenuItem messageHistoryToolStripMenuItem;
        private System.Windows.Forms.WebBrowser emailBrowser;
        private System.Windows.Forms.ColorDialog fbColorDialog;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem1;
        private System.Windows.Forms.Label profileLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem marginsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
    }
}

