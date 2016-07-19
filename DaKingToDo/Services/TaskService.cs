using DaKingToDo.Business;

namespace DaKingToDo.Services
{
    public class TaskService
    {
        private TaskRepository taskRepository;

        public TaskService(TaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public ToDoList Load()
        {
            return taskRepository.Load();
        }
    }
}