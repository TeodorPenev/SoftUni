using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using _03.ClassStudent;

namespace _13.StudentsByGroups
{
    class StudentsByGroups
    {
        static void Main(string[] args)
        {
            var result =
                from student in Student.students
                group student by student.GroupName
                into newGroup
                select newGroup;

            foreach (var student in result)
            {
                Console.WriteLine("Group: {0}\n{1}",student.Key, String.Join(", ",student));
            }
        }
    }
}
