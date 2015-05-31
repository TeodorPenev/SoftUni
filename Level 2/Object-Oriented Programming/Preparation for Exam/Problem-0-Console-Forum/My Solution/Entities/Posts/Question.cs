using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;

namespace ConsoleForum.Entities.Posts
{
    public class Question:Post,IQuestion
    {
        public Question(int id, string title, string body,IUser author):base(id,body,author)
        {
            this.Author = author;
            this.Answers = new List<IAnswer>();
        }

        public string Title { get; set; }

        public IList<IAnswer> Answers { get; private set; }

        public int Id { get; set; }

        public string Body { get; set; }

        public IUser Author { get; set; }

        public override string ToString()
        {
            StringBuilder question = new StringBuilder();
            question.AppendFormat("[ Question ID: {0} ]", this.Id).AppendLine()
                .AppendFormat("Posted by: {0}", this.Author.Username).AppendLine()
                .AppendFormat("Question Title: {0}", this.Title).AppendLine()
                .AppendFormat("Question Body: {0}", this.Body).AppendLine()
                .AppendFormat("{0}", new String('=', 20)).AppendLine();

            if (!this.Answers.Any())
            {
                question.Append("No answers");
            }
            else
            {
                question.AppendLine("Answer:");
                var bestAnswer = this.Answers.FirstOrDefault(a => a is BestAnswer);
                string answersAsStr;
                if (bestAnswer != null)
                {
                    question.Append(bestAnswer);
                    var otherAnswer = this.Answers.Where(a => a.Id != bestAnswer.Id).OrderBy(a=>a.Id);
                    answersAsStr = string.Join(Environment.NewLine, otherAnswer.Select(a => a.ToString()));
                }
                else
                {
                    answersAsStr = string.Join(Environment.NewLine, this.Answers.Select(a => a.ToString()));
                }
                
                question.AppendLine(answersAsStr);
            }

            return question.ToString();
        }
    }
}
