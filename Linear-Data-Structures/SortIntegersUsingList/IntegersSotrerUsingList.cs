namespace SortIntegersUsingList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegersSotrerUsingList
    {
        public static void Main()
        {
            /*
            Write a program that reads a sequence of integers (List<int>) ending with an empty line 
            and sorts them in an increasing order.
            */

            var integerNumbers = new List<int>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != string.Empty)
            {
                var currentNumbers = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var numberAsString in currentNumbers)
                {
                    var number = int.Parse(numberAsString);
                    integerNumbers.Add(number);
                }
            }

            integerNumbers.Sort();

            Console.WriteLine("Sorted numbers:");
            Console.WriteLine(string.Join(", ", integerNumbers));
        }
    }
}
