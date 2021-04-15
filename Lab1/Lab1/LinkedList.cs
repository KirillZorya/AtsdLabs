using System;

namespace Lab1
{
    class LinkedList<T> where T: IComparable<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        private int count;

        public LinkedListNode<T> First
        {
            get 
            { 
                return head; 
            }
        }

        public bool Empty()
        {
            return count == 0;
        }

        public int Length()
        {
            return count;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void Add(T value)
        {
            LinkedListNode<T> previous = null;
            LinkedListNode<T> current = head;

            while(current != null && current.Value.CompareTo(value) == -1)
            {
                previous = current;
                current = current.Next;
            }
            LinkedListNode<T> newNode = new LinkedListNode<T>(value);
            if(previous == null)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                previous.Next = newNode;
                newNode.Next = current;
            }
            count++;
        }
    }
}
