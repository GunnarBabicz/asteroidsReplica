namespace GunnarBabicz2263Pj5
{
    public partial class Form1 : Form
    {

        DoubleLinkedList theList = new DoubleLinkedList();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertFirst_Click(object sender, EventArgs e)
        {
            theList.insertFirstNode(txtInput.Text);
            txtOutput.Text = theList.getDisplayString();
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
            txtCurrentNode.Text = theList.currentNode.value;
        }

        private void btnInsertHead_Click(object sender, EventArgs e)
        {
            theList.insertNewHead(txtInput.Text);
            txtOutput.Text = theList.getDisplayString();
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
        }

        private void btnInsertAfterCurrent_Click(object sender, EventArgs e)
        {
            theList.insertNodeAfterCurrent(txtInput.Text);
            txtOutput.Text = theList.getDisplayString();
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
        }

        private void btnInsertTail_Click(object sender, EventArgs e)
        {
            theList.insertNewTail(txtInput.Text);
            string pls = theList.getDisplayString();
            txtOutput.Text = pls;
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
        }

        private void btnDeleteHead_Click(object sender, EventArgs e)
        {
            theList.deleteHead();
            txtOutput.Text = theList.getDisplayString();
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
            txtCurrentNode.Text = theList.getCurrentValue();
        }

        private void btnDeleteCurrent_Click(object sender, EventArgs e)
        {
            theList.deleteCurrent();
            txtOutput.Text = theList.getDisplayString();
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
            txtCurrentNode.Text = theList.getCurrentValue();
        }

        private void btnDeleteTail_Click(object sender, EventArgs e)
        {
            theList.deleteTail();
            txtOutput.Text = theList.getDisplayString();
            txtNumberOfNodes.Text = theList.numberOfNodesInList();
            txtCurrentNode.Text = theList.getCurrentValue();
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
    }
}