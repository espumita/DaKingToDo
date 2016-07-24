using DaKingToDo.Business;
using DaKingToDo.Services;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;

namespace Tests.Service
{
    [TestFixture]
    public class TaskServiceShould
    {
        private TaskRepository repo;

        [SetUp]
        public void SetUp()
        {
            repo = Substitute.For<TaskRepository>();
            repo.Load().Returns(new ToDoList());
        }

        [Test]
        public void return_an_empty_ToDoList_when_the_repository_is_empty_and_load_method_is_called()
        {
            var service = new TaskService(repo);

            var toDoList = service.Load();

            toDoList.Should().BeOfType<ToDoList>();
        }
    }
}