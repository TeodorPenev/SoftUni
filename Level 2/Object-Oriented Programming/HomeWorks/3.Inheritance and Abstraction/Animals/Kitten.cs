using System;

namespace Animals
{
    class Kitten:Cat,ISound
    {
        public Kitten(string name,byte age):base(name,age,"female")
        {
            
        }

        public string ProduceSound()
        {
            string voice = "mmmiiiqqqlll";
            return voice;
        }
    }
}
