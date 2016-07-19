using System;
using DaKingToDo.Business;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Business
{
    [TestFixture]
    public class TaskShould
        //Dont Create new Task with empty content
        //Dont Create new Task with null content
    {

        [Test]
        public void not_be_created_with_an_empty_content()
        {
            Action createTask = () => new Task("");
            createTask.ShouldThrow<CannotCreateAnEmptyTaskException>();
        }

    }
}