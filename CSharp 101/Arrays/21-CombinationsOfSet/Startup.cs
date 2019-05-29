namespace _21_CombinationsOfSet
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] elements = new int[k];

            GenerateCombinations(n, k, 0, 1, elements);
        }

        private static void GenerateCombinations(int n, int k, int current, int start, int[] elements)
        {
            if (current == k)
            {
                Console.WriteLine($"{{{string.Join(", ", elements)}}}");
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    elements[current] = i;
                    GenerateCombinations(n, k, current + 1, start + 1, elements);
                    start++;
                }
            }
        }
    }
}
