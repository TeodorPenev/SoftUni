using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Models;

namespace MultimediaStore.Interfaces
{
    interface IRent
    {
        Item Item { get; set; }
        RentState State { get; set; }
        DateTime DateOfRent { get; set; }
        DateTime DeadLine { get; set; }
        DateTime DateOfReturn { get; set; }
        Decimal RentFine { get; set; }
    }
}
