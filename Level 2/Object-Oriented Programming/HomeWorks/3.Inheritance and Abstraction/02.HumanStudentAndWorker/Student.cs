using System;

namespace _02.HumanStudentAndWorker
{
    class Student:Human
    {
        private string faultyNumber;

        public Student(string firstName, string lastName, string faultyNumber) : base(firstName, lastName)
        {
            this.FaultyNumber = faultyNumber;
        }

        public string FaultyNumber
        {
            get { return this.faultyNumber; }
            set
            {
                if (value.Length<4 || value.Length>9)
                {
                    throw new ArgumentOutOfRangeException("The faulty number got to be in range 5-10 digits / letters");
                }
                this.faultyNumber = value;
            }
        }
    }
}
