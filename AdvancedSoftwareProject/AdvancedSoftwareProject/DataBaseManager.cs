using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftwareProject
{
    class DataBaseManager
    {

        public struct errorInfo
        {
            public System.Data.SqlClient.SqlException returnedError;
        }

        //Insert Values into Classes database
        public static int insertClass(string className, string classSect)
        {
            DatabaseDataSetTableAdapters.ClassesTableAdapter classes = new DatabaseDataSetTableAdapters.ClassesTableAdapter();
            int x = classes.InsertQuery(className, classSect);
            Console.WriteLine("Class Section Passed Was: "+ classSect);
            Console.WriteLine("Total Entries in Classes= " + classes.ScalarQuery().ToString());
            return x;
        }

        public static bool insertStudent(string ID, string fName, string lName, string email, out errorInfo err)
        {
            DatabaseDataSetTableAdapters.StudentsTableAdapter students = new DatabaseDataSetTableAdapters.StudentsTableAdapter();
            try
            {
                students.InsertQuery(ID, fName, lName, email, "100");
            }
            catch(System.Data.SqlClient.SqlException e)
            {
                err.returnedError = e;
                return false;
            }

            err.returnedError = null;
            return true;
        }

    }
}
