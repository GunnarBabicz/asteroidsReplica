namespace GunnarBabicz2263Pj5
{

    /*******************************
    * Gunnar Babicz 02/27/2023
    * Creates an interactive window to test the functions of the 
    * doubly linked list. 
    * *****************************/
    public partial class Form1 : Form
    {

        private void updateText() 
        {
            txtOutput.Text = theList.getDisplayString(theList.head);
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
            txtCurrentNode.Text = theList.CurrentNodeString();
        }


        // initializes a new empty doubly linked list
        DoubleLinkedList<string> theList = new DoubleLinkedList<string>();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNextNode_Click(object sender, EventArgs e)
        {
            theList.currentToNext();
            txtCurrentNode.Text = theList.currentNode.valueAsString();
        }

        private void btnPreviousNode_Click(object sender, EventArgs e)
        {
            theList.currentToPrevious();
            txtCurrentNode.Text = theList.currentNode.valueAsString();
        }


        /*******************************
        * Gunnar Babicz 02/28/2023
        * If any of the insert buttons are clicked. 
        * *****************************/
        private void anyDeleteButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnDeleteHead":
                    theList.deleteHead();
                    break;
                case "btnDeleteTail":
                    theList.deleteTail();
                    break;
                default:
                    theList.deleteCurrent();
                    break;
            }
            updateText();
        }


        /*******************************
        * Gunnar Babicz 02/28/2023
        * If any of the insert buttons are clicked. 
        * *****************************/
        private void anyInsertButton_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Name)
            {
                case "btnInsertHead":
                    theList.insertNewHead(txtInput.Text);
                    break;

                case "btnInsertTail":
                    theList.insertNewTail(txtInput.Text);
                    break;

                case "btnInsertAfterCurrent":
                    theList.insertNodeAfterCurrent(txtInput.Text);
                    break;

                default:
                    theList.insertFirstNode(txtInput.Text);
                    break;
            }
            updateText();
        }
    }
}