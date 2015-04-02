using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Customer
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Customer Tedy = new Customer("A","Georgiev","Penev",8701151465,"Rila 12",0895761847,"t.g.penev@gmail.com",new List<Payment>(){new Payment("small",250m),new Payment("medium",330m)},CustomerType.Diamond);
            Customer Dani = new Customer("A", "Georgiev", "Penev", 8501151465, "Rila 10", 0895761847, "d.g.penev@gmail.com", new List<Payment>() { new Payment("medium", 350m) }, CustomerType.Golden);
            Customer Desi = new Customer("A", "Georgiev", "Penev", 9201151465, "Rila 10", 0895761847, "d.g.penev@gmail.com", new List<Payment>() { new Payment("medium", 350m) }, CustomerType.Golden);

            bool test1 = Tedy.Equals(Dani);
            Console.WriteLine(test1);

            Console.WriteLine("\n");

            bool test2 = Tedy != Dani;
            Console.WriteLine(test2);

            Console.WriteLine("\n");

            Console.WriteLine(Tedy);

            Console.WriteLine("\n");

            Customer Sisi = Dani.Clone();
            Console.WriteLine(Sisi);

            Console.WriteLine("\n");

            List<Customer> custs = new List<Customer>() { Desi, Tedy, Dani };
            custs.Sort();

            foreach (var customer in custs)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
