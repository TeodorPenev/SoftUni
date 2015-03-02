using System;
using System.Collections.Generic;
using _04.CompanyHierarchy.Models;

namespace _04.CompanyHierarchy
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ISet<Employee> employees = new HashSet<Employee>();

            Employee Tedy = new Employee("115033", "Teodor", "Penev", 800, Department.Production);
            Console.WriteLine(Tedy.Department);
            Employee Dani = new Employee("115033", "Teodor", "Penev", 800, Department.Production);
            employees.Add(Tedy);
            employees.Add(Dani);
            Manager Teo = new Manager("115033", "Teodor", "Penev", 800, Department.Accounting, employees);
            Console.WriteLine(Teo);
            ISet<Sale> saaale =new HashSet<Sale>();
            Sale first = new Sale("FirstOne", new DateTime(1111, 2, 11), 12);
            Sale second = new Sale("SecondOne", new DateTime(1100, 2, 11), 12);
            saaale.Add(first);
            saaale.Add(second);

           
            Employee Dani1 = new Employee("ddgfg0","ddd","d",22,Department.Marketing);
            SalesEmployee Cveti = new SalesEmployee("des1wd", "dsfsd", "fdsfd", 212, Department.Marketing, saaale);

            foreach (var sale in saaale)
            {
                Console.WriteLine(sale.ProductName);
            }

            ISet<Project> starShips =new HashSet<Project>();
            Project alpha = new Project("StarShips",new DateTime(2015,1,15),"Some fantastic RPG",State.open);
            Project beta = new Project("StarShips", new DateTime(2015, 2, 20), "Some fantastic RPG gone wild", State.close);
            starShips.Add(alpha);
            starShips.Add(beta);
            Developer Tedo = new Developer("115018","Teodor","Penev",1500,Department.Production,starShips);
            
        }
    }
}
