using System.Collections.Generic;
using DaKingToDo.Business;

namespace DaKingToDo.API
{
    public class Parser
    {
        private List<Task> list;

        public Parser(List<Task> list)
        {
            this.list = list;
        }


        public string ToJson()
        {
            var prejson = "{\"ToDoList\":[";
            var json = "";

            foreach (var task in list)
            {
                json += "{" + "\"content\":\"" + task.Content + "\"},";
            }
            if(json.Length > 0) json = json.Substring(0, json.Length - 1);
            return prejson + json + "]}";
        }
    }
}