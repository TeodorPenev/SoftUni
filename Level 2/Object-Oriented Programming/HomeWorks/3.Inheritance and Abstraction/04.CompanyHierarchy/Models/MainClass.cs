using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CompanyHierarchy
{
    class MainClass
    {
        static void Main(string[] args)
        {
            ISet<Employee> employees = new ISet<Employee>();

            Employee Tedy = new Employee("115033","Teodor","Penev",800,Department.Production);
            Console.WriteLine(Tedy.Department);
            Employee Dani = new Employee("115033", "Teodor", "Penev", 800, Department.Production);
            employees.Add(Tedy);
            employees.Add(Dani);
            Manager Teo = new Manager("115033", "Teodor", "Penev", 800, Department.Accounting,employees);
            Console.WriteLine(Teo);

        }
    }
}
