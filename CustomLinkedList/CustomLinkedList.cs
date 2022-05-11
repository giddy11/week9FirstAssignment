using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList1
{
    public class CustomLinkedList<T>
    {
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        
        public virtual void AddLast(T item)
        {
            AddItem(item);
        }

        
        public void AddFirst(T item)
        {
            if(Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Head;
                var first = new ListNode<T>(item,null,temp);
                Head = first;
            }
            
        }

        
        public ListNode<T> Find(T item)
        {
            for (ListNode<T> current = Head; current.NextNode != null; current = current.NextNode)
            {
                if(Equals(current.Value, item))
                {
                    return current;
                }
            }
            return null;
        }

        
        public void Remove(T item)
        {
            var nodeToRemove = Find(item);

            if (nodeToRemove is null)
            {
                return;
            }
            else if (nodeToRemove.Equals(Head))
            {
                var temp = Head.NextNode;
                Head.NextNode = null;
                Head = temp;
            }
            else if (nodeToRemove.Equals(Tail))
            {
                var temp = Tail.PreviousNode;
                Tail.PreviousNode = null;
                Tail = temp;
            }
            else
            {
                var prev = nodeToRemove.PreviousNode;
                var next = nodeToRemove.NextNode;
                if (prev != null) prev.NextNode = next;
                if (next != null) next.PreviousNode = prev;

                nodeToRemove.PreviousNode = nodeToRemove.NextNode = null;
            }
        }

        public void Remove()
        {
            if (Head == Tail)
            {
                Head = Tail = null;
            }
            else
            {
                var temp = Tail.PreviousNode;
                Tail.PreviousNode = null;
                Tail = temp;
            }
        }

        
        public void Clear()
        {
            Head = Tail = null;
        }
        public void AddItem(T item)
        {
            if (Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Tail;
                var newNode = new ListNode<T>(item, temp);
                Tail.NextNode = newNode;
                Tail = newNode;
            }
        }
        public void AddNode(ListNode<T> node)
        {
            if (Head is null)
            {
                Head = Tail = node;
            }
            else
            {
                Tail.NextNode = node;
                Tail = node;
            }

        }
    }
}
