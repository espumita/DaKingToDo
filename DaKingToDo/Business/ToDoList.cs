using System.Collections;
using System.Collections.Generic;
using Tests.Business;

namespace DaKingToDo.Business
{
    public class ToDoList : IEnumerable<Task>
    {
        private List<Task> list;

        public ToDoList()
        {
            list = new List<Task>();
        }

        public IEnumerator<Task> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Task task)
        {
            list.Add(task);
        }

        public void Remove(Task task)
        {
            if (!list.Remove(task))
            {
                throw new CannotDeleteAnNonExistentTaskException();
            }
        }
    }
}