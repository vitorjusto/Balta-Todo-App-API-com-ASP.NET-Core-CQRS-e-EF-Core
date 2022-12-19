using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;
using System;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsDoneCommand : Notifiable<Notification>, ICommand
    {
        public MarkTodoAsDoneCommand()
        {
        }

        public MarkTodoAsDoneCommand(Guid id, string user)
        {
            User = user;
            Id = id;
        }

        public Guid Id {get; set;}
        public string? User {get; set;}

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}