using System;
using DaKingToDo.Infraestructure;
using DaKingToDo.Services;
using NSubstitute;

namespace DaKingToDo.API
{
    public class Request
    {
        private readonly string method;
        private readonly string path;

        public Request(string method, string path)
        {
            this.method = method;
            this.path = path;
        }

        public string Execute()
        {
            var service = new TaskService(new SQLTaskRepo());
            var data = service.Load();
            return new Parser(data).ToJson();
        }
    }
}