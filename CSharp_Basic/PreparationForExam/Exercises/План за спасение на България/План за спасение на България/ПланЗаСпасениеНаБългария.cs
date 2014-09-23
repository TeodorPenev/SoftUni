using System;
using System.Diagnostics;



namespace План_за_спасение_на_България
{
    class ПланЗаСпасениеНаБългария
    {
        static void Main()
        {
            string url = "http://nfsb.bg/index.php";
            string declaration = "http://nfsb.bg/public/deklaracia_za_chlenstvo.pdf";
            string ankCarrd = "http://nfsb.bg/public/anketna%20karta.pdf";
            Process.Start(url);
            Console.WriteLine("Това е началото на спасението на България!!!");
            Console.WriteLine("Запознайте се с цялата платформа.");
            Console.WriteLine("Ако проявявате интерес се свържете с нас.");
            Console.WriteLine("Председател :  Даниел Георгиев Пенев : 0897772404 , 0887685649");
            Console.Write("Моля желаете ли да ви изпратим декларация както и анкета за да се присъедените към нас? (да/не) : ");
            string answer = Console.ReadLine();
            if (answer == "не")
            {
                Console.WriteLine("Явно вие не милеете за родината си достатъчно.Съжаляваме за изгубеното ви време!"); 
            }
            else
            {
                Process.Start(ankCarrd, declaration);
            }
        }
    }
}
