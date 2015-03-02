using System;
using System.Text;
using _04.CompanyHierarchy.Interfaces;

namespace _04.CompanyHierarchy.Models
{
    class Project:IProjects
    {
        private string name;
        private DateTime start;
        private string details;
        private State state;

        public Project(string name, DateTime start, string details, State state)
        {
            this.Name = name;
            this.Start = start;
            this.Details = details;
            this.States = State.open;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public DateTime Start
        {
            get { return this.start; }
            set { this.start = value; }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public State States
        {
            get { return this.state; }
            set { this.state = value; }
        }

        public void CloseProject()
        {
            this.state = State.close;
        }

             public override string ToString()
        {
            StringBuilder result = new StringBuilder(base.ToString());
            result.AppendFormat("Project name: {0}\nStart date: {1}\nDetails: {2}\nProject State: {3}", this.name, this.start, this.details, this.state);

            return result.ToString();
        }
    }
}
