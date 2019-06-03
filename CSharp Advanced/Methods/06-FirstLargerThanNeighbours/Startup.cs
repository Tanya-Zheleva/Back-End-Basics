namespace _06_FirstLargerThanNeighbours
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = GetFirstLargerThanNeighboursIndex(numbers);

            Console.WriteLine(index);
        }

        private static int GetFirstLargerThanNeighboursIndex(int[] numbers)
        {
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
