
namespace GunnarBabicz2263Pj6
{


    /*******************************
    * GAB 03/14/2023 
    * Adapted the example DoubleLinkedList from class as I did not feel
    * my class was implemented properly. Made minor adjustments and changed
    * variable names. 
    * *****************************/
    internal class DoubleLinkedList<T>
    {
        public DoubleLinkedListNode<T> head = null;
        public DoubleLinkedListNode<T> tail = null;
        public DoubleLinkedListNode<T> currentNode = null;

        public int size = 0;
        public DoubleLinkedList(){}

        // creates first node in list with firstValue
        public DoubleLinkedList(T firstValue)
        {
            head = new DoubleLinkedListNode<T>(firstValue);
            tail = head;
            currentNode = head;
            size = 1;
        }

        public DoubleLinkedListNode<T> GetCurrentNode()
        {
            return currentNode;
        }


        public bool isEmpty()
        {
            if(size == 0) { return true; }
            else { return false; }
        }
    /*******************************
    * GAB 03/08/2023 InsertFirst
    * Inserts a new node with the specified value at the beginning of the list.
    * Modified, removed the line resetting the
    * current node to the head if the list is not empty
    * *****************************/
        public void InsertFirst(T value)
        {
            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);

            if (isEmpty())
            { // if the list is empty
                head = newNode;
                tail = head;
                currentNode = head;
            }
            else
            { // if the list is not empty
                newNode.next = head;
                head.previous = newNode;
                head = newNode;
            }

            size++;
        }
        /*******************************
    * XX Feb2023 InsertBeforeFirst
    * Inserts a new node with the specified value before the first node in the list.
    * *****************************/
        public void InsertBeforeFirst(T value)
        {
            if (head == null)
            {
                InsertFirst(value);
                return;
            }

            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            newNode.next = head;
            head.previous = newNode;
            head = newNode;
            size++;
        }
        /*******************************
    * XX Feb2023 InsertAfterLast
    * Inserts a new node with the specified value after the last node in the list.
    * *****************************/
        public void InsertAfterLast(T value)
        {
            if (tail == null)
            {
                InsertFirst(value);
                return;
            }

            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            tail.next = newNode;
            newNode.previous = tail;
            tail = newNode;
            currentNode = tail;
            size++;
        }
        /*******************************
    * XX Feb2023 InsertAfterCurrent
    * Inserts a new node with the specified value after the current node in the list.
    * *****************************/
        public void InsertAfterCurrent(T value)
        {
            if (currentNode == null)
            {
                InsertFirst(value);
                return;
            }

            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
            newNode.next = currentNode.next;
            newNode.previous = currentNode;
            if (currentNode.next != null)
            {
                currentNode.next.previous = newNode;
            }
            currentNode.next = newNode;
            currentNode = newNode;
            if (tail == currentNode.previous)
            {
                tail = currentNode;
            }
            size++;
        }
        /********************************

    XX Feb2023 NumberOfNodesInList
    Returns the number of nodes in the linked list
    *********************************/
        public int NumberOfNodesInList()
        {
            return size;
        }

        /********************************
    XX Feb2023 DeleteFirst
    Deletes the first node in the linked list
    *********************************/
        public void DeleteFirst()
        {
            if (head == null)
            {
                return;
            }

            if (head.next == null)
            {
                head = null;
                tail = null;
                currentNode = null;
            }
            else
            {
                head = head.next;
                head.previous = null;
                currentNode = head;
            }
            size--;
        }
        /********************************

    XX Feb2023 DeleteLast
    Deletes the last node in the linked list
    *********************************/
        public void DeleteLast()
        {
            if (tail == null)
            {
                return;
            }

            if (tail.previous == null)
            {
                head = null;
                tail = null;
                currentNode = null;
            }
            else
            {
                tail = tail.previous;
                tail.next = null;
                currentNode = tail;
            }
            size--;
        }

        /********************************

    XX Feb2023 DeleteCurrent
    Deletes the current node in the linked list
    *********************************/
        public void DeleteCurrent()
        {
            if (currentNode == null)
            {
                return;
            }

            if (currentNode.previous == null)
            {
                DeleteFirst();
                return;
            }

            if (currentNode.next == null)
            {
                DeleteLast();
                return;
            }

            currentNode.previous.next = currentNode.next;
            currentNode.next.previous = currentNode.previous;
            currentNode = currentNode.next;
            size--;
        }

        /********************************

    XX Feb2023 MoveToNext
    Moves the current node to the next node in the linked list
    *********************************/
        public void MoveToNext()
        {
            if (currentNode == null || currentNode.next == null)
            {
                return;
            }

            currentNode = currentNode.next;
        }

        /********************************

    XX Feb2023 MoveToPrevious
    Moves the current node to the previous node in the linked list
    *********************************/

        public void MoveToPrevious()
        {
            if (currentNode == null || currentNode.previous == null)
            {
                return;
            }

            currentNode = currentNode.previous;
        }
        /********************************

    XX Feb2023 Find/FindRecursive
        *finds a value in a list and tells you where it is,
        *or says it's not there. It checks each item in the list until it finds a match,
        *and keeps doing this until it finishes the list or finds the value.
    *********************************/

        public DoubleLinkedListNode<T> Find(T value)
        {
            return FindRecursive(head, value);
        }

        private DoubleLinkedListNode<T> FindRecursive(DoubleLinkedListNode<T> node, T value)
        {
            if (node == null)
            {
                return null;
            }

            if (node.value.Equals(value))
            {
                return node;
            }

            return FindRecursive(node.next, value);
        }

        /********************************

    XX Feb2023 GetDisplayString/Recursive
    Returns a string representation of the linked list
    *********************************/
        public string GetDisplayString()
        {
            if (head == null)
            {
                return "";
            }

            return GetDisplayStringRecursive(head);
        }

        private string GetDisplayStringRecursive(DoubleLinkedListNode<T> node)
        {
            if (node == null)
            {
                return "";
            }

            string result = node.value.ToString() + " ";
            result += GetDisplayStringRecursive(node.next);
            return result;
        }

    }

    internal class DoubleLinkedListNode<T>
    {
        public T value;
        public DoubleLinkedListNode<T> next = null;
        public DoubleLinkedListNode<T> previous = null;

        public DoubleLinkedListNode(T value)
        {
            this.value = value;
            previous = null;
            next = null;
        }

        private DoubleLinkedListNode()
        {
            value = default(T);
        }
    }
}