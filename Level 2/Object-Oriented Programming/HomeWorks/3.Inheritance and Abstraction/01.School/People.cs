using System;

namespace _01.School
{
    class People
    {
        private string name;
        private string details;

        public People(string name, string details=null)
        {
            Name = this.name;
            Details = this.details;
        }

        public string Name
        {
            get { return this.name; }
            set { value = this.name; }
        }

        public string Details
        {
            get { return this.details; }
            set { value = this.details; }
        }
    }
}
