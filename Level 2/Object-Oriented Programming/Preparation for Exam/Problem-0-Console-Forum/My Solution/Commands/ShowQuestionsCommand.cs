using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    class ShowQuestionsCommand:AbstractCommand
    {
        public ShowQuestionsCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.Questions.Any())
            {
                throw new CommandException(Messages.NoQuestion);
            }

            var questions = this.Forum.Questions.OrderBy(q => q.Id);
            this.Forum.Output.AppendLine(string.Join(Environment.NewLine, questions));
        }
    }
}
