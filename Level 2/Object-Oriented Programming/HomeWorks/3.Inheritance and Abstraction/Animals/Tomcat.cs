using System;

namespace Animals
{
    class Tomcat:Cat,ISound
    {
        public Tomcat(string name,byte age):base(name,age,"male")
        {
            
        }

        public string ProduceSound()
        {
            string voice = "MQl";
            return voice;
        }
    }
}
