using System.Collections.Generic;
using _04.CompanyHierarchy.Models;

namespace _04.CompanyHierarchy.Interfaces
{
    interface IDeveloper
    {
        ISet<Project> Project { get; set; } 
    }
}
