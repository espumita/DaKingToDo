using DaKingToDo.Business;

namespace DaKingToDo.Services
{
    public interface TaskRepository
    {
        ToDoList Load();
    }
}