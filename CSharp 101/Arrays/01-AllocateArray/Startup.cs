namespace _01_AllocateArray
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
                elements[i] = i * 5;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
