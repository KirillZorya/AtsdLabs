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

        public void Delete(LinkedListNode<T> node)
        {
            LinkedListNode<T> current = head;
            LinkedListNode<T> previous = null;

            if(node == null)
            {
                Console.WriteLine("This element wasn`t found at the list");
                return;
            }
            while(current != null)
            {
                if (current.Value.Equals(node.Value))
                {
                    if(previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                        {
                            tail = previous;
                        }
                    }
                    else
                    {
                        head = head.Next;
                        if(head == null)
                        {
                            tail = null;
                            break;
                        }
                    }
                    count--;
                }
                previous = current;
                current = current.Next;
            }
        }
        public LinkedListNode<T> Find(T value)
        {
            LinkedListNode<T> temp = head;
            while(temp != null)
            {
                if(temp.Value.CompareTo(value) == 0)
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public void Print(LinkedList<T> list)
        {
            var node = list.First;
            while(node != null)
            {
                Console.Write(node.Value + " ");
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
