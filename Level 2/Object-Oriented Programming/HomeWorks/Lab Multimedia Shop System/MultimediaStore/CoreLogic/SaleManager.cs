using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Interfaces;
using MultimediaStore.Models;

namespace MultimediaStore.CoreLogic
{
    class SaleManager
    {
        private static ISet<ISale> sales = new HashSet<ISale>();

        public static void AddSale(IItem item, DateTime dateTime)
        {
            sales.Add(new Sale(item, dateTime));
        }

        public static decimal ReportSalesIncome(DateTime startDate)
        {
            return sales
                .Where(s => s.DateOfPurchase >= startDate)
                .Sum(s => s.Item.Price);
        }
    }
}
