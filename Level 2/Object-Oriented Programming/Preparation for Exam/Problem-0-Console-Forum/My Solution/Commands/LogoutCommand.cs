using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;

namespace ConsoleForum.Commands
{
    public class LogoutCommand:AbstractCommand
    {
        public LogoutCommand(IForum forum) : base(forum)
        {
        }

        public override void Execute()
        {
            if (!this.Forum.IsLogged)
            {

                throw new CommandException(Messages.NotLogged);

            }

            this.Forum.CurrentUser = null;
            this.Forum.Output.AppendLine(Messages.LogoutSuccess);
        }
    }
}
