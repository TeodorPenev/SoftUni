using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    public class PostQuestionCommand:AbstractCommand
    {
       public PostQuestionCommand(IForum forum) : base(forum)
       {
       }

       public override void Execute()
       {

           var questions = this.Forum.Questions;
           string title = this.Data[1];
           string body = this.Data[2];


           if (!this.Forum.IsLogged)
           {
               throw new CommandException(Messages.NotLogged);
           }

           var question = new Question(questions.Count + 1,body,this.Forum.CurrentUser,title);

           this.Forum.Questions.Add(question);
           this.Forum.Output.AppendFormat(Messages.PostQuestionSuccess, Forum.Questions.Last().Id).AppendLine();
       }
    }
}
