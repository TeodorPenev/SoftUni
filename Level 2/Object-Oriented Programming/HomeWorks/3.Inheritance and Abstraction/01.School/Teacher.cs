using System;
using System.Collections.Generic;

namespace _01.School
{
    class Teacher : People
    {
        private List<string> disciplines;

        public Teacher(string name,List<string> disciplines,string details) : base(name,details)
        {
            Disciplines = this.disciplines;
        }

        public List<string> Disciplines
        {
            get { return disciplines; }
            set { disciplines = value; }
        }
    }
}
