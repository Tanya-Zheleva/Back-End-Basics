namespace _05_MaxIncreasingSequence
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

            int currentLength = 1;
            int bestLength = 0;

            for (int i = 0; i < n - 1; i++)
            {
                if (elements[i] > elements[i + 1])
                {
                    currentLength++;
                }
                else
                {
                    if (currentLength > bestLength)
                    {
                        bestLength = currentLength;
                    }

                    currentLength = 1;
                }
            }

            Console.WriteLine(bestLength);
        }
    }
}
