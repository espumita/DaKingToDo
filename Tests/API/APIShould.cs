using DaKingToDo.API;
using DaKingToDo.Business;
using DaKingToDo.Infraestructure;
using DaKingToDo.Services;
using FluentAssertions;
using NSubstitute;
using NUnit.Framework;

namespace Tests.API
{
    [TestFixture]
    public class APIShould
    {
        [SetUp]
        public void SetUp()
        {
            var repo = Substitute.For<TaskRepository>();
            var toDoList = new ToDoList { new Task("something to do") };
            repo.Load().Returns(toDoList);

            var parser = Substitute.For<Parser>();
            parser.ToJson().Returns("{ \"element1\" : \"something to do\" }");

        }

        [Test]
        public void return_ToDoList_in_JSON_format_when_acces_to_list_path()
        {
            var request = new Request("GET", "list");

            var response = request.Execute();

            var expectedJSON = "{ \"element1\" : \"something to do\" }";
            response.Should().BeEquivalentTo(expectedJSON);
        }



    }
}