using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Models;

namespace MultimediaStore.Interfaces
{
    interface ISale
    {
        IItem Item { get; set; }
        DateTime DateOfPurchase { get; set; }
    }
}
