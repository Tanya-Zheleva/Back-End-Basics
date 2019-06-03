namespace _05_LargerThanNeighbours
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int found = GetLargerThanNeighboursCount(numbers);

            Console.WriteLine(found);
        }

        private static int GetLargerThanNeighboursCount(int[] numbers)
        {
            int found = 0;

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    found++;
                }
            }

            return found;
        }
    }
}
