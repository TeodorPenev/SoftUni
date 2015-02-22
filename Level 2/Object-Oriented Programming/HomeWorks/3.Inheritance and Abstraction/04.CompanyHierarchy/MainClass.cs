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
            Employee Tedy = new Employee("115033","Teodor","Penev",800,Department.Production);
            Console.WriteLine(Tedy.Department);  
        }
    }
}
