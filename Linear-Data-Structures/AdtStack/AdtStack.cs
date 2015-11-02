namespace AdtStack
{
    using System;

    public class AdtStack<T>
    {
        private const int defaultSize = 4;

        private T[] array;
        private int capacity;
        private int index;

        public AdtStack()
            : this(defaultSize)
        {

        }

        public AdtStack(int size)
        {
            this.capacity = size;
            this.index = -1;
            this.array = new T[this.capacity];
        }

        public int Count
        {
            get { return this.index + 1; }
        }

        public void Push(T element)
        {
            ++this.index;
            if (this.Count >= 0.75 * this.capacity)
            {
                this.array = ResizeArray();
            }

            this.array[index] = element;
        }

        public T Peek()
        {
            return this.array[this.Count];
        }

        public T Pop()
        {
            if (this.index < 0)
            {
                throw new NullReferenceException("The stack does not contain any elements.");
            }
            else
            {
                this.index--;
                return this.array[this.Count];
            }
        }

        private T[] ResizeArray()
        {
            this.capacity *= 2;
            var newArray = new T[this.capacity];

            for (int i = 0; i < this.array.Length; i++)
            {
                newArray[i] = this.array[i];
            }

            return newArray;
        }
    }
}
