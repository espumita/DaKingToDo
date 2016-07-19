using System;
using DaKingToDo.Business;
using DaKingToDo.Business.Exceptions;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Business
{
    [TestFixture]
    public class TaskShould
    {

        [Test]
        public void not_be_created_with_an_empty_content()
        {
            Action createTask = () => new Task("");

            createTask.ShouldThrow<CannotCreateAnEmptyTaskException>();
        }


        [Test]
        public void not_be_created_with_a_null_content()
        {
            Action createTask = () => new Task(null);

            createTask.ShouldThrow<CannotCreateAnEmptyTaskException>();
        }

    }
}