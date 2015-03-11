using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using MultimediaStore.Interfaces;

namespace MultimediaStore.Models
{
    class Rent:IRent
    {
        private IItem item;

        public Rent(IItem item, DateTime dateOfRent, DateTime deadLine)
        {
            this.Item = item;
            this.DateOfRent = dateOfRent;
            this.DeadLine = deadLine;
        }

        public Rent(IItem item, DateTime dateOfRent):this(item,dateOfRent,dateOfRent.AddDays(30))
        {
            
        }

        public Rent(IItem item):this(item,DateTime.Now,DateTime.Now.AddDays(30))
        {
            
        }

        public IItem Item
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

        public RentState StateRent
        {
            set { }
            get
            {
                var now = DateTime.Now;

                if (this.IsSetDate(this.DateOfReturn))
                {
                    return RentState.returned;
                }
                else if (now > this.DeadLine)
                {
                    return RentState.overdue;
                }
                else
                {
                    return RentState.pending;
                }
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
            set { }
            get
            {
                var date = this.IsSetDate(this.DateOfReturn) ? this.DateOfReturn : DateTime.Now;
                decimal fine = (date - this.DeadLine).Days * this.Item.Price * 0.01m;

                return Math.Max(fine, 0);
            }
        }

        private bool IsSetDate(DateTime dateTime)
        {
            return dateTime.Year > 1;
        }

        public void ReturnItem()
        {
            this.DateOfReturn = DateTime.Now;
        }

        public override string ToString()
        {
            return String.Format("Item{0}, Date of Rent:{1}, DeadLine:{2}", this.item, this.DateOfRent, this.DeadLine);
        }
    }
}
