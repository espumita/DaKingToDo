using System;
using System.Collections;
using System.Collections.Generic;

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
            list.Remove(task);
        }
    }
}