using System.Collections.Generic;
using _04.CompanyHierarchy.Interfaces;

namespace _04.CompanyHierarchy.Models
{
    class Developer:Employee,IDeveloper
    {
        private ISet<Project> project;  

        public Developer(string id, string firstName, string lastName, double salary, Department department,ISet<Project> project ) : base(id, firstName, lastName, salary, department)
        {
            this.project = project;
        }

        public ISet<Project> Project
        {
            get { return this.project; }
            set { this.project = value; }
        }
    }
}
