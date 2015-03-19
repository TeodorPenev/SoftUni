using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace _15.LINQTOExcel
{
    class MainClass
    {
        private static void Main(string[] args)
        {
            string[] lines =
                System.IO.File.ReadAllLines(
                    @"D:\Documents\GitHub Depo\SoftUni\Level 2\Object-Oriented Programming\HomeWorks\Аssignments\6. Functional-Programming-Homework\Students-data.txt");

            List<Student> students = new List<Student>();

            for (int i = 1; i < lines.Length; i++)
            {
                string[] data = lines[i].Split('\t');

                double result = Student.CalculateResult(int.Parse(data[6]), int.Parse(data[7]), int.Parse(data[8]),
                    double.Parse(data[9]), int.Parse(data[10]), double.Parse(data[11]));
                Student temp = new Student(int.Parse(data[0]), data[1], data[2], data[3], data[4], data[5],
                    int.Parse(data[6]), int.Parse(data[7]), int.Parse(data[8]), double.Parse(data[9]),
                    int.Parse(data[10]), double.Parse(data[11]), result);
                students.Add(temp);
            }


            var onlineStud = students.FindAll(x => x.StudentType == "Online").OrderBy(r => r.Result);

            CreateExcelDoc report = new CreateExcelDoc();

            for (int i = 2; i < onlineStud.Count(); i++)
            {
                for (int j = 1; j < 14; j++)
                {
                    report.addData(i, j, "Hello");
                }
            }

        }
    }
}
