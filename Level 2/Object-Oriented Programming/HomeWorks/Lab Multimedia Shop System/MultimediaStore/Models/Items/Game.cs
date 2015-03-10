using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaStore.Models
{
    class Game:Item
    {
        private string genre;
        private AgeRestriction ageRestriction;

        public Game(string id, string title, decimal price, List<string> genres,AgeRestriction ageRestriction=AgeRestriction.Minor) : base(id, title, price, genres)
        {
            this.ageRestriction = ageRestriction;
        }

        public Game(string id, string title, decimal price, string genre, AgeRestriction ageRestriction =AgeRestriction.Minor)
            : base(id, title, price)
        {
            this.ageRestriction = ageRestriction;
            this.genre = genre;
        }
    }
}
