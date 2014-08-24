using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AdvancedSoftwareProject.Forms;
using AdvancedSoftwareProject.Classes;

namespace AdvancedSoftwareProject
{
    class DataBaseManager
    {
        private static string connString = AdvancedSoftwareProject.Properties.Settings.Default.DatabaseConnectionString;
        //private static SqlConnection connection = new SqlConnection(connString);

        public struct errorInfo
        {
            public System.Data.SqlClient.SqlException returnedError;
        }

        //Insert Values into Classes database
        public static int insertClass(string className, string classSect, string fbGroupId)
        {
            DatabaseDataSetTableAdapters.ClassesTableAdapter classes = new DatabaseDataSetTableAdapters.ClassesTableAdapter();
            int x = classes.InsertQuery(className, classSect, fbGroupId);
            Console.WriteLine("Class Section Passed Was: "+ classSect);
            Console.WriteLine("Total Entries in Classes= " + classes.ScalarQuery().ToString());
            
            return x;
        }

        public static bool insertMessage(string classID, bool facebook, bool twitter, bool email, bool d2l, DateTime date, TimeSpan time, string subject, string content, out errorInfo err)
        {
            DatabaseDataSetTableAdapters.MessagesTableAdapter messages = new DatabaseDataSetTableAdapters.MessagesTableAdapter();

            try
            {
                messages.InsertQuery(Convert.ToInt32(classID), Convert.ToInt32(facebook), Convert.ToInt32(twitter), Convert.ToInt32(email), Convert.ToInt32(d2l), date.ToString(), time.ToString(), subject, content);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                err.returnedError = e;
                return false;
            }

            err.returnedError = null;
            return true;
        }

        public static bool insertStudent(string ID, string fName, string lName, string email, string classID, out errorInfo err)
        {
            DatabaseDataSetTableAdapters.StudentsTableAdapter students = new DatabaseDataSetTableAdapters.StudentsTableAdapter();

            try
            {
                students.InsertQuery(ID, fName, lName, email, classID);
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                err.returnedError = e;
                return false;
            }

            err.returnedError = null;
            return true;
        }


        public static List<Dictionary<string, string>> getClasses()
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "SELECT * FROM Classes";
            SqlCommand cmd = new SqlCommand(query, connection);

            List<Dictionary<string, string>> classData = new List<Dictionary<string, string>>();
            int count = 0;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                     
                    string classID = reader.GetInt32(0).ToString();
                    string className = reader.GetString(1);
                    string classSection = reader.GetString(2);
                    string fbGroupId = reader.GetString(3);

                    classData.Add(new Dictionary<string, string>());
                    classData[count].Add("classID", classID);
                    classData[count].Add("className", className);
                    classData[count].Add("classSection", classSection);
                    classData[count].Add("facebookGroupId", fbGroupId);
                    
                    count++;
                }
            }

            connection.Close();
            return classData;
        }

        public static Class getClassByID(string ID)
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "SELECT * FROM Classes WHERE classID="+ID;
            SqlCommand cmd = new SqlCommand(query, connection);


            string classID = "";
            string className = "";
            string classSection = "";
            string fbGroupId = "";

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    classID = reader.GetInt32(0).ToString();
                    className = reader.GetString(1);
                    classSection = reader.GetString(2);
                    fbGroupId = reader.GetString(3);
                    
                }
            }

            Class theClass = new Class(className, classSection, classID, fbGroupId);
            connection.Close();
            return theClass;
        }



        public static void updateClass(Class newClass,  Class oldClass)
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "UPDATE classes " +
                           "SET className = '" + newClass.getClassName() + "', " +
                           "classSection = '" + newClass.getClassSection() + "', " +
                           "facebookGroupId = '" + newClass.getFbGroupID() + "' " +
                           "WHERE classID = " + oldClass.getClassID() +";";

            Console.WriteLine("The update query is: "+query);

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void deleteClass(string classID)
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "DELETE FROM Classes WHERE ClassID=" + classID;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            query = "DELETE FROM Students WHERE ClassID=" + classID;
            cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }
        
        public static List<Dictionary<string, string>> getStudents()
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(query, connection);

            List<Dictionary<string, string>> studentData = new List<Dictionary<string, string>>();
            int count = 0;

            using(SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string ID = reader.GetString(0);
                    string fName = reader.GetString(1);
                    string lName = reader.GetString(2);
                    string email = reader.GetString(3);
                    string classID = reader.GetString(4);

                    studentData.Add(new Dictionary<string, string>());
                    studentData[count].Add("ID", ID);
                    studentData[count].Add("fName", fName);
                    studentData[count].Add("lName", lName);
                    studentData[count].Add("email", email);
                    studentData[count].Add("classID", classID);

                    count++;
                }
            }

            connection.Close();
            return studentData;
        }

        public static List<Dictionary<string, string>> getStudentsByClassID(string providedClassID)
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "SELECT * FROM Students WHERE classID="+providedClassID;
            SqlCommand cmd = new SqlCommand(query, connection);

            List<Dictionary<string, string>> studentData = new List<Dictionary<string, string>>();
            int count = 0;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string ID = reader.GetString(0);
                    string fName = reader.GetString(1);
                    string lName = reader.GetString(2);
                    string email = reader.GetString(3);
                    string classID = reader.GetString(4);

                    studentData.Add(new Dictionary<string, string>());
                    studentData[count].Add("ID", ID);
                    studentData[count].Add("fName", fName);
                    studentData[count].Add("lName", lName);
                    studentData[count].Add("email", email);
                    studentData[count].Add("classID", classID);

                    count++;
                }
            }

            connection.Close();
            return studentData;
        }

        public static void deleteStudent(string studentID)
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "DELETE FROM Students WHERE ID=" + studentID;
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static void updateStudent(Student newStudent, Student oldStudent)
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "UPDATE students " +
                           "SET ID = '" + newStudent.getID() + "', " +
                           "FirstName = '" + newStudent.getFName() + "', " +
                           "LastName = '" + newStudent.getLName() + "', " +
                           "Email = '" + newStudent.getEmail() + "', " +
                           "ClassID = '" + newStudent.getClassID() +"' "+
                           "WHERE ID = '" +oldStudent.getID() +"' AND classID = '" + oldStudent.getClassID() + "';";

            Console.WriteLine("The update query is: " + query);

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();

            connection.Close();
        }

        //TODO fix this it is broken
        public static List<Dictionary<string, string>> getMessages()
        {
            SqlConnection connection = new SqlConnection(connString);

            connection.Open();

            string query = "SELECT * FROM Messages";
            SqlCommand cmd = new SqlCommand(query, connection);

            List<Dictionary<string, string>> messageData = new List<Dictionary<string, string>>();
            int count = 0;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string classID = reader.GetInt32(1).ToString();
                    string facebook = reader.GetInt32(2).ToString();
                    string twitter = reader.GetInt32(3).ToString();
                    string email = reader.GetInt32(4).ToString();
                    string D2L = reader.GetInt32(5).ToString();
                    string date = reader.GetDateTime(6).ToString("MM/dd/yyyy");
                    DateTime tempTime = DateTime.Today.Add(reader.GetTimeSpan(7));
                    string time = tempTime.ToString("hh:mm tt");
                    string subject = reader.GetString(8);
                    string content = reader.GetString(9);

                    messageData.Add(new Dictionary<string, string>());
                    messageData[count].Add("classID", classID);
                    messageData[count].Add("facebook", facebook);
                    messageData[count].Add("twitter", twitter);
                    messageData[count].Add("email", email);
                    messageData[count].Add("d2l", D2L);
                    messageData[count].Add("date", date);
                    messageData[count].Add("time", time);
                    messageData[count].Add("subject", subject);
                    messageData[count].Add("content", content);

                    count++;
                }
            }

            connection.Close();
            return messageData;
        }

        public static void clearMessages()
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            string query = "DELETE FROM Messages";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }
    }
}
