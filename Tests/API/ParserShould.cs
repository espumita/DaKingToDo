using System.Collections.Generic;
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
            var toDoList = new List<Task>();
            var parser = new Parser(toDoList);
            
            var json = parser.ToJson();

            json.Should().BeEquivalentTo("{\"ToDoList\":[]}");
        }

        [Test]
        public void return_a_JSON_of_a_ToDoList_object_with_one_Task()
        {
            var toDoList = new List<Task>() {new Task("something")};
            var parser = new Parser(toDoList);

            var json = parser.ToJson();

            json.Should().BeEquivalentTo("{\"ToDoList\":[{\"content\":\"something\"}]}");
        }

        [Test]
        public void return_a_JSON_of_a_ToDoList_object_with_more_than_one_Task()
        {
            var toDoList = new List<Task>() { new Task("something"), new Task("anything") };
            var parser = new Parser(toDoList);

            var json = parser.ToJson();

            json.Should().BeEquivalentTo("{\"ToDoList\":[{\"content\":\"something\"},{\"content\":\"anything\"}]}");
        }

    }
}