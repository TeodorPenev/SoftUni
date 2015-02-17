using System;
using System.Collections.Generic;

namespace _01.School
{
    class Class
    {
        public string uniqueIdentifier;
        public List<string> teachers;
        public string details;

        public Class(string uniqueIdentifier,List<string> teachers,string details=null)
        {
            this.uniqueIdentifier = uniqueIdentifier;
            this.teachers = teachers;
            this.details = details;
        }

        public override string ToString()
        {
            string result = String.Format("Test {0} {1} {2}", this.uniqueIdentifier, this.teachers[1], this.details);
            return result;
        }
    }
}
