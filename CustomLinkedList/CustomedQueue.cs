using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class CustomedQueue<T> : CustomLinkedList<T>
    {
        public CustomedQueue()
        {
            var queue = new Queue<T>();
        }

        public void Enqueue(T value)
        {
            AddLast(value);   
        }

        public T Dequeue()
        {
            Remove();

            return default(T);
        }
    }
}
