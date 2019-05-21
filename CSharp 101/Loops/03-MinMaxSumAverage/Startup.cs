namespace _03_MinMaxSumAverage
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;

            for (int i = 0; i < n; i++)
            {
                double currnet = double.Parse(Console.ReadLine());

                if (currnet < min)
                {
                    min = currnet;
                }

                if (currnet > max)
                {
                    max = currnet;
                }

                sum += currnet;
            }

            Console.WriteLine($"min={min:F2}");
            Console.WriteLine($"max={max:F2}");
            Console.WriteLine($"sum={sum:F2}");
            Console.WriteLine($"avg={(sum / n):F2}");
        }
    }
}
