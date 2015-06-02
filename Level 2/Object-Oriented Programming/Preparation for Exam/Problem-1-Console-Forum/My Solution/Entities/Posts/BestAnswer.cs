using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class BestAnswer:Answer
    {
        public BestAnswer(int id, string body, IUser author) : base(id, body, author)
        {
        }

        public override string ToString()
        {
            var bestAnswer = new StringBuilder();
            bestAnswer.AppendLine(new string('*', 20))
                .AppendLine(base.ToString());
            bestAnswer.AppendLine(new string('*', 20));
            return bestAnswer.ToString();
        }
    }
}
