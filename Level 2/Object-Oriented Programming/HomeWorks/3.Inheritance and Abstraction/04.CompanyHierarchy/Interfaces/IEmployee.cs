using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy.Interfaces
{
    interface IEmployee
    {
        double Salary { get; set; }
        Department Department { get; set; }
        string ToString();
    }
}
