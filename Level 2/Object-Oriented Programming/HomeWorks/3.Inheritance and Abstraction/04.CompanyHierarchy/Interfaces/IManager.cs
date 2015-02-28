using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy.Interfaces
{
    interface IManager
    {
        ISet<Employee> ListOfEmployees { get; set; }

        void addEmployee(ISet<Employee> employees);

        string ToString();
    }
}
