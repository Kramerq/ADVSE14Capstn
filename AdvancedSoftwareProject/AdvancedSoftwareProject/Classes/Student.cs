using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedSoftwareProject.Classes
{
    public class Student
    {
        private string ID;
        private string fName;
        private string lName;
        private string email;
        private string classID;

        public Student(string ID, string fName, string lName, string email, string classID)
        {
            this.ID = ID;
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.classID = classID;
        }

        public string getID()
        {
            return this.ID;
        }

        public string getFName()
        {
            return this.fName;
        }

        public string getLName()
        {
            return this.lName;
        }

        public string getEmail()
        {
            return this.email;
        }

        public string getClassID()
        {
            return this.classID;
        }
    }
}
