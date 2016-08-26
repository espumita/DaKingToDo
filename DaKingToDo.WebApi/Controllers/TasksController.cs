using System;
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
        static TaskRepository repository = new MemoryRepository();

        [Route("tasks"), HttpGet, EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
        public List<Task> GetAllTasks()
        {
            var service = new TaskService(repository);
            
            return service.Load();
        }

        [Route("add"), HttpPost, EnableCors(origins: "http://localhost", headers: "*", methods: "*")]
        public String Add()
        {
            var service = new TaskService(repository);
            service.Add(new Task("new task"));
            return "OK";
        }
    }
}
