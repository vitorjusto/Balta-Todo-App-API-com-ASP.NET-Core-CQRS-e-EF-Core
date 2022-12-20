using Todo.Domain.Commands.Contracts;

namespace Todo.Domain.Handlers.Contracs
{
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handle(T command);
    }
}