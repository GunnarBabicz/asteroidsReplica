namespace Project6
{
    internal class StackClass<T> : DequeueClass<T>
    {
        public void push(T value) {pushLeft(value); }
        public DoubleLinkedListNode<T> pop() {return popLeft();}
    }
}