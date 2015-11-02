namespace ReverseIntegersUsingStack
{
    using System;
    using System.Collections.Generic;

    public class IntegerReverserUsingStack
    {
        public static void Main()
        {
            /*
            Write a program that reads N integers from the console and reverses them using a stack.
            Use the Stack<int> class.
            */

            Console.WriteLine("Program that reads N integers from the console and reverses them using a stack.\n");
            Console.Write("Please enter your N: ");
            int n = int.Parse(Console.ReadLine());

            var integerStack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                var currentNumber = int.Parse(Console.ReadLine());

                integerStack.Push(currentNumber);
            }

            Console.WriteLine("Reversed numbers:");
            while (integerStack.Count > 0)
            {
                var numberFromStack = integerStack.Pop();

                Console.WriteLine(numberFromStack);
            }
        }
    }
}
