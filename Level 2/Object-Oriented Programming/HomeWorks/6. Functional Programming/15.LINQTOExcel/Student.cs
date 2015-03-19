using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15.LINQTOExcel
{
    class Student
    {
        public Student(int id, string firstName, string lastName, string email, string gender, string studentType, int examResult, int homeWorkSent, int homeWorkEvaluated, double teamWorkScore, int attendances, double bonus,double result=0)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Gender = gender;
            StudentType = studentType;
            ExamResult = examResult;
            HomeWorkSent = homeWorkSent;
            HomeWorkEvaluated = homeWorkEvaluated;
            TeamWorkScore = teamWorkScore;
            Attendances = attendances;
            Bonus = bonus;
            Result = result;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string StudentType { get; set; }
        public int ExamResult { get; set; }
        public int HomeWorkSent { get; set; }
        public int HomeWorkEvaluated { get; set; }
        public double TeamWorkScore { get; set; }
        public int Attendances { get; set; }
        public double Bonus { get; set; }
        public double Result { get; set; }

        public static double CalculateResult(int examResult, int hWSent, int hWEvaluated, double teamWork, int attendances,
            double bonus)
        {
            double result = (examResult + hWSent + hWEvaluated + teamWork + attendances + bonus) / 5;
            return result;
        }
    }
}
