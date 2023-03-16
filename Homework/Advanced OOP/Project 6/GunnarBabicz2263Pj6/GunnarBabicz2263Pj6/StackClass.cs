namespace GunnarBabicz2263Pj6
{
    /*******************************
    * GAB 03/14/2023 
    * Implements a stack class inheriting from the Dequeue class
    * *****************************/
    internal class StackClass<T> : DequeueClass<T>
    {
        /*******************************
        * GAB 03/14/2023 
        * Pushes a new value to the stack
        * *****************************/
        public void push(T value) {pushLeft(value); }
        /*******************************
        * GAB 03/14/2023 
        * Removes the last entered node of the stack and returns that node
        * *****************************/
        public DoubleLinkedListNode<T> pop() {return popLeft();}
    }
}


/* ----------- NOTE PLEASE READ ----------
 * Both the stack class and the Queue class are able to call methods
 * from the parent Dequeue class, which they should not be able to do.
 * From my reading, it is not possible to directly inherit in C# 
 * and only allow some methods of the parent class. The only fix to 
 * this is overriding the unwanted class and throwing an exception.
 * As the prompt for Project 6 specifically states
 * QueueClass and StackClass need to inherit directly from the 
 * Dequeue class, this is the way I have done the code.
 * 
 * If other methods were allowed, the following could be a way to 
 * still inherit methods from Dequeue while not allowing its arguments:
 * 
 * 1. Using nested classes within the dequeue class with an instance of the
 * Dequeue to access the outer methods (similar to how the dequeue class has
 * an instance)
 */