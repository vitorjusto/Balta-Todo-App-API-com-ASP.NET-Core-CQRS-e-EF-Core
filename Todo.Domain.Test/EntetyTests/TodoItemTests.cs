using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Test.EntetyTests
{
    [TestClass]
    public class TodoItemTests
    {
        [TestMethod]
        public void Dado_um_novo_todo_deve_ser_done_falso_por_padrao()
        {
            var entity = new TodoItem("Title", DateTime.Now, "User");
            Assert.IsFalse(entity.Done);
        }
    }
}