using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleForum.Contracts;
using ConsoleForum.Entities.Users;
using ConsoleForum.Utility;

namespace ConsoleForum.Commands
{
    public class LoginCommand:AbstractCommand
    {
        public LoginCommand(IForum forum)
            : base(forum)
        {
        }

        public override void Execute()
        {
            var users = this.Forum.Users;
            string username = this.Data[1];
            string password = PasswordUtility.Hash(this.Data[2]);

            if (Forum.IsLogged)
            {
                throw new CommandException(Messages.AlreadyLoggedIn);
            }

            var existingUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (existingUser==null)
            {
                throw new CommandException(Messages.InvalidLoginDetails);
            }

            this.Forum.CurrentUser = existingUser;
            this.Forum.Output.AppendFormat(Messages.LoginSuccess, existingUser.Username).AppendLine();
        }
    }
}
