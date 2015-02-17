using System;
using System.Collections.Generic;

namespace _01.School
{
    class MainClass
    {
        public static void Main()
        {
           Student student1 = new Student("Teodor", 115066, "dreamer");
           Student student2 = new Student("Daniel", 114322, "ambicious");

           Teacher teacher1 = new Teacher("Kraeva",new List<string>(){"Business Informatics","The theoretical basis of the information society"},"dean");
           Teacher teacher2 = new Teacher("Vurbanov",new List<string>(){"Оperating Systems ","Computing networks"},"...it's OK");

          Disciplines bInfo = new Disciplines("Business Informatics",1,student1,"none");
          Disciplines compNet = new Disciplines("Computing networks",1,student2,"none");

          Class group26 = new Class("da112233",new List<Teacher>(){teacher1,teacher2},"The group with hightest exam score!");

        }
    }
}
