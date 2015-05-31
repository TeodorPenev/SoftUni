using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Posts;

namespace ConsoleForum.Commands
{
    class PostAnswerCommand:AbstractCommand
    {
        public PostAnswerCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {
                throw new CommandException(Messages.NotLogged);
            }

            if (this.Forum.CurrentQuestion==null)
            {
                throw new CommandException(Messages.NoQuestionOpened);
            }

            var user = this.Forum.CurrentUser;
            var question = this.Forum.CurrentQuestion;
            string answerBody = this.Data[1];
            var answer = new Answer(this.Forum.Answers.Count + 1, answerBody, user);
            this.Forum.Answers.Add(answer);
            question.Answers.Add(answer);
            this.Forum.Output.AppendFormat(Messages.PostAnswerSuccess, answer.Id);

        }
    }
}
