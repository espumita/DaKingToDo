using System.Collections.Generic;
using System.Web.Http;
using DaKingToDo.Business;

namespace DaKingToDo.WebApi.Controllers
{
    public class TasksController : ApiController
    {
        [Route("tasks"), HttpGet]
        public List<Task> GetAllTasks()
        {
            return new List<Task>
            {
                new Task("Esta es una nueva tarea")
            };
        }
    }
}
