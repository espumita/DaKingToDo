using System.Collections.Generic;
using System.Linq;
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
        private TaskRepository repository;
        private TaskService service;

        [SetUp]
        public void SetUp()
        {
            repository = Substitute.For<TaskRepository>();
            service = new TaskService(repository);
        }

        [Test]
        public void return_an_empty_Task_list_when_the_repository_is_empty_and_load_method_is_called()
        {
            repository.Load().Returns(new ToDoList());

            var tasksList = service.Load();

            tasksList.Should().BeEmpty();
        }


        [Test]
        public void return_a_list_of_Task_when_load_method_is_called()
        {
            var toDoList = new ToDoList();
            repository.Load().Returns(toDoList);
            toDoList.Add(new Task("Something"));

            var listOfTasks = service.Load();

            var expectedList = new List<Task> {new Task("Something")};
            listOfTasks.ShouldBeEquivalentTo(expectedList);
        }

    }
}