using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;
using Todo.Domain.Handlers;
using Todo.Domain.Test.Repositories;

namespace Todo.Domain.Test.HandlerTests
{
    [TestClass]
    public class CreateTodoHandlerTest
    {
        private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("Titlesjdoasdsda", "User123", DateTime.Now);
        private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);

        private readonly TodoHandler _handler = new TodoHandler(new FakeTodoRepository());
        private GenericCommandResult _result {get; set;}


        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommand);
            Assert.IsTrue(_result.Success);
        }
    }
}