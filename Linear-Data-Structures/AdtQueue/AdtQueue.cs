using System.Collections.Generic;

namespace AdtQueue
{
    public class AdtQueue<T>
    {
        private LinkedList<T> queue;

        public AdtQueue()
        {
            this.queue = new LinkedList<T>();
        }

        public void Enqueue(T element)
        {
            this.queue.AddFirst(element);
        }

        public T Dequeue()
        {
            var currentElement = this.queue.Last;
            this.queue.RemoveLast();
            return currentElement.Value;
        }

        public T Peek()
        {
            return this.queue.Last.Value;
        } 
    }
}
