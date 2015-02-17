using System;
using System.Collections.Generic;

namespace _01.School
{
    class Class
    {
        private string uniqueIdentifier;
        public List<Teacher> teachers;
        public string details;

        public Class(string uniqueIdentifier,List<Teacher> teachers,string details=null)
        {
            this.UniqueIdentifier = uniqueIdentifier;
            this.Teachers = teachers;
            this.Details = details;
        }

        public string UniqueIdentifier
        {
            get { return this.uniqueIdentifier; }
            set { value = this.uniqueIdentifier; }
        }

        public List<Teacher> Teachers
        {
            get { return this.teachers; }
            set { value = this.teachers; }
        }

        public string Details
        {
            get { return this.details; }
            set { value = this.details; }
        }      
    }
}
