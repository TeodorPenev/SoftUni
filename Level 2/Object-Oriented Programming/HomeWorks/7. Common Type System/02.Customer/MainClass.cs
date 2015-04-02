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
            Customer Tedy = new Customer("Teodor","Georgiev","Penev",8701151465,"Rila 12",0895761847,"t.g.penev@gmail.com",new List<Payment>(){new Payment("small",250m),new Payment("medium",330m)},CustomerType.Diamond);
            Customer Dani = new Customer("Daniel", "Georgiev", "Penev", 8501151465, "Rila 10", 0895761847, "d.g.penev@gmail.com", new List<Payment>() { new Payment("medium", 350m) }, CustomerType.Golden); 

            bool test1 = Tedy.Equals(Dani);
            Console.WriteLine(test1);

            bool test2 = Tedy != Dani;
            Console.WriteLine(test2);

            Console.WriteLine(Tedy);
        }
    }
}
