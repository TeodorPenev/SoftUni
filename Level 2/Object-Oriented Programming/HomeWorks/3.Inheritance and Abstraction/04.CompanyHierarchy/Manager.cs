using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    class Manager:Employee
    {
        public List<Employee> listOfEmployee =new List<Employee>();

        public Manager(string id,string firstName,string lastName,double salary,Department department,List<Employee> listOfEmployees):base(id,firstName,lastName,salary,department)
        {
            this.listOfEmployee = listOfEmployees;
        }
    }
}
