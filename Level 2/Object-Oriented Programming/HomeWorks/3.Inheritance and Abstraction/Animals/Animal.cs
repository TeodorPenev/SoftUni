using System;

namespace Animals
{
    abstract class Animal
    {
        public string name;
        public byte age;
        public string gender;

        public Animal(string name, byte age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public byte Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public string Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
    }
}
