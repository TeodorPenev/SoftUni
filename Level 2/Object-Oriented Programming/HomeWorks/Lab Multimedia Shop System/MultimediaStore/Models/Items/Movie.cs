using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaStore.Models
{
    class Movie:Item
    {
        private int lenght;
        public Movie(string id, string title, decimal price,int lenght, List<string> genres) : base(id, title, price, genres)
        {
            this.lenght = lenght;
        }

        public Movie(string id, string title, decimal price,int lenght, string genre)
            : base(id, title, price,new List<string>(){genre})
        {
            this.lenght = lenght;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(String.Format("Lenght:{0}", this.lenght));
            return base.ToString()+ ", "+result+"min.";
        }
    }
}
