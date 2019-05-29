namespace _10_FindSumInArray
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = int.Parse(Console.ReadLine());
            int start = 0;
            int count = 1;
            bool found = false;

            for (int i = 0; i < elements.Length; i++)
            {
                start = i;
                int currentSum = elements[i];

                for (int j = i + 1; j < elements.Length; j++)
                {
                    if (currentSum == sum)
                    {
                        found = true;
                        break;
                    }

                    if (currentSum > sum)
                    {
                        count = 1;
                        break;
                    }

                    currentSum += elements[j];
                    count++;
                }

                if (found)
                {
                    break;
                }
            }

            for (int i = start; i < start + count; i++)
            {
                Console.Write($"{elements[i]} ");
            }

            Console.WriteLine();
        }
    }
}
