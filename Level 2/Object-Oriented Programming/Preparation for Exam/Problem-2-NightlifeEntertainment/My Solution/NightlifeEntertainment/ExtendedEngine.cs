using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightlifeEntertainment
{
    class ExtendedEngine:CinemaEngine
    {
        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "opera":
                    var opera = new OperaHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sports_hall = new SportsHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sports_hall);
                    break;
                case "concert_hall":
                    var concert_hall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concert_hall);
                    break;
                default:base.ExecuteInsertVenueCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "theatre":
                    var venueT = this.GetVenue(commandWords[5]);
                    var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venueT, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(theatre);
                    break;
                case "concert":
                    var venueC = this.GetVenue(commandWords[5]);
                    var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venueC, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                    this.Performances.Add(concert);
                    break;
                default:base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new RegularTicket(performance));
                    }
                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VIPTicket(performance));
                    }
                    break;
                default:base.ExecuteSupplyTicketsCommand(commandWords);
                    break;
            }
        }
    }
}
