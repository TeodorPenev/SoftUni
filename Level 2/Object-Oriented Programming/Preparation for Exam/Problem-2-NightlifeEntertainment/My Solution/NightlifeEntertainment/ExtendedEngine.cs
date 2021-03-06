﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            var performanceMatch = GetPerformance(commandWords[1]);
            var soldTickets = performanceMatch.Tickets.Where(t => t.Status == TicketStatus.Sold);
            var totalPrice = soldTickets.Sum(p => p.Price);

            this.Output.AppendFormat("{0}: {1} ticket(s), total: ${2:f}", performanceMatch.Name, soldTickets.Count(),
                totalPrice);
            this.Output.AppendLine();
            this.Output.AppendFormat("Venue: {0} ({1})", performanceMatch.Venue.Name, performanceMatch.Venue.Location);
            this.Output.AppendLine();
            this.Output.AppendFormat("Start time: {0}", performanceMatch.StartTime);
            this.Output.AppendLine();
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            var performances = Performances.Where(p => p.Name.ToLower().Contains(commandWords[1].ToLower()));
            var venues = Venues.Where(v => v.Name.ToLower().Contains(commandWords[1].ToLower())).OrderBy(v =>v.Name);
            var sortedEventInVenue = new List<IPerformance>();

            DateTime specifiedTime = DateTime.Parse(commandWords[2] + " " + commandWords[3]);

            var sortedPerformances =
                performances.Where(p => p.StartTime >= specifiedTime)
                    .OrderBy(p => p.StartTime)
                    .ThenByDescending(p => p.BasePrice)
                    .ThenBy(p => p.Name);

            this.Output.AppendFormat("Search for \"{0}\"", commandWords[1]);
            this.Output.AppendLine();
            this.Output.Append("Performances:");
            this.Output.AppendLine();

            if (sortedPerformances.Any())
            {
                foreach (var performance in sortedPerformances)
                {
                    this.Output.AppendFormat("-{0}", performance.Name);
                    this.Output.AppendLine();
                }
            }
            else
            {
                this.Output.Append("no result");
                this.Output.AppendLine();
            }

            this.Output.Append("Venues:");
            this.Output.AppendLine();

            if (venues.Any())
            {
                foreach (var venue in venues)
                {
                    this.Output.AppendFormat("-{0}", venue.Name);
                    this.Output.AppendLine();

                    foreach (var performance in sortedPerformances)
                    {
                        if (performance.Venue.Name == venue.Name)
                        {
                            sortedEventInVenue.Add(performance);
                        }
                    }
                    foreach (var performance in sortedEventInVenue)
                    {
                        this.Output.AppendFormat("--{0}", performance.Name);
                        this.Output.AppendLine();
                    }
                }
            }
            else
            {
                this.Output.Append("no result");
                this.Output.AppendLine();
            }
        }
    }
}
