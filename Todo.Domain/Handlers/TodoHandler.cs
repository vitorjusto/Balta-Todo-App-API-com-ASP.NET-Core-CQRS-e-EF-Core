
using Flunt.Notifications;
using Todo.Domain.Commands;
using Todo.Domain.Commands.Contracts;
using Todo.Domain.Entities;
using Todo.Domain.Handlers.Contracs;
using Todo.Domain.Repositories;

namespace Todo.Domain.Handlers
{
    public class TodoHandler : Notifiable<Notification>, IHandler<CreateTodoCommand>, IHandler<UpdateTodoCommand> 
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

            return new GenericCommandResult(success: true, message: "Task saved!",data: item);
        }

        public ICommandResult Handle(UpdateTodoCommand command)
        {
            command.Validate();

            if(!command.IsValid)
                return new GenericCommandResult(success: false, message: "Oops, seems your task is wrong",data: command.Notifications);

            var todo = _repository.GetById(command.Id, command.User);

            todo.UpdateTitle(command.Title);
            
            _repository.Update(todo);

            return new GenericCommandResult(success: true, message: "Task saved!",data: todo);
        }
    }