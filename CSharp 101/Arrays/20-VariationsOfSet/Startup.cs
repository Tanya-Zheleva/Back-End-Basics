namespace _20_VariationsOfSet
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] elements = new int[k];

            GenerateVariations(n, k, 0, elements);
        }

        private static void GenerateVariations(int n, int k, int index, int[] elements)
        {
            if (index == k)
            {
                Console.WriteLine($"{{{string.Join(", ", elements)}}}");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    elements[index] = i;
                    GenerateVariations(n, k, index + 1, elements);
                }
            }
        }
    }
}
