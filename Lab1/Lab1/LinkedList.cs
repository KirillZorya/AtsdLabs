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
    }
}
