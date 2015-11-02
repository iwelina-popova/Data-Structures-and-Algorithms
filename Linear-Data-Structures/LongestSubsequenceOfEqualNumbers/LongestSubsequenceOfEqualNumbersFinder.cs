namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    public class LongestSubsequenceOfEqualNumbersFinder
    {
        public static void Main()
        {
            /*
            Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.
            Write a program to test whether the method works correctly.
            */

            var numbers = new List<int> { 1, 5, 6, 2, 2, 3, 3, 3, 4 };
            var longestSeq = FindLongestSubsequenceOfEqualNumbers(numbers);
            Console.WriteLine(string.Join(", ", longestSeq));
        }

        private static List<int> FindLongestSubsequenceOfEqualNumbers(IList<int> sequence)
        {
            var longestSequence = new List<int>();

            var currentLongestCount = 1;
            var longestCount = 0;
            var numberOfLongestSequence = 0;
            for (int i = 0; i < sequence.Count - 1; i++)
            {
                if (sequence[i] == sequence[i + 1])
                {
                    currentLongestCount++;
                }
                else
                {
                    if (currentLongestCount > longestCount)
                    {
                        longestCount = currentLongestCount;
                        numberOfLongestSequence = sequence[i];
                    }

                    currentLongestCount = 1;
                }
            }

            if (currentLongestCount > longestCount)
            {
                longestCount = currentLongestCount;
                numberOfLongestSequence = sequence[sequence.Count - 1];
            }

            for (int i = 0; i < longestCount; i++)
            {
                longestSequence.Add(numberOfLongestSequence);
            }

            return longestSequence;
        }
    }
}
