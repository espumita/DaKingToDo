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
            var list = new ToDoList();

            list.Should().BeEmpty();
        }


        [Test]
        public void contain_a_task_when_it_is_added()
        {
            var list = new ToDoList();
            var task = new Task("Something");

            list.add(task);

            list.Should().Contain(task);
        }

        [Test]
        public void delete_a_task()
        {
            var list = new ToDoList();
            var task = new Task("Something");
            list.add(task);

            list.Remove(task);

            list.Should().BeEmpty();
        }

    }
}