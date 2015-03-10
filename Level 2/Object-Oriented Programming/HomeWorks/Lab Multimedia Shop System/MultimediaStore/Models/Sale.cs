using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Interfaces;

namespace MultimediaStore.Models
{
    class Sale:ISale
    {
        private Item item;

        public Item Item
        {
            get { return this.item; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The item cannot be null!");
                }
                this.item = value;
            }
        }

        public DateTime DateOfPurchase { get; set; }
    }
}
