namespace AdvancedSoftwareProject.Forms
{
    partial class ClassManager
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.classSectionTextBox = new System.Windows.Forms.TextBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.classNameTextBox = new System.Windows.Forms.TextBox();
            this.cName = new System.Windows.Forms.Label();
            this.classView = new System.Windows.Forms.ListView();
            this.Class = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Section = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fbGroupId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.DeleteBTN = new System.Windows.Forms.Button();
            this.doneBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fbGroupIdTextBox = new System.Windows.Forms.TextBox();
            this.ClassNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // classSectionTextBox
            // 
            this.classSectionTextBox.Location = new System.Drawing.Point(323, 39);
            this.classSectionTextBox.MaxLength = 3;
            this.classSectionTextBox.Name = "classSectionTextBox";
            this.classSectionTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.classSectionTextBox.Size = new System.Drawing.Size(43, 20);
            this.classSectionTextBox.TabIndex = 12;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(271, 43);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(46, 13);
            this.sectionLabel.TabIndex = 11;
            this.sectionLabel.Text = "Section:";
            // 
            // classNameTextBox
            // 
            this.classNameTextBox.Location = new System.Drawing.Point(323, 10);
            this.classNameTextBox.Name = "classNameTextBox";
            this.classNameTextBox.Size = new System.Drawing.Size(273, 20);
            this.classNameTextBox.TabIndex = 9;
            // 
            // cName
            // 
            this.cName.AutoSize = true;
            this.cName.Location = new System.Drawing.Point(251, 13);
            this.cName.Name = "cName";
            this.cName.Size = new System.Drawing.Size(66, 13);
            this.cName.TabIndex = 7;
            this.cName.Text = "Class Name:";
            // 
            // classView
            // 
            this.classView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassNumber,
            this.Class,
            this.Section,
            this.fbGroupId});
            this.classView.FullRowSelect = true;
            this.classView.Location = new System.Drawing.Point(13, 13);
            this.classView.Name = "classView";
            this.classView.Size = new System.Drawing.Size(238, 120);
            this.classView.TabIndex = 13;
            this.classView.UseCompatibleStateImageBehavior = false;
            this.classView.View = System.Windows.Forms.View.Details;
            this.classView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.classView_ItemSelectionChanged);
            // 
            // Class
            // 
            this.Class.Text = "Class";
            this.Class.Width = 96;
            // 
            // Section
            // 
            this.Section.Text = "Section";
            this.Section.Width = 48;
            // 
            // fbGroupId
            // 
            this.fbGroupId.Text = "FB Group ID";
            this.fbGroupId.Width = 73;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(518, 65);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(75, 23);
            this.addBTN.TabIndex = 16;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(434, 65);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(75, 23);
            this.updateBTN.TabIndex = 17;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // DeleteBTN
            // 
            this.DeleteBTN.Location = new System.Drawing.Point(353, 65);
            this.DeleteBTN.Name = "DeleteBTN";
            this.DeleteBTN.Size = new System.Drawing.Size(75, 23);
            this.DeleteBTN.TabIndex = 18;
            this.DeleteBTN.Text = "Delete";
            this.DeleteBTN.UseVisualStyleBackColor = true;
            this.DeleteBTN.Click += new System.EventHandler(this.DeleteBTN_Click);
            // 
            // doneBTN
            // 
            this.doneBTN.Location = new System.Drawing.Point(518, 110);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(75, 23);
            this.doneBTN.TabIndex = 19;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = true;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Facebook Group ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fbGroupIdTextBox
            // 
            this.fbGroupIdTextBox.Location = new System.Drawing.Point(481, 38);
            this.fbGroupIdTextBox.Name = "fbGroupIdTextBox";
            this.fbGroupIdTextBox.Size = new System.Drawing.Size(115, 20);
            this.fbGroupIdTextBox.TabIndex = 21;
            // 
            // ClassNumber
            // 
            this.ClassNumber.Text = "#";
            this.ClassNumber.Width = 18;
            // 
            // ClassManager
            // 
            this.AcceptButton = this.doneBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 142);
            this.Controls.Add(this.fbGroupIdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneBTN);
            this.Controls.Add(this.DeleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.classView);
            this.Controls.Add(this.classSectionTextBox);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.classNameTextBox);
            this.Controls.Add(this.cName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ClassManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Class Manager";
            this.Load += new System.EventHandler(this.ClassManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox classSectionTextBox;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.TextBox classNameTextBox;
        private System.Windows.Forms.Label cName;
        private System.Windows.Forms.ListView classView;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button DeleteBTN;
        private System.Windows.Forms.Button doneBTN;
        private System.Windows.Forms.ColumnHeader Class;
        private System.Windows.Forms.ColumnHeader Section;
        private System.Windows.Forms.ColumnHeader fbGroupId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fbGroupIdTextBox;
        private System.Windows.Forms.ColumnHeader ClassNumber;
    }
}