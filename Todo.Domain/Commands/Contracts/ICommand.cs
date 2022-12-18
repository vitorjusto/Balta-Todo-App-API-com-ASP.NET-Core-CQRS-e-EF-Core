using System.ComponentModel.DataAnnotations;

namespace Todo.Domain.Commands.Contracts
{
    public interface ICommand 
    {
        public void Validate();
    }
}