using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class Answer:Post,IAnswer
    {
       
        public Answer(int id,string body,IUser author):base(id,body,author)
        {
            
        }

        public int Id { get; set; }

        public string Body { get; set; }

        public IUser Author { get; set; }

        public override string ToString()
        {
            var answer = new StringBuilder();
            answer.AppendFormat("[ Answer ID: [0]", this.Id).AppendLine()
                .AppendFormat("Posted by: [0]", this.Author.Username).AppendLine()
                .AppendFormat("Answer Body: [0]", this.Body).AppendLine()
                .AppendLine(new string('-',20));
            return answer.ToString();
        }
    }
}
