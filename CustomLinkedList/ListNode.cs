using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            Value = value;
        }
        public ListNode(T value, ListNode<T> previousNode) : this(value)
        {
            PreviousNode = previousNode;
        }

        public ListNode(T value, ListNode<T> previousNode, ListNode<T> nextNode) : this(value, previousNode)
        {
            NextNode = nextNode;
        }

        public T Value { get; set; }
        public ListNode<T> PreviousNode { get; set; }
        public ListNode<T> NextNode { get; set; }
    }
}
