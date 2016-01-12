namespace ColorfulRabbits
{
    using System;
    using System.Collections.Generic;

    public class RabbitsCounter
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> rabbitsGroups = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine()) + 1;
                if (!rabbitsGroups.ContainsKey(number))
                {
                    rabbitsGroups.Add(number, 0);
                }
                else
                {
                    rabbitsGroups[number]++;
                }
            }

            int rabbitsCount = 0;
            foreach (var rabbits in rabbitsGroups)
            {
                rabbitsCount += (int)Math.Ceiling((double)rabbits.Value / rabbits.Key) * rabbits.Key;
            }

            Console.WriteLine(rabbitsCount);
        }
    }
}
