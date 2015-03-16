using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _03.ClassStudent;

namespace _11.WeakStudents
{
    class WeakStudents
    {
        static void Main(string[] args)
        {
            var result01 = Student.students.FullExtractExactly(6, 4);

            foreach (var student in result01)
            {
                Console.WriteLine(student);
            }

            List<int> ddd = new List<int>();


            var result02 = Student.students
                .FindAll(x => x.Marks.ContainCount(2, 2));

            foreach (var student in result02)
            {
                Console.WriteLine(student);
            }
        }
    }
}
