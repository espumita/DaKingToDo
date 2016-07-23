using DaKingToDo.Business;
using DaKingToDo.Services;

namespace DaKingToDo.Infraestructure
{
    public class SQLTaskRepo : TaskRepository
    {
        public ToDoList Load()
        {
           return new ToDoList();
        }
    }
}