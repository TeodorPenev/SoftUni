using System;
using _04.CompanyHierarchy.Models;

namespace _04.CompanyHierarchy.Interfaces
{
    interface IProjects
    {
        string Name { get; set; }
        DateTime Start { get; set; }
        string Details { get; set; }
        State States { get; set; }

        void CloseProject();
    }
}
