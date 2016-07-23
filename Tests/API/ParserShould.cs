using DaKingToDo.API;
using DaKingToDo.Business;
using FluentAssertions;
using NUnit.Framework;

namespace Tests.API
{
    [TestFixture]
    public class ParserShould
    {
        [Test]
        public void return_a_JSON_of_an_empty_ToDoList_object()
        {
            var toDoList = new ToDoList();
            var parser = new Parser(toDoList);
            
            var json = parser.ToJson();

            json.Should().BeEquivalentTo("{\"ToDoList\":[]}");
        }

        [Test]
        public void return_a_JSON_of_a_ToDoList_object_with_one_Task()
        {
            var toDoList = new ToDoList {new Task("something")};
            var parser = new Parser(toDoList);

            var json = parser.ToJson();

            json.Should().BeEquivalentTo("{\"ToDoList\":[{\"content\":\"something\"}]}");
        }

    }
}