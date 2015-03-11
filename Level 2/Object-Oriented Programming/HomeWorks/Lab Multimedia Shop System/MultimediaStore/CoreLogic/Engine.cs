using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Interfaces;
using MultimediaStore.Models;

namespace MultimediaStore.CoreLogic
{
    internal class Engine
    {
        private Dictionary<IItem, int> supply = new Dictionary<IItem, int>();

        public void Run()
        {
            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                ExecuteCommand(command);
            }
        }

        private void ExecuteCommand(string[] command)
        {
            switch (command[0])
            {
                case "supply":
                {
                    string type = command[1];
                    int quantity = int.Parse(command[2]);
                    string paramsString = command[3];

                    ExecuteSupplyCommand(type, quantity, paramsString);
                    break;
                   
                }

                case "sell":
                {
                    string id = command[1];
                    IItem item = GetItemById(id);
                    DateTime saleDate = DateTime.ParseExact(command[2],"dd-MM-yyyy",CultureInfo.InvariantCulture);
                    
                    ExecuteSellCommand(item,saleDate);
                    break;
                }

                case "rent":
                {
                    string id = command[1];
                    IItem item = GetItemById(id);
                    DateTime rentDate = DateTime.ParseExact(command[2], "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    DateTime deadLine = DateTime.ParseExact(command[3], "dd-MM-yyyy", CultureInfo.InvariantCulture);

                    ExecuteRentCommand(item, rentDate, deadLine);
                    break;
                }

                case "report":
                {
                    this.ExecuteReportCommand(command);
                    break;
                }
                default:
                throw new InvalidOperationException("Invalid command.");
            } 
        }

        private void ExecuteSupplyCommand(string type, int quantity, string paramsString)
        {
            var itemParams = GetItemParams(paramsString);

            switch (type)
            {
                case "book":
                {
                    string id = itemParams["id"];
                    string title = itemParams["title"];
                    decimal price = decimal.Parse(itemParams["price"]);
                    string author = itemParams["author"];
                    string genre = itemParams["genre"];

                    Item book = new Book(id, title, price, author, genre);
                    supply.Add(book, quantity);
                    break;
                }

                case "game":
                {
                    string id = itemParams["id"];
                    string title = itemParams["title"];
                    decimal price = decimal.Parse(itemParams["price"]);
                    string genre = itemParams["genre"];
                    AgeRestriction ageRestriction = GetAgeRestriction(itemParams["ageRestriction"]);

                    Item game = new Game(id, title, price, genre, ageRestriction);
                    supply.Add(game, quantity);
                    break;
                }

                case "video":
                {
                    string id = itemParams["id"];
                    string title = itemParams["title"];
                    decimal price = decimal.Parse(itemParams["price"]);
                    string genre = itemParams["genre"];
                    int legth = int.Parse(itemParams["legth"]);
                    Item movie = new Movie(id, title, price, legth, genre);
                    supply.Add(movie, quantity);
                    break;
                }
                default:
                throw new ArgumentException("Invalid item type.");
            }
        }

        private void ExecuteSellCommand(IItem item, DateTime saleDate)
        {
            if (this.supply[item] == 0)
            {
                throw new InsufficientSuppliesException("There are not enough supplies to sell this item.");
            }

            SaleManager.AddSale(item, saleDate);
            this.supply[item]--;
        }

        private void ExecuteRentCommand(IItem item, DateTime rentDate, DateTime deadLine)
        {
            if (this.supply[item] == 0)
            {
                throw new InsufficientSuppliesException("There are not enough supplies to rent this item.");
            }

            RentManager.AddRent(item, rentDate, deadLine);
            this.supply[item]--;

        }

        private void ExecuteReportCommand(string[] command)
        {
            string reportType = command[1];
            switch (reportType)
            {
                case "sales":
                    DateTime startDate = DateTime.ParseExact(command[2], "dd-MM-yyyy", CultureInfo.InvariantCulture);
                    decimal salesIncome = SaleManager.ReportSalesIncome(startDate);

                    Console.WriteLine(string.Format("{0:F2}", salesIncome));
                    break;
                case "rents":
                    var overdueRents = RentManager.ReportOverdueRents();

                    Console.WriteLine(string.Join("\n", overdueRents));
                    break;
                default:
                    throw new ArgumentException("Invalid report type.");
            }
        }

        private IDictionary<string, string> GetItemParams (string paramsString)
            {
                Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
                string[] pairs = paramsString.Split('&');
                foreach (var pair in pairs)
                {
                    string[] keyValuePair = pair.Split('=');
                    keyValuePairs[keyValuePair[0]] = keyValuePair[1];
                }
                return keyValuePairs;
            }

        private AgeRestriction GetAgeRestriction (string restrictionStr)
        {
           if (restrictionStr == "Minor")
            {
                return AgeRestriction.Minor;
            }
            else if (restrictionStr == "Teen")
            {
                return AgeRestriction.Teen; 
            }
            else if (restrictionStr == "Adult")
            {
                return AgeRestriction.Adult;
            }
            else
            {
                return AgeRestriction.Minor;

            }
        }

        private IItem GetItemById(string idStr)
        {
            return this.supply
                 .First(x => x.Key.Id == idStr)
                 .Key;
        }
    }
}

