namespace _02_GetLargestNumber
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int max = GetMax(numbers[0], numbers[1]);
            max = GetMax(max, numbers[2]);

            Console.WriteLine(max);
        }

        private static int GetMax(int x, int y)
        {
            return x >= y ? x : y;
        }
    }
}
