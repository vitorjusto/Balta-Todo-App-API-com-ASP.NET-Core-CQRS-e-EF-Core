using Flunt.Notifications;
using Flunt.Validations;
using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Commands
{
    public class CreateTodoCommand : Notifiable<Notification>, ICommand
    {
        public CreateTodoCommand(string title, string user, DateTime date)
        {
            Title = title;
            User = user;
            Date = date;
        }

        public CreateTodoCommand()
        {

        }

        public string Title {get; set;}
        public string User {get; set;}
        public DateTime Date {get; set;}

        public void Validate()
        {
           AddNotifications(
                new Contract<Notification>()
                    .Requires()
                    .IsGreaterThan(Title, 3, "Title", "Please, write a bigger task")
                    .IsGreaterThan(User, 3, "User", "Invalid User")
           );
        }
    }
}