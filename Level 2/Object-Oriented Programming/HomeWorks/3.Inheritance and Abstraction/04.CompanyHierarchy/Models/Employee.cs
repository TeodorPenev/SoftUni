using System;
using System.Text;
using _04.CompanyHierarchy.Interfaces;

namespace _04.CompanyHierarchy
{
    class Employee:Person,IEmployee
    {
        private double salary;

        public Employee(string id, string firstName, string lastName, double salary, Department department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        public double Salary
        {
            get { return this.salary; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException("The salary value cannot be negative");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendFormat("Department: {0}\nSalary: {1}\n", this.Department, this.Salary);

            return result.ToString();
        }
    }
}
