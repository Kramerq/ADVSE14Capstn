namespace AdvancedSoftwareProject.Forms
{
    partial class MessageHistory
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
            this.clearHistoryBtn = new System.Windows.Forms.Button();
            this.messageHistoryTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // clearHistoryBtn
            // 
            this.clearHistoryBtn.Location = new System.Drawing.Point(231, 385);
            this.clearHistoryBtn.Name = "clearHistoryBtn";
            this.clearHistoryBtn.Size = new System.Drawing.Size(135, 23);
            this.clearHistoryBtn.TabIndex = 1;
            this.clearHistoryBtn.Text = "Clear History";
            this.clearHistoryBtn.UseVisualStyleBackColor = true;
            this.clearHistoryBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // messageHistoryTreeView
            // 
            this.messageHistoryTreeView.Location = new System.Drawing.Point(12, 12);
            this.messageHistoryTreeView.Name = "messageHistoryTreeView";
            this.messageHistoryTreeView.Size = new System.Drawing.Size(577, 367);
            this.messageHistoryTreeView.TabIndex = 2;
            // 
            // MessageHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 420);
            this.Controls.Add(this.messageHistoryTreeView);
            this.Controls.Add(this.clearHistoryBtn);
            this.Name = "MessageHistory";
            this.Text = "Message History";
            this.Load += new System.EventHandler(this.MessageHistory_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearHistoryBtn;
        private System.Windows.Forms.TreeView messageHistoryTreeView;

    }
}