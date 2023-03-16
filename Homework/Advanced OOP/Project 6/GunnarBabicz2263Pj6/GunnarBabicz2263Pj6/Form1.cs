namespace GunnarBabicz2263Pj6
{
    /*******************************
    * GAB 03/14/2023 
    * Creates the windows form application
    * with associated methods
    * *****************************/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Popup test = new Popup();
        // created instances of the class types
        StackClass<int> stack = new StackClass<int>();
        QueueClass<int> queue = new QueueClass<int>();
        DequeueClass<int> dequeue = new DequeueClass<int>();

        // creates a Random object for random number generation
        Random rnd = new Random();





        // STACK ----------------------------------------------------------------

        /*******************************
        * GAB 03/14/2023 
        * updates the stack text box
        * *****************************/
        private void updateStack() { txtStackContents.Text = stack.GetDisplayString(); }

        /*******************************
        * GAB 03/14/2023 
        * runs the stack pop function
        * *****************************/
        private void btnStackPop_Click(object sender, EventArgs e)
        {
            DoubleLinkedListNode<int> poppedNode = stack.pop();
            if (poppedNode != null) { txtStackPop.Text = poppedNode.value.ToString(); }
            else 
            {
                txtStackPop.Text = "";
                Popup.Error("Cannot pop. Stack is already empty");
            }
            updateStack();
        }

        /*******************************
        * GAB 03/14/2023 
        * adds a random number to the stack
        * *****************************/
        private void btnStackPushRandom_Click(object sender, EventArgs e)
        {
            int randomValue = rnd.Next(100);
            stack.push(randomValue);
            updateStack();
        }

        /*******************************
        * GAB 03/14/2023 
        * clears the stack
        * *****************************/
        private void btnClearStack_Click(object sender, EventArgs e)
        {
            stack = new StackClass<int>();
            txtStackPop.Text = "";
            updateStack();
        }



        // DEQUEUE --------------------------------------------------------------------
        /*******************************
        * GAB 03/14/2023 
        * updates the dequeue text box
        * *****************************/
        private void updateDequeue() { txtDequeueContents.Text = dequeue.GetDisplayString(); }

        /*******************************
        * GAB 03/14/2023 
        * pushes random number to left side of dequeue
        * *****************************/
        private void btnDequeuePushRandomLeft_Click(object sender, EventArgs e)
        {
            int randomValue = rnd.Next(100);
            dequeue.pushLeft(randomValue);
            updateDequeue();
        }

        /*******************************
        * GAB 03/14/2023 
        * pushes random number to right side of dequeue
        * *****************************/
        private void btnDequeuePushRandomRight_Click(object sender, EventArgs e)
        {
            int randomValue = rnd.Next(100);
            dequeue.pushRight(randomValue);
            updateDequeue();
        }

        /*******************************
        * GAB 03/14/2023 
        * pops left side of dequeue
        * *****************************/
        private void btnDequeuePopLeft_Click(object sender, EventArgs e)
        {
            DoubleLinkedListNode<int> poppedNode = dequeue.popLeft();
            if (poppedNode != null) { txtDequeuePop.Text = poppedNode.value.ToString(); }
            else
            {
                txtDequeuePop.Text = "";
                Popup.Error("Cannot pop. Dequeue is already empty");
            }
            updateDequeue();
        }

        /*******************************
        * GAB 03/14/2023 
        * pops right side of dequeue
        * *****************************/
        private void btnDequeuePopRight_Click(object sender, EventArgs e)
        {
            DoubleLinkedListNode<int> poppedNode = dequeue.popRight();
            if (poppedNode != null) { txtDequeuePop.Text = poppedNode.value.ToString(); }
            else
            {
                txtDequeuePop.Text = "";
                Popup.Error("Cannot pop. Dequeue is already empty");
            }
            updateDequeue();
        }

        /*******************************
        * GAB 03/14/2023 
        * clears the dequeue 
        * *****************************/
        private void btnClearDequeue_Click(object sender, EventArgs e)
        {
            dequeue = new DequeueClass<int>();
            txtDequeuePop.Text = "";
            updateDequeue();
        }

        // Queue ----------------------- 


        /*******************************
        * GAB 03/14/2023 
        * updates the queue text box
        * *****************************/

        private void updateQueue() { txtQueueContents.Text = queue.GetDisplayString(); }


        /*******************************
        * GAB 03/14/2023 
        * updates the queue text box
        * *****************************/
        private void btnQueuePushRandom_Click(object sender, EventArgs e)
        {
            int randomValue = rnd.Next(100);
            queue.push(randomValue);
            updateQueue();
        }

        /*******************************
        * GAB 03/14/2023 
        * Removes and returns the first entered node in the queue
        * *****************************/
        private void btnQueuePop_Click(object sender, EventArgs e)
        {
            DoubleLinkedListNode<int> poppedNode = queue.pop();
            if (poppedNode != null) { txtQueuePop.Text = poppedNode.value.ToString(); }
            else
            {
                txtQueuePop.Text = "";
                Popup.Error("Cannot pop. Queue is already empty");
            }
            updateQueue();
        }

        /*******************************
        * GAB 03/14/2023 
        * Clears the queue
        * *****************************/
        private void btnClearQueue_Click(object sender, EventArgs e)
        {
            queue = new QueueClass<int>();
            txtQueuePop.Text = "";
            updateQueue();
        }
    }
}