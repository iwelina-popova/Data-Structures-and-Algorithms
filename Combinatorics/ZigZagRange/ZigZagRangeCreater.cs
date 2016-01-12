using System;
using System.Linq;

namespace ZigZagRange
{
    public class ZigZagRangeCreater
    {
        private static int n;
        private static int k;
        private static int[] digits;
        private static int[] arr;
        private static bool[] used;
        private static int validRange = 0;
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            n = int.Parse(input[0]);
            k = int.Parse(input[1]);
            arr = new int[k];
            used = new bool[n];
            digits = Enumerable.Range(0, n).ToArray();

            if(k == 1)
            {
                Console.WriteLine(n);
                return;
            }

            GenerateVariationsNoRepetitions(0);
            Console.WriteLine(validRange);
        }

        private static void GenerateVariationsNoRepetitions(int index)
        {
            if (index >= k)
            {
                CheckIfValidRange();
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = i;
                        GenerateVariationsNoRepetitions(index + 1);
                        used[i] = false;
                    }
                }
            }
        }

        private static void CheckIfValidRange()
        {
            for (int i = 0; i < k - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (digits[arr[i]] <= digits[arr[i + 1]])
                    {
                        return;
                    }
                }
                else
                {
                    if (digits[arr[i]] >= digits[arr[i + 1]])
                    {
                        return;
                    }
                }
            }

            validRange++;
        }

        private static void PrintVariations()
        {
            Console.Write("(" + String.Join(", ", arr) + ") --> ( ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(digits[arr[i]] + " ");
            }
            Console.WriteLine(")");
        }
    }
}
