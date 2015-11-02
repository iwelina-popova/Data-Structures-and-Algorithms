using System;

namespace AdtStack
{
    public class AdtStackTester
    {
        public static void Main()
        {
            /*
            Implement the ADT stack as auto-resizable array.
            Resize the capacity on demand (when no space is available to add / insert a new element).
            */

            var adtStack = new AdtStack<int>();
            adtStack.Push(100);
            adtStack.Push(20);
            adtStack.Push(600);
            adtStack.Push(10);
            adtStack.Push(69);
            adtStack.Push(14);
            adtStack.Push(235);
            adtStack.Push(4);
            adtStack.Push(67);
            adtStack.Push(88);
            adtStack.Push(99);
            adtStack.Push(8);

            Console.WriteLine("The elements in the stack is: {0}", adtStack.Count);
            Console.WriteLine("The last element: {0}", adtStack.Pop());
        }
    }
}
