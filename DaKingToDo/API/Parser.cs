using DaKingToDo.Business;

namespace DaKingToDo.API
{
    public class Parser
    {
        private ToDoList data;

        public Parser(ToDoList data)
        {
            this.data = data;
        }


        public string ToJson()
        {
            return "{}";
        }
    }
}