namespace _09_FrequentNumber
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

            int number = int.MinValue;
            int currentTimesFound = 1;
            int maxTimesFound = 0;

            for (int i = 0; i < n - 1; i++)
            {
                int current = elements[i];

                for (int j = i + 1; j < n; j++)
                {
                    if (elements[j] == current)
                    {
                        currentTimesFound++;
                    }
                }

                if (currentTimesFound > maxTimesFound)
                {
                    maxTimesFound = currentTimesFound;
                    number = current;
                }

                currentTimesFound = 1;
            }

            Console.WriteLine($"{number} ({maxTimesFound} times)");
        }
    }
}
