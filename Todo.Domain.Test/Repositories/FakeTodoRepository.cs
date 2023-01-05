using System;
using System.Collections.Generic;
using Todo.Domain.Entities;
using Todo.Domain.Repositories;

namespace Todo.Domain.Test.Repositories
{
    public class FakeTodoRepository : ITodoRepository
    {
        public void Create(TodoItem item)
        {
        }

        public IEnumerable<TodoItem> GetAll(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllDone(string user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAllUndone(string user)
        {
            throw new NotImplementedException();
        }

        public TodoItem GetById(Guid id, string user)
        {
            return new TodoItem("Title", DateTime.Now, "user");
        }

        public IEnumerable<TodoItem> GetByPeriod(string user, DateTime date, bool done)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem item)
        {
        }
    }
}