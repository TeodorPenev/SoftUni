using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightlifeEntertainment
{
    class SportsHall:Venue
    {
         public SportsHall(string name, string location, int numberOfSeats)
            : base(name, location, numberOfSeats, new List<PerformanceType> { PerformanceType.Sport, PerformanceType.Concert })
        {
        }
    }
}
