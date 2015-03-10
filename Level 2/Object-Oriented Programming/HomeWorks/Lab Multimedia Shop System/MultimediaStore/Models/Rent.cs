using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Interfaces;

namespace MultimediaStore.Models
{
    class Rent:IRent
    {
        private Item item;
        private RentState state;
        private decimal rentFine;

        public Item Item
        {
            get { return this.item; }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("The item cannot be null!");
                }
                this.item = value;
            }
        }

        public RentState State
        {
            get { return this.state; }
            set
            {
                if (DeadLine > DateOfReturn)
                {
                    state = RentState.overdue;
                }
                if (DateOfReturn < DeadLine)
                {
                    state = RentState.returned;
                }
                this.state = value;
            }
        }

        public DateTime DateOfRent
        { get; set; }

        public DateTime DeadLine
        { get; set; }
            

        public DateTime DateOfReturn
        { get; set; }

        public decimal RentFine
        {
            get { return this.rentFine; }
            set {
                if (state==RentState.overdue)
                {
                    value = Convert.ToDecimal(DateOfReturn - DeadLine)*0.2m;
                }
                this.rentFine = value;
            }
        }
    }
}
