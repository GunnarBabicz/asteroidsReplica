namespace Project6
{

    /*******************************
    * GAB 03/08/2023 DequeueClass
    * Creates a double ended queue by using an instance of the 
    * DoublyLinkedList class. Inheritance is not used to prevent
    * the user from being able to call methods not consistent with
    * the data structure. 
    * *****************************/
    internal class DequeueClass<T>
    {
        private DoubleLinkedList<T> deque = new DoubleLinkedList<T>();

        public int getSize(){return deque.size;}
        public void pushLeft(T value){ deque.InsertBeforeFirst(value); }
        public void pushRight(T value) { deque.InsertAfterLast(value); }

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

        public string GetDisplayString() { return deque.GetDisplayString(); }
    
    }
}