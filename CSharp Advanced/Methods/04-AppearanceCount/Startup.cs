namespace _04_AppearanceCount
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int x = int.Parse(Console.ReadLine());
            int timesFound = CountAppearances(numbers, x);

            Console.WriteLine(timesFound);
        }

        private static int CountAppearances(int[] numbers, int x)
        {
            int timesFound = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == x)
                {
                    timesFound++;
                }
            }

            return timesFound;
        }
    }
}
