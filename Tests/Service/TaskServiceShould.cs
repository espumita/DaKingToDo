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
        private TaskRepository repo;


        [Test]
        public void return_an_empty_ToDoList_when_the_repository_is_empty_and_load_method_is_called()
        {
            repo = Substitute.For<TaskRepository>();
            repo.Load().Returns(new ToDoList());
            var service = new TaskService(repo);

            var toDoList = service.Load();

            toDoList.Should().BeOfType<List<Task>>();
        }

        [Test]
        public void return_a_list_of_Task_when_load_method_is_called()
        {
            repo = Substitute.For<TaskRepository>();
            var toDoList = new ToDoList();
            repo.Load().Returns(toDoList);
            toDoList.Add(new Task("Something"));
            var service = new TaskService(repo);

            var listOfTasks = service.Load();

            var expectedList = new List<Task> {new Task("Something")};
            listOfTasks.ShouldBeEquivalentTo(expectedList);
        }

    }
}