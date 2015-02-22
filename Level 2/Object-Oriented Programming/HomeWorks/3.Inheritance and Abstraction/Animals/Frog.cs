using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Frog:Animal,ISound
    {
        public Frog(string name,byte age,string gender) : base(name,age,gender)
        {
            
        }

        public string ProduceSound()
        {
            string voice = "Kvaaak";
            return voice;
        }
    }
}
