using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Test.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem item)
        {
        }

        public void Update(TodoItem item)
        {
        }
    }
}