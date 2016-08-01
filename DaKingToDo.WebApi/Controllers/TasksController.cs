using System.Collections.Generic;
using System.Web.Http;
using DaKingToDo.Business;
using DaKingToDo.Services;
using NSubstitute;

namespace DaKingToDo.WebApi.Controllers
{
    public class TasksController : ApiController
    {
        [Route("tasks"), HttpGet]
        public List<Task> GetAllTasks()
        {
            var repository = Substitute.For<TaskRepository>();
            var service = new TaskService(repository);
            repository.Load().Returns(new ToDoList { new Task("Something"), new Task("Anotherthing") });

            return service.Load();
        }
    }
}
