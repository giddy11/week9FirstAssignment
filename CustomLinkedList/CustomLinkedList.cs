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

        public void AddLast(T item)
        {

            if (Head is null)
            {
                Head = Tail = new ListNode<T>(item);
            }
            else
            {
                var temp = Tail;
                var newNode = new ListNode<T>(item, temp);
                ListNode<T> current = Head;

                while (current.NextNode != null)
                {
                    current = current.NextNode;
                }
                current.NextNode = new ListNode<T>(item, temp);
                Tail.NextNode = newNode;
                Tail = newNode;
            }
        }
        public void AddFirst(T item)
        {
            ListNode<T> first = new ListNode<T>(item);
            first.NextNode = Head;
            Head = first;
        }
        public void Find(T item)
        {
            if (Head is null)
            {
                Console.WriteLine("Lisy is Empty");
            }

        }

        public void Remove(T item)
        {

            ListNode<T> currentNode = Head;
            while (currentNode != null)
            {
                if (Head.Value == item)
                {
                    Head = null;
                    Head = currentNode;
                }
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
