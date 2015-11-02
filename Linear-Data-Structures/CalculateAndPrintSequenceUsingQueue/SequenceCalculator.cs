namespace CalculateAndPrintSequenceUsingQueue
{
    using System;
    using System.Collections.Generic;

    public class SequenceCalculator
    {
        public static void Main()
        {
            /*
            We are given the following sequence:
            S1 = N;
            S2 = S1 + 1;
            S3 = 2*S1 + 1;
            S4 = S1 + 2;
            S5 = S2 + 1;
            S6 = 2*S2 + 1;
            S7 = S2 + 2;
            ...
            Using the Queue<T> class write a program to print its first 50 members for given N.
            Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
            */

            var result = CalculateSequence(2, 50);
            Console.WriteLine(string.Join(", ", result));
        }

        private static List<int> CalculateSequence(int firstNumber, int sequeceLength)
        {
            var result = new List<int>();
            var queue = new Queue<int>();
            queue.Enqueue(firstNumber);

            var counter = 0;
            while (counter < sequeceLength)
            {
                var element = queue.Dequeue();

                result.Add(element);

                queue.Enqueue(element + 1);
                queue.Enqueue((2 * element) + 1);
                queue.Enqueue(element + 2);

                counter += 3;
            }

            while (queue.Count > 0)
            {
                result.Add(queue.Dequeue());
            }

            return result;
        }
    }
}
