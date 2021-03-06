﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Models;
using MultimediaStore.CoreLogic;

namespace MultimediaStore
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Engine shop = new Engine();
            shop.Run();
            Item sallingerBook = new Book("4adwlj4", "Catcher in the Rye", 20.00m, "J. D. Salinger", "fiction");
            Item threeManBook = new Book("84djesd", "Three Men in a Boat", 39.99m, "Jerome K. Jerome", new List<string> { "comedy" });
            Item acGame = new Game("9gkjdsa", "AC Revelations", 78.00m, "historical", AgeRestriction.Teen);
            Item bubbleSplashGame = new Game("r8743jf", "Bubble Splash", 7.80m, new List<string> { "child", "fun" });
            Item godfatherMovie = new Movie("483252j", "The Godfather", 99.00m, 178, "crime");
            Item dieHardMovie = new Movie("9853kfds", "Die Hard 4", 9.90m, 144, new List<string> { "action", "crime", "thriller" });

            Sale first = new Sale(sallingerBook);
            Console.WriteLine(first);

            DateTime today = DateTime.Now;
            DateTime fiveYearsAgo = today.AddYears(-5);
            Sale dieHardSale = new Sale(dieHardMovie, fiveYearsAgo);
            Console.WriteLine(dieHardSale.DateOfPurchase); // 1/30/2015 2:31:55 PM (today)
            Sale acSale = new Sale(acGame);
            Console.WriteLine(acSale.DateOfPurchase); // 1/30/2010 2:31:55 PM


            DateTime afterOneWeek = today.AddDays(30);
            Rent bookRent = new Rent(sallingerBook, today, afterOneWeek);
            Console.WriteLine(bookRent.StateRent); // Pending

            DateTime lastMonth = today.AddDays(-34);
            DateTime lastWeek = today.AddDays(-8);
            Rent movieRent = new Rent(godfatherMovie, lastMonth, lastWeek);
            Console.WriteLine(movieRent.StateRent); // Overdue

            movieRent.ReturnItem();
            Console.WriteLine(movieRent.StateRent); // Returned

            Console.WriteLine(movieRent.RentFine); // 7.9200

            Console.WriteLine();
            Console.WriteLine(movieRent.DateOfRent);
            Rent DieHard = new Rent(dieHardMovie);
            Console.WriteLine(DieHard);
            Console.WriteLine(DieHard.StateRent);
            DieHard.ReturnItem();
            Console.WriteLine(DieHard.StateRent);
        }
    }
}
