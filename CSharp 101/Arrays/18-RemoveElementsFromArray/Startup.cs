namespace _18_RemoveElementsFromArray
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] elements = new int[n];

            for (int i = 0; i < n; i++)
            {
                elements[i] = int.Parse(Console.ReadLine());
            }

            int lis = GetLogestIncreasingSubsequence(elements);
            int deletions = elements.Length - lis;

            Console.WriteLine(deletions);
        }

        private static int GetLogestIncreasingSubsequence(int[] elements)
        {
            int[] sequences = new int[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                sequences[i] = 1;
            }

            for (int i = 1; i < elements.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (elements[i] > elements[j] && sequences[i] < sequences[j] + 1)
                    {
                        sequences[i] = sequences[j] + 1;
                    }
                }
            }

            int result = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                if (result < sequences[i])
                {
                    result = sequences[i];
                }
            }

            return result;
        }
    }
}
