using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultimediaStore.Interfaces;

namespace MultimediaStore.Models
{
    class Item:IItem
    {
        private string id;
        private string title;
        private decimal price;

        protected Item(string id, string title, decimal price, List<string> genres)
        {
            this.Id = id;
            this.Title = title;
            this.Price = price;
            this.Genres = genres;
        }

        protected Item(string id, string title, decimal price)
            : this(id, title, price, new List<string>())
        {
        }

        public string Id {
            get { return this.id; }
            set
            {
                if (String.IsNullOrEmpty(value) || value.Length<5)
                {
                    throw new  ArgumentOutOfRangeException("Id name cannot be null or empty and got to be at least 4 symbols long!");
                }
                 this.id=value;
            }
        }

        public string Title
        {
            get { return this.title;}
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The title cannot be null!");
                }
                this.title = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The item price cannot be negative!");
                }
                this.price = value;
            }
        }

        public List<string> Genres { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Id:{0}, Title:{1}, Price:{2:F2}, Genre:{3}", this.id, this.title, this.price, string.Join(", ", this.Genres)));

            return result.ToString();
        }
    }
}
