using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunnarBabicz2263Pj5
{
    /*******************************
    * Gunnar Babicz 02/27/2023
    * Implements a doubly linked list with included methods.
    * Still needs to be made generic
    * *****************************/
    internal class DoubleLinkedList

    {
        /* ----- INSTANCE VARIABLES ----- */
        public DoubleLinkedListNode? head = null;
        public DoubleLinkedListNode? tail = null;
        public DoubleLinkedListNode? currentNode = null;
        private int size = 0;
        private string displayString = "";

        public DoubleLinkedList() { }
        public DoubleLinkedList(string firstValue) { insertFirstNode(firstValue); }

        // returns the number of nodes as a string to be able to put into textbox
        public string numberOfNodesInList() { return size.ToString(); }


        /*******************************
        * Gunnar Babicz 02/27/2023
        *  Returns the value of the current node as a string.
        *  If no current value, returns empty string
        * *****************************/
        public string getCurrentValue() 
        {
            if(currentNode != null) { return currentNode.value; }
            else { return ""; }
        }

        /* ----- ADDING NODES ----- */

        // Potential: Create yes/no option to add as first node or abort if list
        // is empty

        /*******************************
        * Gunnar Babicz 02/27/2023
        *  Inserts the first node into the doubly linked list
        * *****************************/
        public void insertFirstNode(string firstValue)
        {
            if (size == 0)
            { // if the node will actually be the first value in the doubly linked list
                DoubleLinkedListNode firstNode = new(firstValue);
                head = firstNode;
                tail = firstNode;
                currentNode = firstNode;
                size += 1;
            }
            else { Popup.Error("Already added first node"); }

        }

        /*******************************
        * Gunnar Babicz 02/27/2023
        * Inserts a new node at the head of the list 
        * *****************************/
        public void insertNewHead(string nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 
                DoubleLinkedListNode newHead = new(nodeValue);
                newHead.nextNode = head;
                head.previousNode = newHead;
                head = newHead;
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }

        /*******************************
        * Gunnar Babicz 02/27/2023
        * Inserts a new node at the tail of the list
        * *****************************/
        public void insertNewTail(string nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 

                // set nodes for new tail
                DoubleLinkedListNode newTail = new(nodeValue);
                newTail.previousNode = tail;

                // update nodes for the old tail
                tail.nextNode = newTail;
                tail = newTail;

                // increasing the size of the list
                size += 1;
            }
            else { Popup.Error("List is empty. No reference to add new node"); }
        }

        /*******************************
        * Gunnar Babicz 02/27/2023
        * Inserts a new node after the currently selected node
        * *****************************/
        public void insertNodeAfterCurrent(string nodeValue)
        {
            if (size > 0)
            { // If the list isn't empty 
                DoubleLinkedListNode newNode = new(nodeValue);

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

        /*******************************
        * Gunnar Babicz 02/27/2023
        *
        * *****************************/
        public void currentToNext()
        {
            if (size > 0)
            {
                if (currentNode.nextNode != null)
                { // if there is a next node
                    currentNode = currentNode.nextNode;
                }
                else { Popup.Error("Already at end of list. Cannot move further"); }
            }
            else { Popup.Error("List is empty"); }
        }

        /*******************************
        * Gunnar Babicz 02/27/2023
        *
        * *****************************/
        public void currentToPrevious()
        {
            if (size > 0)
            {
                if (currentNode.previousNode != null) 
                { // if there is a previous node
                    currentNode = currentNode.previousNode;
                }
                else { Popup.Error("Already at beginning of list. cannot move further"); }
            }
            else { Popup.Error("List is empty"); }
        }

        /* ----- DELETING NODES ----- */

        /*******************************
        * Gunnar Babicz 02/27/2023
        *
        * *****************************/
        public void deleteHead()
        {
            if (size > 1) 
            {
                head = head.nextNode;
                head.previousNode = null;
                size -= 1;
            }
            else { Popup.Error("Unable to delete. List too small");  }
        }


        /*******************************
        * Gunnar Babicz 02/27/2023
        * deletes the tail of the list
        * *****************************/
        public void deleteTail()
        {
            if (size > 1)
            {
                tail = tail.previousNode;
                tail.nextNode = null;
                size -= 1;
            }
            else { Popup.Error("Unable to delete. List too small"); }
        }


        /*******************************
        * Gunnar Babicz 02/27/2023
        * Deletes the current node
        * *****************************/


        // work on the delete current, blowing up 
        public void deleteCurrent()
        {
            if (size > 0)
            {
                if (currentNode.nextNode != null)
                { // if there is a next node
                    DoubleLinkedListNode tempNode = currentNode.nextNode;
                    currentNode = currentNode.previousNode;
                    currentNode.nextNode = tempNode;
                }

                else if (currentNode.previousNode != null)
                { // if there is a previous node
                    DoubleLinkedListNode tempNode = currentNode.previousNode;
                    currentNode = currentNode.nextNode;
                    currentNode.previousNode = tempNode;
                }

                else 
                { // if current node is the only node
                    currentNode = null;
                    head = null;
                    tail = null;
                }
                size -= 1;
            }
            else { Popup.Error("Nothing to delete."); }
        }



        /* ----- RECURSIVE FUNCTIONS ----- */


        /*******************************
        * Gunnar Babicz 02/27/2023
        * Finds the first node that is not null
        * *****************************/
        public DoubleLinkedListNode findFirstNodeWithValues(DoubleLinkedListNode? pointer = null)
        {
            if (pointer is null) { pointer = head; }
            if (pointer.value == null)
            { // if the node has no value

                if (pointer.nextNode != null)
                { // if the node wasn't the last in the list
                    findFirstNodeWithValues(pointer.nextNode);
                }
                else { Console.WriteLine("No nodes with values found"); }
            }
            return pointer;
        }

        /*******************************
        * Gunnar Babicz 02/27/2023
        * Returns all the values in the linked list as a string
        * *****************************/
        public string getDisplayString(DoubleLinkedListNode? pointer = null)
        {
            if (pointer is null) 
            { // if first iteration
                if (head is null) 
                { // if the list is empty
                    return ""; 
                }
                pointer = head; displayString = "";
            }
            // if the current node has a value
            if (pointer.value != null) { displayString += pointer.value + " "; }
            // if the current node is not the tail
            if (pointer.nextNode != null) { getDisplayString(pointer.nextNode); }
            // returns displayString when the end of the list is reached
            return displayString;
        }
    }

    /*******************************
    * dvb 2Jan23 double Linked List Node- needs to be made generic
    * class is incomplete
    * *****************************/
    internal class DoubleLinkedListNode
    {
        public string? value = null;
        public DoubleLinkedListNode? nextNode = null;
        public DoubleLinkedListNode? previousNode = null;
        public DoubleLinkedListNode(string v)
        {
            value = v.ToLower();
        }
        private DoubleLinkedListNode()
        {
            value = null;
        }
    }
}
