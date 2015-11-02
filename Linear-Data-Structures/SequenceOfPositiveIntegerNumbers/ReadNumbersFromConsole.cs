namespace SequenceOfPositiveIntegerNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReadNumbersFromConsole
    {
        public static void Main()
        {
            /*
            Write a program that reads from the console a sequence of positive integer numbers.
            The sequence ends when empty line is entered.
            Calculate and print the sum and average of the elements of the sequence.
            Keep the sequence in List<int>.
            */

            var positiveNumbers = new List<int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != string.Empty)
            {
                var currentNumbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var numberAsString in currentNumbers)
                {
                    var number = int.Parse(numberAsString);
                    positiveNumbers.Add(number);
                }
            }

            Console.WriteLine("Sum of the numbers is: {0}", positiveNumbers.Sum());
            Console.WriteLine("Average of the numbers is: {0}", positiveNumbers.Average());
        }
    }
}
