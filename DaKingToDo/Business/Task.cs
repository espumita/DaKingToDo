using System;

namespace DaKingToDo.Business
{
    public class Task
    {
        private string content;

        public Task(string content)
        {
            if (string.IsNullOrEmpty(content))
            {
                throw new CannotCreateAnEmptyTaskException();
            }
            this.content = content;
        }
    }
}