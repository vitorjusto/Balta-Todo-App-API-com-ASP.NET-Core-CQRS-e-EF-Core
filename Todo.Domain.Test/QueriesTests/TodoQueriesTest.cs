using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Infra.Queries;

namespace Todo.Domain.Test.QueriesTests
{
    [TestClass]
    public class TodoQueriesTest
    {
        private List<TodoItem> _items;

        public TodoQueriesTest()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("tarefa 1", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("tarefa 2", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("tarefa 3", DateTime.Now, "vitor"));
            _items.Add(new TodoItem("tarefa 4", DateTime.Now, "usuarioA"));
            _items.Add(new TodoItem("tarefa 5", DateTime.Now, "vitor"));
        }

        [TestMethod]
        public void dada_a_consulta_deve_retornar_apenas_do_usuario_vitor()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("vitor"));
            Assert.AreEqual(2, result.Count());
        }
    }
}