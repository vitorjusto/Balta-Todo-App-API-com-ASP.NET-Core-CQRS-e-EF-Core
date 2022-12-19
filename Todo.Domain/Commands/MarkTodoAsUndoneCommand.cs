using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;
using Flunt.Validations;

namespace Todo.Domain.Commands
{
    public class MarkTodoAsUndoneCommand : Notifiable<Notification>, ICommand
    {
        public MarkTodoAsUndoneCommand()
        {
        }

        public MarkTodoAsUndoneCommand(Guid id, string user)
        {
            User = user;
            Id = id;
        }

        public Guid Id {get; set;}
        public string? User {get; set;}

        public void Validate()
        {
            AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsGreaterThan(User, 6, "User", "Invalid User")
           );
        }
    }
}