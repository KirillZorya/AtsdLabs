namespace Lab1
{
    class LinkedListNode<T>
    {
        public T Value;
        public LinkedListNode<T> Next;

        public LinkedListNode(T value, LinkedListNode<T> next=null)
        {
            Value = value;
            Next = next;
        } 
    }
}
