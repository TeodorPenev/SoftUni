using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Laptop_Shop
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter model:");
            string model = Console.ReadLine();
            Console.WriteLine("Enter manufacturer:");
            string manufacturer = Console.ReadLine();
            Console.WriteLine("Enter Processor:");
            string processor = Console.ReadLine();
            Console.WriteLine("Enter RAM:");
            int ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Graphics Card:");
            string graphicsCard = Console.ReadLine();
            Console.WriteLine("Enter HDD:");
            string hdd = Console.ReadLine();
            Console.WriteLine("Enter Screen:");
            string screen = Console.ReadLine();
            Console.WriteLine("Enter Battery:");
            string battery = Console.ReadLine();
            Console.WriteLine("Enter Battery Life:");
            int batteryLife = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            
            Laptop test = new Laptop(model, price, new Battery(battery,batteryLife),manufacturer, processor, ram, graphicsCard, hdd, screen );
            Console.WriteLine(test);
        }
    }
}
