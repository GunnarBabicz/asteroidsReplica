namespace GunnarBabicz2263Pj6
{

    /*******************************
    * GAB 03/14/2023 DequeueClass
    * Creates a double ended queue by using an instance of the 
    * DoublyLinkedList class. Inheritance is not used to prevent
    * the user from being able to call methods not consistent with
    * the data structure. 
    * *****************************/

    internal class DequeueClass<T>
    {
        // creates an instance of the DoubleLinkedList to use as the deque.
        private DoubleLinkedList<T> deque = new DoubleLinkedList<T>();

        /*******************************
        * GAB 03/14/2023 
        * Returns the size of the dequeue
        * *****************************/
        public int getSize(){return deque.size;}


        /*******************************
        * GAB 03/14/2023 
        * pushes a new value to the left (head) side of the dequeue
        * *****************************/
        public void pushLeft(T value){ deque.InsertBeforeFirst(value); }


        /*******************************
        * GAB 03/14/2023 
        * pushes a new value to the right (tail) side of the dequeue
        * *****************************/
        public void pushRight(T value) { deque.InsertAfterLast(value); }


        /*******************************
        * GAB 03/14/2023 
        * Removes the leftmost node(head) of the dequeue and returns the node
        * *****************************/
        public virtual DoubleLinkedListNode<T> popLeft()
        {
            if(deque.isEmpty() == false)
            { // if the list is not empty
                DoubleLinkedListNode<T> tempNode = deque.head;
                deque.DeleteFirst();
                return tempNode;
            }
            else{return default; }
        }


        /*******************************
        * GAB 03/14/2023 
        * Returns the rightmost node(tail) of the dequeue and returns the value
        * *****************************/
        public DoubleLinkedListNode<T> popRight()
        {
            if(deque.isEmpty() == false) 
            { // if the list is not empty
                DoubleLinkedListNode<T> tempNode = deque.tail;
                deque.DeleteLast();
                return tempNode;
            }
            else{return default;}
        }


        /*******************************
        * GAB 03/14/2023 
        * Returns the values in the dequeue as a string
        * *****************************/
        public string GetDisplayString() { return deque.GetDisplayString(); }
    

    }
}