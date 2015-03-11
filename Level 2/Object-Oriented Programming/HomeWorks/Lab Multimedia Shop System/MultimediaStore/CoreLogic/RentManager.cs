using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Interfaces;
using MultimediaStore.Models;

namespace MultimediaStore.CoreLogic
{
    class RentManager
    {
        private static ISet<IRent> rents = new HashSet<IRent>();

        public static void AddRent(IItem item, DateTime rentDate, DateTime deadLine)
        {
            rents.Add(new Rent(item, rentDate, deadLine));
        }

        public static IEnumerable<IRent> ReportOverdueRents()
        {
            return rents
                .Where(r => r.StateRent == RentState.overdue)
                .OrderBy(r => r.RentFine)
                .ThenBy(r => r.Item.Title);
        }
    }
}
