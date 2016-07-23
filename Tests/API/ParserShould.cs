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
        public void return_a_JSON_of_the_ToDoList_object()
        {
            var toDoList = new ToDoList();
            var parser = new Parser(toDoList);
            
            var json = parser.ToJson();

            json.Should().BeEquivalentTo("{}");
        }
        
    }
}