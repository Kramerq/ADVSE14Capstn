namespace AdvancedSoftwareProject.Forms
{
    partial class ComposeMessage
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
            this.sendingGB = new System.Windows.Forms.GroupBox();
            this.emailCB = new System.Windows.Forms.CheckBox();
            this.twitterCB = new System.Windows.Forms.CheckBox();
            this.fbCB = new System.Windows.Forms.CheckBox();
            this.sendCloseButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.charsDescripLabel = new System.Windows.Forms.Label();
            this.messageTB = new System.Windows.Forms.RichTextBox();
            this.charsInputtedLabel = new System.Windows.Forms.Label();
            this.twitterUnavailableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectTB = new System.Windows.Forms.TextBox();
            this.classDropDown = new System.Windows.Forms.ComboBox();
            this.addStudentTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fromTB = new System.Windows.Forms.TextBox();
            this.ccTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bccTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.closeBTN = new System.Windows.Forms.Button();
            this.sendingGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendingGB
            // 
            this.sendingGB.Controls.Add(this.emailCB);
            this.sendingGB.Controls.Add(this.twitterCB);
            this.sendingGB.Controls.Add(this.fbCB);
            this.sendingGB.Location = new System.Drawing.Point(2, 406);
            this.sendingGB.Name = "sendingGB";
            this.sendingGB.Size = new System.Drawing.Size(253, 56);
            this.sendingGB.TabIndex = 1;
            this.sendingGB.TabStop = false;
            this.sendingGB.Text = "Settings:";
            // 
            // emailCB
            // 
            this.emailCB.AutoSize = true;
            this.emailCB.Location = new System.Drawing.Point(6, 20);
            this.emailCB.Name = "emailCB";
            this.emailCB.Size = new System.Drawing.Size(54, 17);
            this.emailCB.TabIndex = 2;
            this.emailCB.Text = "E-mail";
            this.emailCB.UseVisualStyleBackColor = true;
            this.emailCB.CheckedChanged += new System.EventHandler(this.emailCB_CheckedChanged);
            // 
            // twitterCB
            // 
            this.twitterCB.AutoSize = true;
            this.twitterCB.Location = new System.Drawing.Point(178, 20);
            this.twitterCB.Name = "twitterCB";
            this.twitterCB.Size = new System.Drawing.Size(58, 17);
            this.twitterCB.TabIndex = 1;
            this.twitterCB.Text = "Twitter";
            this.twitterCB.UseVisualStyleBackColor = true;
            // 
            // fbCB
            // 
            this.fbCB.AutoSize = true;
            this.fbCB.Location = new System.Drawing.Point(82, 20);
            this.fbCB.Name = "fbCB";
            this.fbCB.Size = new System.Drawing.Size(74, 17);
            this.fbCB.TabIndex = 0;
            this.fbCB.Text = "Facebook";
            this.fbCB.UseVisualStyleBackColor = true;
            // 
            // sendCloseButton
            // 
            this.sendCloseButton.Location = new System.Drawing.Point(2, 476);
            this.sendCloseButton.Name = "sendCloseButton";
            this.sendCloseButton.Size = new System.Drawing.Size(75, 23);
            this.sendCloseButton.TabIndex = 2;
            this.sendCloseButton.Text = "Send";
            this.sendCloseButton.UseVisualStyleBackColor = true;
            this.sendCloseButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(84, 476);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Clear";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // charsDescripLabel
            // 
            this.charsDescripLabel.AutoSize = true;
            this.charsDescripLabel.Location = new System.Drawing.Point(505, 406);
            this.charsDescripLabel.Name = "charsDescripLabel";
            this.charsDescripLabel.Size = new System.Drawing.Size(58, 13);
            this.charsDescripLabel.TabIndex = 5;
            this.charsDescripLabel.Text = "Characters";
            // 
            // messageTB
            // 
            this.messageTB.Location = new System.Drawing.Point(8, 159);
            this.messageTB.Name = "messageTB";
            this.messageTB.Size = new System.Drawing.Size(561, 241);
            this.messageTB.TabIndex = 7;
            this.messageTB.Text = "";
            this.messageTB.TextChanged += new System.EventHandler(this.messageTB_TextChanged);
            // 
            // charsInputtedLabel
            // 
            this.charsInputtedLabel.Location = new System.Drawing.Point(321, 406);
            this.charsInputtedLabel.Name = "charsInputtedLabel";
            this.charsInputtedLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.charsInputtedLabel.Size = new System.Drawing.Size(185, 13);
            this.charsInputtedLabel.TabIndex = 6;
            this.charsInputtedLabel.Text = "0";
            this.charsInputtedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // twitterUnavailableLabel
            // 
            this.twitterUnavailableLabel.AutoSize = true;
            this.twitterUnavailableLabel.BackColor = System.Drawing.SystemColors.Control;
            this.twitterUnavailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twitterUnavailableLabel.ForeColor = System.Drawing.Color.Red;
            this.twitterUnavailableLabel.Location = new System.Drawing.Point(343, 421);
            this.twitterUnavailableLabel.Name = "twitterUnavailableLabel";
            this.twitterUnavailableLabel.Size = new System.Drawing.Size(232, 13);
            this.twitterUnavailableLabel.TabIndex = 9;
            this.twitterUnavailableLabel.Text = "Twitter post unavailable while characters > 160.";
            this.twitterUnavailableLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Class";
            // 
            // subjectTB
            // 
            this.subjectTB.Location = new System.Drawing.Point(58, 93);
            this.subjectTB.Name = "subjectTB";
            this.subjectTB.Size = new System.Drawing.Size(255, 20);
            this.subjectTB.TabIndex = 12;
            // 
            // classDropDown
            // 
            this.classDropDown.FormattingEnabled = true;
            this.classDropDown.Location = new System.Drawing.Point(58, 122);
            this.classDropDown.Name = "classDropDown";
            this.classDropDown.Size = new System.Drawing.Size(255, 21);
            this.classDropDown.TabIndex = 13;
            this.classDropDown.SelectedIndexChanged += new System.EventHandler(this.classDropDown_SelectedIndexChanged);
            // 
            // addStudentTB
            // 
            this.addStudentTB.Location = new System.Drawing.Point(319, 122);
            this.addStudentTB.Multiline = true;
            this.addStudentTB.Name = "addStudentTB";
            this.addStudentTB.Size = new System.Drawing.Size(250, 20);
            this.addStudentTB.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "From";
            // 
            // fromTB
            // 
            this.fromTB.Location = new System.Drawing.Point(58, 6);
            this.fromTB.Multiline = true;
            this.fromTB.Name = "fromTB";
            this.fromTB.Size = new System.Drawing.Size(255, 20);
            this.fromTB.TabIndex = 18;
            // 
            // ccTB
            // 
            this.ccTB.Location = new System.Drawing.Point(58, 35);
            this.ccTB.Name = "ccTB";
            this.ccTB.Size = new System.Drawing.Size(255, 20);
            this.ccTB.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "CC";
            // 
            // bccTB
            // 
            this.bccTB.Location = new System.Drawing.Point(58, 64);
            this.bccTB.Name = "bccTB";
            this.bccTB.Size = new System.Drawing.Size(255, 20);
            this.bccTB.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "BCC";
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(180, 476);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 24;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // ComposeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(581, 511);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.bccTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ccTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fromTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addStudentTB);
            this.Controls.Add(this.classDropDown);
            this.Controls.Add(this.subjectTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.twitterUnavailableLabel);
            this.Controls.Add(this.messageTB);
            this.Controls.Add(this.charsInputtedLabel);
            this.Controls.Add(this.charsDescripLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sendCloseButton);
            this.Controls.Add(this.sendingGB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ComposeMessage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Compose a New Message";
            this.Load += new System.EventHandler(this.ComposeMessage_Load);
            this.sendingGB.ResumeLayout(false);
            this.sendingGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sendingGB;
        private System.Windows.Forms.CheckBox emailCB;
        private System.Windows.Forms.CheckBox twitterCB;
        private System.Windows.Forms.CheckBox fbCB;
        private System.Windows.Forms.Button sendCloseButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label charsDescripLabel;
        private System.Windows.Forms.RichTextBox messageTB;
        private System.Windows.Forms.Label charsInputtedLabel;
        private System.Windows.Forms.Label twitterUnavailableLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subjectTB;
        private System.Windows.Forms.ComboBox classDropDown;
        private System.Windows.Forms.TextBox addStudentTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fromTB;
        private System.Windows.Forms.TextBox ccTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bccTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button closeBTN;
    }
}