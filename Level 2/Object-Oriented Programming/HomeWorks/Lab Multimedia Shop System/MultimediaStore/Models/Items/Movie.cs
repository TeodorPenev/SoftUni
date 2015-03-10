using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaStore.Models
{
    class Movie:Item
    {
        private string genre;
        private int lenght;
        public Movie(string id, string title, decimal price,int lenght, List<string> genres) : base(id, title, price, genres)
        {
            this.lenght = lenght;
        }

        public Movie(string id, string title, decimal price,int lenght, string genre)
            : base(id, title, price)
        {
            this.lenght = lenght;
            this.genre = genre;
        }

    }
}
