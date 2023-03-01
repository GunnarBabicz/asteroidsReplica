namespace GunnarBabicz2263Pj5
{
    public partial class Form1 : Form
    {

        private void updateText() 
        {
            txtOutput.Text = theList.getDisplayString();
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
            txtCurrentNode.Text = theList.currentNode.value;
        }


        // initializes a new empty doubly linked list
        DoubleLinkedList theList = new DoubleLinkedList();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnNextNode_Click(object sender, EventArgs e)
        {
            theList.currentToNext();
            txtCurrentNode.Text = theList.getCurrentValue();
        }

        private void btnPreviousNode_Click(object sender, EventArgs e)
        {
            theList.currentToPrevious();
            txtCurrentNode.Text = theList.getCurrentValue();
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