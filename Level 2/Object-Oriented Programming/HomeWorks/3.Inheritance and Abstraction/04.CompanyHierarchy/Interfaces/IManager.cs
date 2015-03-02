using System;
using System.Collections.Generic;

namespace _04.CompanyHierarchy.Interfaces
{
    interface IManager
    {
        ISet<Employee> ListOfEmployees { get; set; }

        void addEmployee(ISet<Employee> employees);

        string ToString();
    }
}
