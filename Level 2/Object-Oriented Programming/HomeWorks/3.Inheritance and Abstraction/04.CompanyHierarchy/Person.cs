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
        private string ID { get; set; }
        private string FirstName { get; set;}
        private string LastName { get; set; }

        public Person(string id,string firstName,string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}
