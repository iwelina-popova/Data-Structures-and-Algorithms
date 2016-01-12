namespace BinaryPassword
{
    using System;
    using System.Numerics;

    public class BinaryPasswordHacker
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            BigInteger count = CountStars(input);
            Console.WriteLine(Power(count));
        }

        private static BigInteger CountStars(string input)
        {
            BigInteger count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    count++;
                }
            }

            return count;
        }

        private static BigInteger Power(BigInteger count)
        {
            BigInteger result = 1;
            for (int i = 0; i < count; i++)
            {
                result *= 2;
            }

            return result;
        }
    }
}
