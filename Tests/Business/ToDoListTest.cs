using DaKingToDo.Business;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Business
{
    [TestFixture]
    public class ToDoListTest
        //add task to the list
        //delete task from the list
    {
        [Test]
        public void when_we_create_an_ToDoList_instance_it_is_empty()
        {
            var list = new ToDoList();

            list.Should().BeEmpty();
        }


        [Test]
        public void when_add_a_Task_ToDoList_should_be_modified()
        {
            var list = new ToDoList();
            var task = new Task();

            list.add(task);

            list.Should().Contain(task);
        }

    }
}