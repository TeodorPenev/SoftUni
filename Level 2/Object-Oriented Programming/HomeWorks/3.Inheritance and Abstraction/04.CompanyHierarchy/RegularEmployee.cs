﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    class RegularEmployee:Employee
    {
        public RegularEmployee(string id, string firstName, string lastName, double salary, Department department) : base(id,firstName,lastName,salary,department)
        {
            
        }
    }
}
