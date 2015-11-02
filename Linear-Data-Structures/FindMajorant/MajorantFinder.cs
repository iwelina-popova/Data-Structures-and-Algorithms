namespace FindMajorant
{
    using System;
    using System.Collections.Generic;

    public class MajorantFinder
    {
        public static void Main()
        {
            /*
            The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.
            Write a program to find the majorant of given array (if exists).
            Example:
            {2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
            */

            var numbers = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            FindMajorant(numbers);
        }

        private static void FindMajorant(int[] numbers)
        {
            var numbersAsDictonary = new Dictionary<int, int>();
            for (int i = 1; i < numbers.Length; i++)
            {
                if (!numbersAsDictonary.ContainsKey(numbers[i]))
                {
                    numbersAsDictonary.Add(numbers[i], 1);
                }
                else
                {
                    numbersAsDictonary[numbers[i]]++;
                }
            }

            int majorant = 0;
            var minTimes = (numbers.Length / 2) + 1;
            var maxTimes = 0;
            foreach (var pair in numbersAsDictonary)
            {
                var currentTimes = pair.Value;
                if (currentTimes >= minTimes)
                {
                    if (currentTimes > maxTimes)
                    {
                        maxTimes = currentTimes;
                        majorant = pair.Key;
                    }
                }
            }

            if (maxTimes == 0)
            {
                Console.WriteLine("There no majorant in this sequence!");
            }
            else
            {
                Console.WriteLine("Majorant is: {0}", majorant);
            }
        }
    }
}
