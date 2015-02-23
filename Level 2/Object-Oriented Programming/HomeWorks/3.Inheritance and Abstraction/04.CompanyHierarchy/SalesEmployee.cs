using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    class SalesEmployee:RegularEmployee
    {
        public List<sale> sales { get; set; }

        
        public SalesEmployee(string id, string firstName, string lastName, double salary, Department department) : base(id, firstName, lastName, salary, department)
        {
        }
    }
}
