using DaKingToDo.Business;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Business
{
    [TestFixture]
    public class ToDoListShould
        //delete task from the list
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

    }
}