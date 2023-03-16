namespace GunnarBabicz2263Pj6
{
    /*******************************
    * GAB 03/14/2023 
    * Implementation of a Queue data structure inheriting from the Dequeue class
    * *****************************/
    internal class QueueClass<T> : DequeueClass<T>
    {
        /*******************************
        * GAB 03/14/2023 
        * Pushes new value to the queue
        * *****************************/
        public void push(T value) {pushLeft(value); }

        /*******************************
        * GAB 03/14/2023 
        * Removes the node entered first into the queue and returns the node
        * *****************************/
        public DoubleLinkedListNode<T> pop() {return popRight();}
    }
}