using System.Collections.Generic;
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
            var toDoList = taskRepository.Load();
            List<Task> list = new List<Task>();
            foreach (var task in toDoList)
            {
                list.Add(task);
            }
            return list;
        }
    }
}