using DaKingToDo.Business;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.Business
{
    [TestFixture]
    public class ToDoListTest
        //ToDoList Constructor test
        //add task to the list
        //delete task from the list
    {
        [Test]
        public void when_we_create_an_ToDoList_instance_it_is_empty()
        {
            var list = new ToDoList();

            list.Should().BeEmpty();
        }
    }
}