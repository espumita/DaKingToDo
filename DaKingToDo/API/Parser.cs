using DaKingToDo.Business;

namespace DaKingToDo.API
{
    public class Parser
    {
        private ToDoList toDoList;

        public Parser(ToDoList toDoList)
        {
            this.toDoList = toDoList;
        }


        public string ToJson()
        {
            var prejson = "{\"ToDoList\":[";
            var json = "";

            foreach (var task in toDoList)
            {
                json += "{" + "\"content\":\"" + task.Content + "\"},";
            }
            if(json.Length > 0) json = json.Substring(0, json.Length - 1);
            return prejson + json + "]}";
        }
    }
}