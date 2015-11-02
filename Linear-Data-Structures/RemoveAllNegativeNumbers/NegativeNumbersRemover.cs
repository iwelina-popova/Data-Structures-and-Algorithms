namespace RemoveAllNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    public class NegativeNumbersRemover
    {
        public static void Main()
        {
            //// Write a program that removes from given sequence all negative numbers.

            var numbers = new List<int> { 1, 0, -5, -8, 16, -16, -100, 100 };

            var positiveNumbers = RemoveNegativeNumbers(numbers);
            positiveNumbers.ForEach(Console.WriteLine);
        }

        private static List<int> RemoveNegativeNumbers(List<int> sequence)
        {
            var positiveNumbers = new List<int>();
            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] >= 0)
                {
                    positiveNumbers.Add(sequence[i]);
                }
            }

            return positiveNumbers;
        } 
    }
}
