using System;
using DaKingToDo.Business.Exceptions;

namespace DaKingToDo.Business
{
    public class Task
    {
        public string Content { get; }

        public Task(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new CannotCreateAnEmptyTaskException();
            }
            this.Content = content;
        }
    }
}