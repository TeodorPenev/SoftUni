using System;

namespace _01.School
{
    class Disciplines
    {
        private string name;
        private int numOfDisciplines;
        private Student student;
        private string details;

        public Disciplines(string name, int numOfDisciplines, Student student, string details)
        {
            Name = this.name;
            NumOfDisciplines = this.numOfDisciplines;
            _student = this.student;
            Details = this.details;
        }

        public string Name
        {
            get { return this.name; }
            set { value = this.name; }
        }

        public int NumOfDisciplines
        {
            get { return this.numOfDisciplines; }
            set { value = this.numOfDisciplines; }
        }

        public Student _student
        {
            get { return this.student; }
            set { value = this.student; }
        }

        public string Details
        {
            get { return this.details; }
            set { value = this.details; }
        }
    }
}
