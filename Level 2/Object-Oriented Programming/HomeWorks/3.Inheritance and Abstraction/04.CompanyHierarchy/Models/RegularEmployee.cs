using System;

namespace _04.CompanyHierarchy
{
    class RegularEmployee:Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, double salary, Department department) : base(id,firstName,lastName,salary,department)
        {
            
        }
    }
}
