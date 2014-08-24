using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AdvancedSoftwareProject.Classes;

namespace AdvancedSoftwareProject.Forms
{
    public partial class StudentManager : Form
    {
        List<Class> classList = new List<Class>();

        Student selectedStudent;
        Class selectedClass;
        

        //Constructor for when the an object is created of type
        //StudentManager
        public StudentManager()
        {
            InitializeComponent();
        }

        //Called when once everything is initialized and the
        //form is told to display.
        private void StudentManager_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.databaseDataSet.Classes);
            studentLV.Items.Clear();
            updateBTN.Enabled = false;
            deleteBTN.Enabled = false;

            List<Dictionary<string, string>> classData = DataBaseManager.getClasses();
            foreach (var dictionary in classData)
            {
                string className = dictionary["className"];
                string classSection = dictionary["classSection"];
                string classID = dictionary["classID"];
                string fbGroupID = dictionary["facebookGroupId"];

                Class newClass = new Class(className, classSection, classID, fbGroupID);
                classList.Add(newClass);
                classComboBox.Items.Add(className + "-" + classSection);

            }    
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            if(IdTB.Text.Length > 0 && FNameTB.Text.Length > 0 && LNameTB.Text.Length > 0 && emailTB.Text.Length > 0)
            {

                string providedClassID = classList[classComboBox.SelectedIndex].getClassID();
                DataBaseManager.errorInfo eI = new DataBaseManager.errorInfo();
                if (!DataBaseManager.insertStudent(IdTB.Text, FNameTB.Text, LNameTB.Text, emailTB.Text, providedClassID, out eI))
                {
                    MessageBox.Show(eI.returnedError.Message, eI.returnedError.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    IdTB.Clear();
                    
                }
                else
                {
                    populateStudentsListView();
                }

            }
            else
            {
                MessageBox.Show("You are missing some important information!", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            if (studentLV.FocusedItem.Selected)
            {
                try
                {
                    string ID = IdTB.Text;
                    string fName = FNameTB.Text;
                    string lName = LNameTB.Text;
                    string email = emailTB.Text;
                    string classID = selectedStudent.getClassID();

                    Student newStudent = new Student(ID, fName, lName, email, classID);
                    //Update in database also!

                    DataBaseManager.updateStudent(newStudent, selectedStudent);
                    populateStudentsListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if(studentLV.FocusedItem.Selected)
            {
                DataBaseManager.deleteStudent(studentLV.SelectedItems[0].SubItems[0].Text);
                populateStudentsListView();

                IdTB.Clear();
                FNameTB.Clear();
                LNameTB.Clear();
                emailTB.Clear();
                notesTB.Clear();
            }
        }

        private void doneBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void importBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog csvDialog = new OpenFileDialog();

            //Variables to capture student data;
            string csvLine, firstName, lastName, email, notes, studentID;

            string[] lineElements;

            csvDialog.CheckFileExists = true;
            csvDialog.Filter = "CSV File (*.csv)|*.csv";
            
            try
            {
                if (csvDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamReader csvFileStream = new StreamReader(csvDialog.OpenFile());
                    DataBaseManager.errorInfo eI = new DataBaseManager.errorInfo();

                    if (csvFileStream != null)
                    {
                        csvLine = csvFileStream.ReadLine();
                        while (csvLine != null)
                        {
                            lineElements = csvLine.Split(new Char[] { ',' });//Splits the line into seperate strings according to array param elements

                            if (lineElements.Length < 4)//Make sure we have enough data to properly populate database
                            {
                                MessageBox.Show("The CSV couldn't be parsed correctly.\nYou imported a file with " + lineElements.Length + " values, you need at least 4.\nYou must inlcude Student ID, First Name, Last Name, and E-mail.", "CSV Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }

                            studentID = lineElements[0];

                            if(studentID.StartsWith("#"))
                                studentID = studentID.TrimStart('#');

                            studentID = studentID.Remove(0, 2);


                            firstName = lineElements[1];
                            lastName = lineElements[2];
                            email = lineElements[3];

                            if (lineElements.Length == 5)
                            {
                                notes = lineElements[4];
                                //Insert into database query with all elements
                            }
                            else if(lineElements.Length == 4)
                            {
                                //Insert into database query without notes
                                string providedClassID = classList[classComboBox.SelectedIndex].getClassID();
                                if (!DataBaseManager.insertStudent(studentID, firstName, lastName, email, providedClassID, out eI))
                                {
                                    MessageBox.Show(eI.returnedError.Message, eI.returnedError.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }

                                populateStudentsListView();
                            }

                            csvLine = csvFileStream.ReadLine();
                        }
                    }

                    csvFileStream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentLV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (studentLV.FocusedItem != null)
            {
                if (studentLV.FocusedItem.Selected)
                {
                    updateBTN.Enabled = true;
                    deleteBTN.Enabled = true;

                    string ID = IdTB.Text = studentLV.FocusedItem.SubItems[0].Text;
                    string fName = FNameTB.Text = studentLV.FocusedItem.SubItems[1].Text;
                    string lName = LNameTB.Text = studentLV.FocusedItem.SubItems[2].Text;
                    string email = emailTB.Text = studentLV.FocusedItem.SubItems[3].Text;
                    string classID = selectedClass.getClassID();

                    selectedStudent = new Student(ID, fName, lName, email, classID);

                }
                else
                {
                    updateBTN.Enabled = false;
                    deleteBTN.Enabled = false;

                    clearStudentTextBoxes();
                }
            }
        }

        private void studentLV_Click(object sender, EventArgs e)
        {

        }

        private void classComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = classComboBox.SelectedIndex;
            selectedClass = classList[index];
            populateStudentsListView();
            clearStudentTextBoxes();

        }

        private void populateStudentsListView()
        {
            List<Dictionary<string, string>> studentData = DataBaseManager.getStudentsByClassID(selectedClass.getClassID());
            studentLV.Items.Clear();
            foreach (var dictionary in studentData)
            {
                string ID = dictionary["ID"];
                string fName = dictionary["fName"];
                string lName = dictionary["lName"];
                string email = dictionary["email"];
                string classID = dictionary["classID"];

                string[] listViewRow = { ID, fName, lName, email };
                var listViewItem = new ListViewItem(listViewRow);
                studentLV.Items.Add(listViewItem);
            }
        }

        private void clearStudentTextBoxes()
        {
            IdTB.Clear();
            FNameTB.Clear();
            LNameTB.Clear();
            emailTB.Clear();
            notesTB.Clear();
        }
    }
}
