namespace Project6
{
    internal class QueueClass<T> : DequeueClass<T>
    {
        public void push(T value) {pushLeft(value); }
        public DoubleLinkedListNode<T> pop() {return popRight();}
    }
}