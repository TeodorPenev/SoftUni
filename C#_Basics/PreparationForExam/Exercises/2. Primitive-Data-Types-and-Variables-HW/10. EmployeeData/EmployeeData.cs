//Problem 10.	Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//•	First name
//•	Last name
//•	Age (0...100)
//•	Gender (m or f)
//•	Personal ID number (e.g. 8306112507)
//•	Unique employee number (27560000…27569999)

using System;

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string lastName = "Ivanov";
            byte age = 40;
            char gender = 'm';
            string pID = "7406112507";
            int uEN = 27560000;
            Console.WriteLine("First name : " + firstName);
            Console.WriteLine("Last name  : " + lastName);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Personal ID number : " + pID);
            Console.WriteLine("Unique employee number :  " + uEN);
        }
    }

