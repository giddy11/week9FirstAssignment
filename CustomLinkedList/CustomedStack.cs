using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class CustomedStack<T> : CustomLinkedList<T>
    {
        public CustomedStack()
        {
        }

        public void Push(T value)
        {
            var stack = new Stack<T>();
            AddItem(value);
            Count++;
        }
        public T Pop()
        {            
            if(Count == 0)
            {
                Console.WriteLine("Stack is empty!");
            }
            else
            {
                Remove();
                Count--;
            }
            return default(T);
        }

        public int Count { get; private set; }
        public List<T> stackValue;
    }
}
