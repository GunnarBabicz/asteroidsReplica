using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GunnarBabicz2263Pj5
{
    /* Gunnar Babicz 02/27/2023
    * Implements a doubly linked list with included methods.
    * Still needs to be made generic */
    internal class DoubleLinkedList<T>

    {
        /* ----- INSTANCE VARIABLES ----- */
        public DoubleLinkedListNode<T>? head = null;
        public DoubleLinkedListNode<T>? tail = null;
        public DoubleLinkedListNode<T>? currentNode = null;
        private int size = 0;
        private string displayString = "";
        public DoubleLinkedList() { }
        public DoubleLinkedList(T firstValue) { insertFirstNode(firstValue); }
        /*******************************
        * Gunnar Babicz 02/27/2023
        * returns the number of nodes as a string to be able to put into textbox */
        public string numberOfNodesInList() { return size.ToString(); }
        /*******************************
        * Gunnar Babicz 02/27/2023
        *  returns the value of the current node as a string */
        public string CurrentNodeString() 
        {
            if (size > 0) { return currentNode.valueAsString(); }
            else { return ""; }
        }
        /* ----- ADDING NODES ----- */
 
        /*******************************
        * Gunnar Babicz 02/27/2023
        *  Inserts the first node into the doubly linked list */
        public void insertFirstNode(T firstValue)
        {
            if (size == 0)
            { // if the node will actually be the first value in the doubly linked list
                DoubleLinkedListNode<T>? firstNode = new(firstValue);
                head = firstNode;
                tail = firstNode;
                currentNode = firstNode;
                size += 1;
            }
            else { Popup.Error("Already added first node"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Inserts a new node at the head of the list */
        public void insertNewHead(T nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 
                DoubleLinkedListNode<T>? newHead = new(nodeValue);
                newHead.nextNode = head;
                head.previousNode = newHead;
                head = newHead;
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Inserts a new node at the tail of the list */
        public void insertNewTail(T nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 

                // set nodes for new tail
                DoubleLinkedListNode<T>? newTail = new(nodeValue);
                newTail.previousNode = tail;

                // update nodes for the old tail
                tail.nextNode = newTail;
                tail = newTail;

                // increasing the size of the list
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Inserts a new node after the currently selected node */
        public void insertNodeAfterCurrent(T nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 
                DoubleLinkedListNode<T>? newNode = new(nodeValue);

                // creates the new node's references
                newNode.nextNode = currentNode.nextNode;
                newNode.previousNode = currentNode;
                currentNode.nextNode = newNode;

                // if the new node ends up being the tail
                if (newNode.nextNode == null) { tail = newNode; }
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }
        /* ----- MOVING CURRENT NODE ----- */

        /* Gunnar Babicz 02/27/2023
        * moves the currently selected node to the next node */
        public void currentToNext()
        {
            if (size > 0)
            { // if the list isn't empty
                if (currentNode.nextNode != null)
                { // if there is a next node
                    currentNode = currentNode.nextNode;
                }
                else { Popup.Error("Already at end of list. Cannot move further"); }
            }
            else { Popup.Error("List is empty"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Moves the currently selected node to the previous node */
        public void currentToPrevious()
        {
            if (size > 0)
            { // if the list isn't empty
                if (currentNode.previousNode != null) 
                { // if there is a previous node
                    currentNode = currentNode.previousNode;
                }
                else { Popup.Error("Already at beginning of list. cannot move further"); }
            }
            else { Popup.Error("List is empty"); }
        }
        /* ----- DELETING NODES ----- */

        /* Gunnar Babicz 02/27/2023
        * deletes the head of the list */
        public void deleteHead()
        {
            if (size > 1) 
            { // if the head is not the only node
                head = head.nextNode;
                head.previousNode = null;
                size -= 1;
            }
            else { deleteOnly();  }
        }
        /* Gunnar Babicz 02/27/2023
        * deletes the tail of the list */
        public void deleteTail()
        {
            if (size > 1)
            { // if the tail is not the only node
                tail = tail.previousNode;
                tail.nextNode = null;
                size -= 1;
            }
            else { deleteOnly(); }
        }
        /* Gunnar Babicz 02/28/2023
        * deletes the only node in the list */
        public void deleteOnly() 
        { // deletes by setting all parameters to default
            if (size == 1) 
            {
                currentNode = new DoubleLinkedListNode<T>();
                size -= 1;
            }
            
        }
        /* Gunnar Babicz 02/28/2023
        * Deletes the currently selected node
        * *****************************/
        public void deleteCurrent()
        {
            // if the list has only one node
            if (size == 1) { deleteOnly(); }
            if (size > 1) 
            {
                if (currentNode.nextNode is null) { currentToPrevious();  deleteTail(); }
                else if (currentNode.previousNode is null) { currentToNext(); deleteHead(); }
                else 
                {
                    DoubleLinkedListNode<T> tempNode = currentNode.nextNode;
                    currentToPrevious();
                    currentNode.nextNode = tempNode;
                    size -= 1;
                }
            }  
        }
        /* ----- RECURSIVE FUNCTIONS ----- */

        /* Gunnar Babicz 02/27/2023
        * Finds the first node that is not null */
        public DoubleLinkedListNode<T> findFirstNodeWithValues(DoubleLinkedListNode<T>? pointer = default)
        {
            if (pointer is null) { pointer = head; }
            if (pointer.valueAsString() == "")
            { // if the node has a null value
                if (pointer.nextNode != null)
                { // if the node wasn't the last in the list
                    findFirstNodeWithValues(pointer.nextNode);
                }
                else { Console.WriteLine("No nodes with values found"); }
            }
            return pointer;
        }
        /* Gunnar Babicz 02/27/2023
        * Returns all the values in the linked list as a string */
        public string getDisplayString(DoubleLinkedListNode<T>? pointer)
        {
            if (size == 0) { return ""; }
            if (pointer == head) { displayString = "";}
            string nodeString = pointer.valueAsString();
            displayString += nodeString + " ";
            if (pointer.nextNode != null) { getDisplayString(pointer.nextNode); }
            return displayString;
        }
    }

    internal class CopyOfDoubleLinkedList<T>

    {
        /* ----- INSTANCE VARIABLES ----- */
        public DoubleLinkedListNode<T>? head = null;
        public DoubleLinkedListNode<T>? tail = null;
        public DoubleLinkedListNode<T>? currentNode = null;
        private int size = 0;
        private string displayString = "";
        public CopyOfDoubleLinkedList() { }
        public CopyOfDoubleLinkedList(T firstValue) { insertFirstNode(firstValue); }
        /*******************************
        * Gunnar Babicz 02/27/2023
        * returns the number of nodes as a string to be able to put into textbox */
        public string numberOfNodesInList() { return size.ToString(); }
        /*******************************
        * Gunnar Babicz 02/27/2023
        *  returns the value of the current node as a string */
        public string CurrentNodeString()
        {
            if (size > 0) { return currentNode.valueAsString(); }
            else { return ""; }
        }
        /* ----- ADDING NODES ----- */

        /*******************************
        * Gunnar Babicz 02/27/2023
        *  Inserts the first node into the doubly linked list */
        public void insertFirstNode(T firstValue)
        {
            if (size == 0)
            { // if the node will actually be the first value in the doubly linked list
                DoubleLinkedListNode<T>? firstNode = new(firstValue);
                head = firstNode;
                tail = firstNode;
                currentNode = firstNode;
                size += 1;
            }
            else { Popup.Error("Already added first node"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Inserts a new node at the head of the list */
        public void insertNewHead(T nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 
                DoubleLinkedListNode<T>? newHead = new(nodeValue);
                newHead.nextNode = head;
                head.previousNode = newHead;
                head = newHead;
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Inserts a new node at the tail of the list */
        public void insertNewTail(T nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 

                // set nodes for new tail
                DoubleLinkedListNode<T>? newTail = new(nodeValue);
                newTail.previousNode = tail;

                // update nodes for the old tail
                tail.nextNode = newTail;
                tail = newTail;

                // increasing the size of the list
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Inserts a new node after the currently selected node */
        public void insertNodeAfterCurrent(T nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 
                DoubleLinkedListNode<T>? newNode = new(nodeValue);

                // creates the new node's references
                newNode.nextNode = currentNode.nextNode;
                newNode.previousNode = currentNode;
                currentNode.nextNode = newNode;

                // if the new node ends up being the tail
                if (newNode.nextNode == null) { tail = newNode; }
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }
        /* ----- MOVING CURRENT NODE ----- */

        /* Gunnar Babicz 02/27/2023
        * moves the currently selected node to the next node */
        public void currentToNext()
        {
            if (size > 0)
            { // if the list isn't empty
                if (currentNode.nextNode != null)
                { // if there is a next node
                    currentNode = currentNode.nextNode;
                }
                else { Popup.Error("Already at end of list. Cannot move further"); }
            }
            else { Popup.Error("List is empty"); }
        }
        /* Gunnar Babicz 02/27/2023
        * Moves the currently selected node to the previous node */
        public void currentToPrevious()
        {
            if (size > 0)
            { // if the list isn't empty
                if (currentNode.previousNode != null)
                { // if there is a previous node
                    currentNode = currentNode.previousNode;
                }
                else { Popup.Error("Already at beginning of list. cannot move further"); }
            }
            else { Popup.Error("List is empty"); }
        }
        /* ----- DELETING NODES ----- */

        /* Gunnar Babicz 02/27/2023
        * deletes the head of the list */
        public void deleteHead()
        {
            if (size > 1)
            { // if the head is not the only node
                head = head.nextNode;
                head.previousNode = null;
                size -= 1;
            }
            else { deleteOnly(); }
        }
        /* Gunnar Babicz 02/27/2023
        * deletes the tail of the list */
        public void deleteTail()
        {
            if (size > 1)
            { // if the tail is not the only node
                tail = tail.previousNode;
                tail.nextNode = null;
                size -= 1;
            }
            else { deleteOnly(); }
        }
        /* Gunnar Babicz 02/28/2023
        * deletes the only node in the list */
        public void deleteOnly()
        { // deletes by setting all parameters to default
            currentNode = new DoubleLinkedListNode<T>();
            size -= 1;
        }
        /* Gunnar Babicz 02/28/2023
        * Deletes the currently selected node
        * *****************************/
        public void deleteCurrent()
        {
            // if the list has only one node
            if (size == 1) { deleteOnly(); }
            if (size > 1)
            {
                if (currentNode.nextNode is null) { currentToPrevious(); deleteTail(); }
                else if (currentNode.previousNode is null) { currentToNext(); deleteHead(); }
                else
                {
                    DoubleLinkedListNode<T> tempNode = currentNode.nextNode;
                    currentToPrevious();
                    currentNode.nextNode = tempNode;
                    size -= 1;
                }
            }
        }
        /* ----- RECURSIVE FUNCTIONS ----- */

        /* Gunnar Babicz 02/27/2023
        * Finds the first node that is not null */
        public DoubleLinkedListNode<T> findFirstNodeWithValues(DoubleLinkedListNode<T>? pointer = default)
        {
            if (pointer is null) { pointer = head; }
            if (pointer.valueAsString() == "")
            { // if the node has a null value
                if (pointer.nextNode != null)
                { // if the node wasn't the last in the list
                    findFirstNodeWithValues(pointer.nextNode);
                }
                else { Console.WriteLine("No nodes with values found"); }
            }
            return pointer;
        }
        /* Gunnar Babicz 02/27/2023
        * Returns all the values in the linked list as a string */
        public string getDisplayString(DoubleLinkedListNode<T>? pointer)
        {
            if (size == 0) { return ""; }
            if (pointer == head) { displayString = ""; }
            string nodeString = pointer.valueAsString();
            displayString += nodeString + " ";
            if (pointer.nextNode != null) { getDisplayString(pointer.nextNode); }
            return displayString;
        }
    }








    /*******************************
    * dvb 2Jan23 double Linked List Node- needs to be made generic
    * class is incomplete
    * *****************************/
    internal class DoubleLinkedListNode<T>
: DoubleLinkedList<T>
    {
        private T? value = default;
        public DoubleLinkedListNode<T>? nextNode = null;
        public DoubleLinkedListNode<T>? previousNode = null;
        internal DoubleLinkedListNode(T v)
        {
            value = v;
        }
        internal DoubleLinkedListNode()
        {
            value = default;
        }

        public T? Value { get; set; }


        public string valueAsString()
        {
            try { return value.ToString(); }

            catch (NullReferenceException) { return ""; }
        }
    }
}
