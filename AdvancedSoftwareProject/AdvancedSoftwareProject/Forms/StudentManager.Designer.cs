namespace AdvancedSoftwareProject.Forms
{
    partial class StudentManager
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
            this.components = new System.ComponentModel.Container();
            this.studentLV = new System.Windows.Forms.ListView();
            this.IDcol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastNameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EmailCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.classComboBox = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new AdvancedSoftwareProject.DatabaseDataSet();
            this.fNameLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.notesTB = new System.Windows.Forms.RichTextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.FNameTB = new System.Windows.Forms.TextBox();
            this.LNameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.doneBTN = new System.Windows.Forms.Button();
            this.importBTN = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classesTableAdapter = new AdvancedSoftwareProject.DatabaseDataSetTableAdapters.ClassesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentLV
            // 
            this.studentLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDcol,
            this.firstNameCol,
            this.lastNameCol,
            this.EmailCol});
            this.studentLV.FullRowSelect = true;
            this.studentLV.Location = new System.Drawing.Point(12, 54);
            this.studentLV.MultiSelect = false;
            this.studentLV.Name = "studentLV";
            this.studentLV.Size = new System.Drawing.Size(335, 345);
            this.studentLV.TabIndex = 0;
            this.studentLV.UseCompatibleStateImageBehavior = false;
            this.studentLV.View = System.Windows.Forms.View.Details;
            this.studentLV.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.studentLV_ItemSelectionChanged);
            this.studentLV.Click += new System.EventHandler(this.studentLV_Click);
            // 
            // IDcol
            // 
            this.IDcol.Text = "ID";
            // 
            // firstNameCol
            // 
            this.firstNameCol.Text = "First Name";
            this.firstNameCol.Width = 75;
            // 
            // lastNameCol
            // 
            this.lastNameCol.Text = "Last Name";
            this.lastNameCol.Width = 75;
            // 
            // EmailCol
            // 
            this.EmailCol.Text = "Email";
            this.EmailCol.Width = 200;
            // 
            // addBTN
            // 
            this.addBTN.Location = new System.Drawing.Point(357, 207);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(97, 23);
            this.addBTN.TabIndex = 1;
            this.addBTN.Text = "<- Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(357, 265);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(97, 23);
            this.updateBTN.TabIndex = 2;
            this.updateBTN.Text = "Update";
            this.updateBTN.UseVisualStyleBackColor = true;
            this.updateBTN.Click += new System.EventHandler(this.updateBTN_Click);
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(356, 294);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(98, 23);
            this.deleteBTN.TabIndex = 3;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // classComboBox
            // 
            this.classComboBox.FormattingEnabled = true;
            this.classComboBox.Location = new System.Drawing.Point(13, 28);
            this.classComboBox.Name = "classComboBox";
            this.classComboBox.Size = new System.Drawing.Size(236, 21);
            this.classComboBox.TabIndex = 4;
            this.classComboBox.SelectedIndexChanged += new System.EventHandler(this.classComboBox_SelectedIndexChanged);
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "Classes";
            this.classesBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fNameLabel
            // 
            this.fNameLabel.AutoSize = true;
            this.fNameLabel.Location = new System.Drawing.Point(354, 84);
            this.fNameLabel.Name = "fNameLabel";
            this.fNameLabel.Size = new System.Drawing.Size(100, 13);
            this.fNameLabel.TabIndex = 5;
            this.fNameLabel.Text = "Student First Name:";
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.Location = new System.Drawing.Point(353, 111);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(101, 13);
            this.LNameLabel.TabIndex = 6;
            this.LNameLabel.Text = "Student Last Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(376, 138);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(78, 13);
            this.EmailLabel.TabIndex = 7;
            this.EmailLabel.Text = "Student E-mail:";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(393, 57);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(61, 13);
            this.idLabel.TabIndex = 8;
            this.idLabel.Text = "Student ID:";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(416, 172);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(38, 13);
            this.notesLabel.TabIndex = 9;
            this.notesLabel.Text = "Notes:";
            // 
            // notesTB
            // 
            this.notesTB.Location = new System.Drawing.Point(460, 172);
            this.notesTB.Name = "notesTB";
            this.notesTB.Size = new System.Drawing.Size(188, 197);
            this.notesTB.TabIndex = 10;
            this.notesTB.Text = "";
            // 
            // IdTB
            // 
            this.IdTB.Location = new System.Drawing.Point(460, 54);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(188, 20);
            this.IdTB.TabIndex = 11;
            // 
            // FNameTB
            // 
            this.FNameTB.Location = new System.Drawing.Point(460, 81);
            this.FNameTB.Name = "FNameTB";
            this.FNameTB.Size = new System.Drawing.Size(188, 20);
            this.FNameTB.TabIndex = 12;
            // 
            // LNameTB
            // 
            this.LNameTB.Location = new System.Drawing.Point(460, 108);
            this.LNameTB.Name = "LNameTB";
            this.LNameTB.Size = new System.Drawing.Size(188, 20);
            this.LNameTB.TabIndex = 13;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(460, 135);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(188, 20);
            this.emailTB.TabIndex = 14;
            // 
            // doneBTN
            // 
            this.doneBTN.Location = new System.Drawing.Point(573, 378);
            this.doneBTN.Name = "doneBTN";
            this.doneBTN.Size = new System.Drawing.Size(75, 23);
            this.doneBTN.TabIndex = 17;
            this.doneBTN.Text = "Done";
            this.doneBTN.UseVisualStyleBackColor = true;
            this.doneBTN.Click += new System.EventHandler(this.doneBTN_Click);
            // 
            // importBTN
            // 
            this.importBTN.Location = new System.Drawing.Point(357, 236);
            this.importBTN.Name = "importBTN";
            this.importBTN.Size = new System.Drawing.Size(97, 23);
            this.importBTN.TabIndex = 18;
            this.importBTN.Text = "Import CSV";
            this.importBTN.UseVisualStyleBackColor = true;
            this.importBTN.Click += new System.EventHandler(this.importBTN_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.inputToolStripMenuItem.Text = "&Input";
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // StudentManager
            // 
            this.AcceptButton = this.doneBTN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 417);
            this.Controls.Add(this.importBTN);
            this.Controls.Add(this.doneBTN);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.LNameTB);
            this.Controls.Add(this.FNameTB);
            this.Controls.Add(this.IdTB);
            this.Controls.Add(this.notesTB);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LNameLabel);
            this.Controls.Add(this.fNameLabel);
            this.Controls.Add(this.classComboBox);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.addBTN);
            this.Controls.Add(this.studentLV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "StudentManager";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Student Manager";
            this.Load += new System.EventHandler(this.StudentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView studentLV;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.ComboBox classComboBox;
        private System.Windows.Forms.Label fNameLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.RichTextBox notesTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.TextBox FNameTB;
        private System.Windows.Forms.TextBox LNameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button doneBTN;
        private System.Windows.Forms.Button importBTN;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ColumnHeader IDcol;
        private System.Windows.Forms.ColumnHeader firstNameCol;
        private System.Windows.Forms.ColumnHeader EmailCol;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private DatabaseDataSetTableAdapters.ClassesTableAdapter classesTableAdapter;
        private System.Windows.Forms.ColumnHeader lastNameCol;

    }
}