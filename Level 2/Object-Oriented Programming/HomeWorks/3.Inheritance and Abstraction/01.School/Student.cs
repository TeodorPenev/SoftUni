using System;

namespace _01.School
{
    class Student : People
    {
        private int uniqueClassNumber;

        public Student(string name, int uniqueClassNumber, string details) : base(name, details)
        {
            UniqueClassNumber = this.uniqueClassNumber;
        }

        public int UniqueClassNumber
        {
            get { return uniqueClassNumber; }
            set { uniqueClassNumber = value; }
        }
    }
}
