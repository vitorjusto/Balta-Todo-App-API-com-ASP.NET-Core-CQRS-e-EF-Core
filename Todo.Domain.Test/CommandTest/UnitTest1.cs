using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Commands;

namespace Todo.Domain.Test.CommandTests;

[TestClass]
public class CreateTodoCommandTest
{
    private readonly CreateTodoCommand _invalidCommand = new CreateTodoCommand("", "", DateTime.Now);
    private readonly CreateTodoCommand _validCommand = new CreateTodoCommand("titulo", "user123", DateTime.Now);


    [TestMethod]
    public void Dado_um_commando_valido()
    {
        _validCommand.Validate();

        Assert.AreEqual(_validCommand.IsValid, true);

    }
}