using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultimediaStore.Models
{
    class Game:Item
    {
        
        private AgeRestriction ageRestriction;

        public Game(string id, string title, decimal price, List<string> genres,AgeRestriction ageRestriction=AgeRestriction.Minor) : base(id, title, price, genres)
        {
            this.ageRestriction = ageRestriction;
        }

        public Game(string id, string title, decimal price, string genre, AgeRestriction ageRestriction =AgeRestriction.Minor)
            : base(id, title, price,new List<string>(){genre})
        {
            this.ageRestriction = ageRestriction;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(string.Format("Age Restriction:{0}", ageRestriction));

            return base.ToString() + ", " + result.ToString();
        }
    }
}
