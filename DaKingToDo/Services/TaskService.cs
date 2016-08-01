using System.Collections.Generic;
using System.Linq;
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

        public List<Task> Load()
        {
            return taskRepository.Load().ToList();
        }
    }
}