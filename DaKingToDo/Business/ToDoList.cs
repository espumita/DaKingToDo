using System.Collections;
using System.Collections.Generic;

namespace DaKingToDo.Business
{
    public class ToDoList : IEnumerable<string>
    {
        private List<string> list;

        public ToDoList()
        {
            list = new List<string>();
        }

        public IEnumerator<string> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}