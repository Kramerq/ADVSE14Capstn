using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdvancedSoftwareProject.Forms
{
    class Class
    {
        private string className;
        private string classSection;
        private string classID;
        private string fbGroupID;

        public Class(string className, string classSection, string classID, string fbGroupID)
        {
            this.className = className;
            this.classSection = classSection;
            this.classID = classID;
            this.fbGroupID = fbGroupID;

        }

        public string getClassID()
        {
            return this.classID;
        }

        public string getClassName()
        {
            return this.className;
        }

        public string getClassSection()
        {
            return this.classSection;
        }

        public string getFbGroupID()
        {
            return this.fbGroupID;
        }
    }
}