﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Interfaces;

namespace MultimediaStore.Models
{
    class Sale:ISale
    {
        private IItem item;

        public Sale(IItem item, DateTime dateOfPurchase)
        {
            this.Item = item;
            this.DateOfPurchase = dateOfPurchase;
        }

        public Sale(IItem item) : this(item, DateTime.Now)
        {            
        }

        public IItem Item
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

        public override string ToString()
        {
            return string.Format("- {0} {1}\n{2}",
                this.GetType().Name, this.DateOfPurchase, this.Item);
        }
    }
}
