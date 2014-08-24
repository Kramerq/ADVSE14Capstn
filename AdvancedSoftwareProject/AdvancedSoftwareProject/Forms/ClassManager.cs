using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedSoftwareProject.Forms
{
    public partial class ClassManager : Form
    {
        Class selectedClass;

        public ClassManager()
        {
            InitializeComponent();
        }

        private void ClassManager_Load(object sender, EventArgs e)
        {
            classView.Items.Clear();
            updateBTN.Enabled = false;
            DeleteBTN.Enabled = false;

            List<Dictionary<string, string>> classData = DataBaseManager.getClasses();
            foreach(var dictionary in classData)
            {
                string classID = dictionary["classID"];
                string className = dictionary["className"];
                string classSection = dictionary["classSection"];
                string fbGroupID = dictionary["facebookGroupId"];



                string[] listViewRow = { classID, className, classSection, fbGroupID };
                var listViewItem = new ListViewItem(listViewRow);
                classView.Items.Add(listViewItem);

            }
        }

        private void sectionTextBox_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                char[] textBoxChars = classSectionTextBox.Text.ToCharArray();
                
                foreach(char num in textBoxChars)
                {
                    if(!Char.IsDigit(num))
                    {
                        MessageBox.Show("You entered an invalid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        classSectionTextBox.Text = "001";
                        break;
                    }
                }
            }
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*Called when add button is clicked
         * Click of the add button To set up had to modify the ok button handle in ClassManager.Designer.cs added
         * this.okButton.Click += new System.EventHandler(this.OkBtn_click); to okButton section
         */
        private void addBTN_Click(object sender, EventArgs e)
        {
            try
            {
                int x = DataBaseManager.insertClass(this.classNameTextBox.Text, this.classSectionTextBox.Text, this.fbGroupIdTextBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            ClassManager_Load(this, null);
        }

        private void DeleteBTN_Click(object sender, EventArgs e)
        {
            if (classView.FocusedItem.Selected)
            {
                try
                {
                    DataBaseManager.deleteClass(classView.SelectedItems[0].SubItems[2].Text);
                    ClassManager_Load(this, null);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if(classView.FocusedItem.Selected)
            {
                try
                {
                    string className = classNameTextBox.Text;
                    string classSection = classSectionTextBox.Text;
                    string fbGroupID = fbGroupIdTextBox.Text;
         

                    Class newClass = new Class(className, classSection, selectedClass.getClassID(), fbGroupID);
                    //Update from datablo!ase as

                    DataBaseManager.updateClass(newClass, selectedClass);
                    ClassManager_Load(this, null);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void classView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (classView.FocusedItem.Selected)
            {
                updateBTN.Enabled = true;
                DeleteBTN.Enabled = true;
                string classID = classView.FocusedItem.SubItems[0].Text;
                string className = classNameTextBox.Text = classView.FocusedItem.SubItems[1].Text;
                string classSection = classSectionTextBox.Text = classView.FocusedItem.SubItems[2].Text;
                string fbGroupID = fbGroupIdTextBox.Text = classView.FocusedItem.SubItems[3].Text;
                

                selectedClass = new Class(className, classSection, classID, fbGroupID);
            }
            else
            {
                updateBTN.Enabled = false;
                DeleteBTN.Enabled = false;

                classNameTextBox.Clear();
                classSectionTextBox.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
