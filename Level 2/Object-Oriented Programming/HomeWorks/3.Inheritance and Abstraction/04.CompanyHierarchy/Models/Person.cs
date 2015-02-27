using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    class Person
    {
        public string ID { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }

        public Person(string id,string firstName,string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
