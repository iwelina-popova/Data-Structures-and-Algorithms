namespace ColorfulBalls
{
    using System;
    using System.Numerics;

    public class BallsCombinations
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            var groups = new int[26];

            foreach (var ball in input)
            {
                groups[ball - 'A']++;
            }

            int n = input.Length;

            var factorials = new BigInteger[n + 1];
            factorials[0] = 1;
            for (int i = 0; i < n; i++)
            {
                factorials[i + 1] = factorials[i] * (i + 1);
            }

            BigInteger result = factorials[n];
            foreach (var x in groups)
            {
                result /= factorials[x];
            }

            Console.WriteLine(result);
        }
    }
}
