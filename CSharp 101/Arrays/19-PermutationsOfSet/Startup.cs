namespace _19_PermutationsOfSet
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] elements = new int[n];
            int value = 1;

            for (int i = 0; i < n; i++)
            {
                elements[i] = value;
                value++;
            }

            Permutate(elements, 0, elements.Length - 1);
        }

        private static void Permutate(int[] elements, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine($"{{{string.Join(", ", elements)}}}");
            }
            else
            {
                for (int i = left; i <= right; i++)
                {
                    Swap(ref elements[left], ref elements[i]);

                    Permutate(elements, left + 1, right);

                    Swap(ref elements[left], ref elements[i]);
                }
            }
        }

        private static void Swap(ref int x, ref int y)
        {
            int oldX = x;
            x = y;
            y = oldX;
        }
    }
}
