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
        IItem Item { get; set; }
        RentState StateRent { get; set; }
        DateTime DateOfRent { get; set; }
        DateTime DeadLine { get; set; }
        DateTime DateOfReturn { get; set; }
        Decimal RentFine { get; set; }
    }
}
