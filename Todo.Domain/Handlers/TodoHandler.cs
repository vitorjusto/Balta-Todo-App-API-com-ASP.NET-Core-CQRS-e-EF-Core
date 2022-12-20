
using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracs;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : Notifiable<Notification>, IHandler<CreateTodoCommand> 
    {
        private readonly ITodoRepository _repository;

        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateTodoCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new GenericCommandResult(success: false, message: "Oops, seems your task is wrong",data: command.Notifications);

            var item = new TodoItem(command.Title, command.Date, command.User);

            _repository.Create(item);

            return new GenericCommandResult(success: false, message: "Task saved!",data: item);
        }
    }
}