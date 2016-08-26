using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using DaKingToDo.Business;
using DaKingToDo.Services;
using DaKingToDo.Infraestructure;

namespace DaKingToDo.WebApi.Controllers
{
    public class TasksController : ApiController
    {
        [Route("tasks"), HttpGet, EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
        public List<Task> GetAllTasks()
        {
            TaskRepository repository = new MemoryRepository();
            var service = new TaskService(repository);
            
            return service.Load();
        }
    }
}
