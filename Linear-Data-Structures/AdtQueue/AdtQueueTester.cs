namespace AdtQueue
{
    using System;

    public class AdtQueueTester
    {
        public static void Main()
        {
            /*
            Implement the ADT queue as dynamic linked list.
            Use generics (LinkedQueue<T>) to allow storing different data types in the queue.
            */

            var queue = new AdtQueue<int>();
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            queue.Enqueue(10);

            Console.WriteLine(queue.Dequeue());
        }
    }
}
