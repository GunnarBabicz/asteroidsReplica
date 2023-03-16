namespace Project6
{
    class test
    {
        static void Main(string[] args) 
        {

            DequeueClass<int> deck = new DequeueClass<int>();
            QueueClass<int> queue = new QueueClass<int>();
            StackClass<int> stack = new StackClass<int>();

            queue.push(1);
            queue.push(2);
            queue.push(3);

            DoubleLinkedListNode<int>test = queue.pop();
            Console.WriteLine(test.value);
            Console.WriteLine("---");
            test = queue.pop();
            Console.WriteLine(test.value);
            Console.WriteLine("---");
            test = queue.pop();
            Console.WriteLine(test.value);
            Console.WriteLine("---");
            test = queue.pop();
            Console.WriteLine(test.value);

        }
    }
}