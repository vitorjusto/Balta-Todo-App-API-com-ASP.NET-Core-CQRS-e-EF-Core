using Flunt.Notifications;
using Todo.Domain.Commands.Contracts;
using Flunt.Validations;

namespace Todo.Domain.Commands
{
    public class UpdateTodoCommand : Notifiable<Notification>, ICommand
    {
        public UpdateTodoCommand()
        {
        }

        public UpdateTodoCommand(Guid id, string? user, string? title)
        {
            Id = id;
            User = user;
            Title = title;
        }

        public Guid Id {get; set;}
        public string? User {get; set;}
        public string? Title {get; set;}

        public void Validate()
        {
           AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsGreaterThan(Title, 3, "Title", "Please, write a bigger task")
                    .IsGreaterThan(User, 6, "User", "Invalid User")
           );
        }
    }
}