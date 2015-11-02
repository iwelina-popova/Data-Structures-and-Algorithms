namespace FindHowManyTimesOccerNumber
{
    using System;
    using System.Collections.Generic;

    public class NumbersCounter
    {
        public static void Main()
        {
            /*
            Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
            Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
            2 → 2 times
            3 → 4 times
            4 → 3 times
            */

            var numbers = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            var result = CountNumbers(numbers);

            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }

        private static Dictionary<int, int> CountNumbers(int[] numbers)
        {
            var result = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!result.ContainsKey(numbers[i]))
                {
                    result.Add(numbers[i], 1);
                }
                else
                {
                    result[numbers[i]]++;
                }
            }

            return result;
        }
    }
}
