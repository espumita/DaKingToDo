using System;
using DaKingToDo.Business;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Business
{
    [TestFixture]
    public class ToDoListShould
    {
        [Test]
        public void be_empty_when_create_new_one()
        {
            var toDoList = new ToDoList();

            toDoList.Should().BeEmpty();
        }


        [Test]
        public void contain_a_task_when_it_is_added()
        {
            var toDoList = new ToDoList();
            var task = new Task("Something");

            toDoList.Add(task);

            toDoList.Should().Contain(task);
        }

        [Test]
        public void delete_a_contained_task()
        {
            var toDoList = new ToDoList();
            var task = new Task("Something");
            toDoList.Add(task);

            toDoList.Remove(task);

            toDoList.Should().BeEmpty();
        }

        [Test]
        public void trow_and_exception_when_try_to_delete_a_non_existent_Task()
        {
            var toDoList = new ToDoList();
            var task = new Task("Something");

            Action deleteTask = () => toDoList.Remove(task);

            deleteTask.ShouldThrow<CannotDeleteAnNonExistentTaskException>();
        }

    }

}
