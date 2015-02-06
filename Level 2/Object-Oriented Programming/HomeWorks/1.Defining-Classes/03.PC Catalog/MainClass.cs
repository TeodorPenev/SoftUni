using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PC_Catalog
{
    class MainClass
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>();

            Computer Lenovo = new Computer("LenovoG500",new Component("Nvidia 780",300),new Component("Monitor","Matrix IPS 17\"",200),new Component("HDD","SSD Hybrid 500GB",250), new Component("Ram","8GB 1600MHZ",80));

            Computer Acer = new Computer("Acer Ispire", new Component("Ati Radeon 6800", 200.20m), new Component("Monitor", "Matrix PN 17\"", 150), new Component("HDD", "SSD Hybrid 480GB", 250), new Component("Ram", "8GB 1600MHZ", 80));

            computers.Add(Lenovo);
            computers.Add(Acer);

            computers = computers.OrderBy(computer => computer.TotalPrice).ToList();

            foreach (Computer comp in computers)
            {
                Console.WriteLine("\n{0}",comp );
            }

        }
    }
}
