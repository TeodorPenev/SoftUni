using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using _04.CompanyHierarchy.Interfaces;

namespace _04.CompanyHierarchy
{
    class Manager:Employee,IManager
    {
        public Manager(string id,string firstName,string lastName,double salary,Department department,ISet<Employee> listOfEmployees):base(id,firstName,lastName,salary,department)
        {
            this.ListOfEmployees = listOfEmployees;
        }

        public ISet<Employee> ListOfEmployees { get; set; }
        
        public void addEmployee(ISet<Employee> employees )
        {
            foreach (var employee in employees)
            {
                this.ListOfEmployees.Add(employee);
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendFormat("Employees to manage: {0}\n", this.ListOfEmployees.Count);

            return result.ToString();
        }
    }
}
