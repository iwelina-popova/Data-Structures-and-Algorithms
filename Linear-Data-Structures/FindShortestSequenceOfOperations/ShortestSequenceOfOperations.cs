namespace FindShortestSequenceOfOperations
{
    using System;
    using System.Collections.Generic;

    public class ShortestSequenceOfOperations
    {
        public static void Main()
        {
            /*
            We are given numbers N and M and the following operations:
            N = N+1
            N = N+2
            N = N*2
            
            Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M.
            
            Hint: use a queue.
            Example: N = 5, M = 16
            Sequence: 5 → 7 → 8 → 16
            */

            FindShortestSequenceOfOperations(5, 17);
        }

        private static void FindShortestSequenceOfOperations(int firstNumber, int lastNumber)
        {
            if (lastNumber < firstNumber)
            {
                Console.WriteLine("Second number must be greater than first!");
            }

            Console.WriteLine(lastNumber);

            var operations = new Queue<string>();
            var currentNumber = lastNumber;

            while (true)
            {
                if (currentNumber / 2 >= firstNumber && currentNumber % 2 == 0)
                {
                    currentNumber /= 2;
                    operations.Enqueue("/ 2");
                }
                else if (currentNumber / 2 >= firstNumber && currentNumber % 2 == 1)
                {
                    currentNumber -= 1;
                    operations.Enqueue("- 1");
                }
                else if (currentNumber - 2 >= firstNumber)
                {
                    currentNumber -= 2;
                    operations.Enqueue("- 2");
                }
                else if (currentNumber - 1 >= firstNumber)
                {
                    currentNumber -= 1;
                    operations.Enqueue("- 1");
                }
                else
                {
                    break;
                }

                //while (true)
                //{
                //    if (currentNumber * 2 <= lastNumber)
                //    {
                //        currentNumber *= 2;
                //        operations.Enqueue("* 2");
                //    }
                //    else if (currentNumber + 2 <= lastNumber)
                //    {
                //        currentNumber += 2;
                //        operations.Enqueue("+ 2");
                //    }
                //    else if (currentNumber + 1 <= lastNumber)
                //    {
                //        currentNumber += 1;
                //        operations.Enqueue("+ 1");
                //    }
                //    else
                //    {
                //        break;
                //    }

                Console.WriteLine(operations.Dequeue());
                Console.WriteLine(currentNumber);
            }
        }
    }
}
