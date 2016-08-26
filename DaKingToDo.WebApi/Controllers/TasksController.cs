using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using DaKingToDo.Business;
using DaKingToDo.Services;
using DaKingToDo.Infraestructure;
using NSubstitute;

namespace DaKingToDo.WebApi.Controllers
{
    public class TasksController : ApiController
    {
        [Route("tasks"), HttpGet, EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
        public List<Task> GetAllTasks()
        {
            //var repository = Substitute.For<TaskRepository>();
            TaskRepository repository = new MemoryRepository();
            var service = new TaskService(repository);
            //repository.Load().Returns(new ToDoList { new Task("Something"), new Task("Anotherthing") });

            return service.Load();
        }
    }
}
