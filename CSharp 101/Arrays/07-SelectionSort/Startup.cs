namespace _07_SelectionSort
{
    using System;

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

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (elements[j] < elements[i])
                    {
                        int old = elements[i];
                        elements[i] = elements[j];
                        elements[j] = old;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
