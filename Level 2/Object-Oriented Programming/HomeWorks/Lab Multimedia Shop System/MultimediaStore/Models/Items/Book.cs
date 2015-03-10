using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaStore.Models
{
    class Book:Item
    {
        private string author;
        public Book(string id, string title, decimal price, string author, string genre)
            : base(id, title, price,new List<string>() {genre} )
        {
            this.author = author;
        }

        public Book(string id, string title, decimal price,string authour, List<string> genres) : base(id, title, price, genres)
        {
            this.author = authour;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Author:{0}", this.author));
            return base.ToString()+", "+result;
        }
    }
}
