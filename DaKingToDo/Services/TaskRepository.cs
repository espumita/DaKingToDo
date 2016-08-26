using DaKingToDo.Business;

namespace DaKingToDo.Services
{
    public interface TaskRepository
    {
        ToDoList Load();
        void Add(Task newTask);
    }
}