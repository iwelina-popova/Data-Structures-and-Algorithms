namespace RemoveNumbersThatOccurOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumbersOccurOddNumberRemover
    {
        public static void Main()
        {
            /*
            Write a program that removes from given sequence all numbers that occur odd number of times.
            Example:
            {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
            */

            var numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var result = RemoveNumbersThatOccurOddNumber(numbers);
            Console.WriteLine(string.Join(", ", result));
        }

        private static List<int> RemoveNumbersThatOccurOddNumber(List<int> sequence)
        {
            var result = sequence.Where(n => sequence.Count(x => x == n) % 2 == 0).ToList();

            return result;
        }
    }
}
