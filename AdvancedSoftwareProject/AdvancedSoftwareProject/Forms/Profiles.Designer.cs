namespace AdvancedSoftwareProject.Forms
{
    partial class Profiles
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
            this.profilesLB = new System.Windows.Forms.ListBox();
            this.selectBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // profilesLB
            // 
            this.profilesLB.FormattingEnabled = true;
            this.profilesLB.Items.AddRange(new object[] {
            "Advanced Software Engineering"});
            this.profilesLB.Location = new System.Drawing.Point(13, 13);
            this.profilesLB.Name = "profilesLB";
            this.profilesLB.Size = new System.Drawing.Size(230, 160);
            this.profilesLB.TabIndex = 0;
            // 
            // selectBTN
            // 
            this.selectBTN.Location = new System.Drawing.Point(13, 179);
            this.selectBTN.Name = "selectBTN";
            this.selectBTN.Size = new System.Drawing.Size(75, 23);
            this.selectBTN.TabIndex = 1;
            this.selectBTN.Text = "Select";
            this.selectBTN.UseVisualStyleBackColor = true;
            this.selectBTN.Click += new System.EventHandler(this.selectBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(94, 179);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 2;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // Profiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 209);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.selectBTN);
            this.Controls.Add(this.profilesLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Profiles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profiles Available";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox profilesLB;
        private System.Windows.Forms.Button selectBTN;
        private System.Windows.Forms.Button cancelBTN;
    }
}