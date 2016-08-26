using DaKingToDo.Business;
using DaKingToDo.Services;

namespace DaKingToDo.Infraestructure
{
    public class MemoryRepository : TaskRepository
    {
        private ToDoList toDoList = new ToDoList {new Task("Something"), new Task("Anotherthing"), new Task("Sleep")};
        
        public ToDoList Load()
        {
            return toDoList;
        }
    }
}
