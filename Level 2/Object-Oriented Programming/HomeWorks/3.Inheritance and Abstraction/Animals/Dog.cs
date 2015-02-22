using System;
using System.Globalization;

namespace Animals
{
       class Dog:Animal,ISound
       {
           public Dog(string name,byte age,string gender) : base(name,age,gender)
           {
               
           }

           public string ProduceSound()
           {
               string voice="Baaay";
               return voice;
           }
       }
}
