using System;

namespace _04.CompanyHierarchy
{
    class Employee:Person
    {
        public double Salary { get; set; }
        public Department Department { get; set; }

        public Employee(string id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }
    }
}
