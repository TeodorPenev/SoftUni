using System.Collections.Generic;
using _04.CompanyHierarchy.Interfaces;
using _04.CompanyHierarchy.Models;

namespace _04.CompanyHierarchy
{
    class SalesEmployee:RegularEmployee,ISaleEmployee
    {
        private ISet<Sale> listOfSales; 
        
        public SalesEmployee(string id, string firstName, string lastName, double salary, Department department, ISet<Sale> listOfSales) : base(id, firstName, lastName, salary, department)
        {
            ListOfSales = listOfSales;
        }

        public ISet<Sale> ListOfSales
        {
            get { return this.listOfSales; }
            set { this.listOfSales = value; }
        }
    }
}
