using System;

namespace _04.CompanyHierarchy.Interfaces
{
    interface IEmployee
    {
        double Salary { get; set; }
        Department Department { get; set; }
        string ToString();
    }
}
