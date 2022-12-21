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
        [TestMethod]
        public void Dado_um_comando_invalido_deve_Interromper_a_execucao()
        {
            var command = new CreateTodoCommand("", "", DateTime.Now);
            var handler = new TodoHandler(new FakeTodoRepository());

        }

        [TestMethod]
        public void Dado_um_comando_valido_deve_criar_a_tarefa()
        {
            
        }
    }
}